using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace FreezeMonitor
{
    public partial class frmFreezeMonitor : Form
    {
        private long mInterval = 50;
        private long mFreezeThold = 500;

        private long mTimerElapsedTime = 0;
        private long mLastTimerValue = 0;
        private long mLastDev = 0;
        private long mMaxDev = 0;
        private long mFreezeCount = 0;

        private Timer mTimer = null;
        private Thread mThread = null;
        private volatile bool mRunning = false;

        private String mVersion = "0.0";

        private static Stopwatch sStopWatch = new Stopwatch();

        public static long GetDiagTimerMillis()
        {
            return sStopWatch.ElapsedMilliseconds;
        }

        public frmFreezeMonitor()
        {
            InitializeComponent();

            // Set name and version to window title.
            // Major.Minor is used always. Build and revision are added if they're != 0.
            Version version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
            mVersion = version.Major.ToString() + "." + version.Minor.ToString();
            if (version.Build > 0 || version.Revision > 0)
            {
                mVersion += "." + version.Build.ToString();
                if (version.Revision > 0)
                {
                    mVersion += "." + version.Revision.ToString();
                }
            }
            Text = Text + " " + mVersion;

            // Select defaults from combo boxes
            cbStep.SelectedIndex = 0;
            cbFreezeThold.SelectedIndex = 3;
        }

        private void textBox_FocusEnter(object sender, EventArgs e)
        {
            // Just for focus to some unusable element
            lblStep.Focus();
        }

        public void Reset()
        {
            sStopWatch.Stop();
            sStopWatch.Reset();
            sStopWatch.Start();

            Thread.VolatileWrite(ref mTimerElapsedTime, 0);
            Thread.VolatileWrite(ref mLastTimerValue, 0);
            Thread.VolatileWrite(ref mLastDev, 0);
            Thread.VolatileWrite(ref mMaxDev, 0);
            Thread.VolatileWrite(ref mFreezeCount, 0);

            UpdateUi();
            Thread.VolatileWrite(ref mLastTimerValue, GetDiagTimerMillis());
        }

        public void Tick()
        {
            long newTime = GetDiagTimerMillis();
            long tempLong = Thread.VolatileRead(ref mLastTimerValue);
            long elapsed = newTime - tempLong;
            long deviation = elapsed - mInterval;
            tempLong = Thread.VolatileRead(ref mTimerElapsedTime);
            tempLong += elapsed;
            Thread.VolatileWrite(ref mTimerElapsedTime, tempLong);
            Thread.VolatileWrite(ref mLastTimerValue, newTime);
            Thread.VolatileWrite(ref mLastDev, deviation);
            tempLong = Thread.VolatileRead(ref mMaxDev);
            if (deviation > tempLong)
            {
                Thread.VolatileWrite(ref mMaxDev, deviation);
            }
            if (deviation > mFreezeThold)
            {
                tempLong = Thread.VolatileRead(ref mFreezeCount);
                tempLong += 1;
                Thread.VolatileWrite(ref mFreezeCount, tempLong);
                UpdateUi(newTime, deviation);
            }
            else
            {
                UpdateUi();
            }
        }

        private void UpdateUi()
        {
            UpdateUi(0, 0);
        }
        private void UpdateUi(long timestamp, long freezetime)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    long tempLong = Thread.VolatileRead(ref mTimerElapsedTime);
                    tbDiagElapsed.Text = tempLong.ToString();
                    tempLong = Thread.VolatileRead(ref mLastDev);
                    tbDiagLast.Text = tempLong.ToString();
                    tempLong = Thread.VolatileRead(ref mMaxDev);
                    tbDiagMax.Text = tempLong.ToString();
                    tempLong = Thread.VolatileRead(ref mFreezeCount);
                    tbDiagFreezes.Text = tempLong.ToString();
                    if (timestamp > 0 && freezetime > 0)
                    {
                        lstFreezes.Items.Add(new ListViewItem(new String[] { (lstFreezes.Items.Count + 1).ToString(), timestamp.ToString(), freezetime.ToString() }));
                    }
                }));
            }
            catch
            {
                // Ignore
            }
        }

        private void HandleStartStop()
        {
            if (null == mThread)
            {
                // Start
                cbFreezeThold.Enabled = false;
                cbStep.Enabled = false;
                lstFreezes.Items.Clear();
                btnStartStop.Text = "Stop";
                mRunning = true;
                mInterval = Int64.Parse(cbStep.Text);
                mFreezeThold = Int64.Parse(cbFreezeThold.Text);
                mTimer = new Timer(this, Int32.Parse(cbStep.Text));
                mThread = new Thread(new ThreadStart(mTimer.Run));
                mThread.Start();
            }
            else
            {
                // Stop
                btnStartStop.Enabled = false;
                btnStartStop.Text = "Start";
                mRunning = false;
                UpdateUi();
                // Looks like you have to call Interrupt for sleeping thread or it'll freeze in Join in C#.
                mThread.Interrupt();
                mThread.Join();
                mThread = null;
                mTimer = null;
                btnStartStop.Enabled = true;
                cbFreezeThold.Enabled = true;
                cbStep.Enabled = true;
            }
        }

        internal bool IsRunning()
        {
            return mRunning;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            HandleStartStop();
        }

        private void frm_Closing(object sender, FormClosingEventArgs e)
        {
            if (mThread != null)
            {
                HandleStartStop();
            }
        }
    }

    public class Timer
    {
        frmFreezeMonitor mForm;
        int mInterval;

        public Timer(frmFreezeMonitor form, int interval)
        {
            mForm = form;
            mInterval = interval;
        }

        public void Run()
        {
            mForm.Reset();
            while (mForm.IsRunning())
            {
                try
                {
                    Thread.Sleep(mInterval);
                }
                catch (ThreadInterruptedException)
                {
                    // Ignore
                }
                if (mForm.IsRunning())
                {
                    mForm.Tick();
                }
            }
        }
    }
}
