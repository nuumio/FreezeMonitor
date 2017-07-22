namespace FreezeMonitor
{
    partial class frmFreezeMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFreezeMonitor));
            this.gbDiag = new System.Windows.Forms.GroupBox();
            this.lstFreezes = new System.Windows.Forms.ListView();
            this.chFreezeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFreezeTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFreezeDeviation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbDiagFreezes = new System.Windows.Forms.TextBox();
            this.lblDiagFreeze = new System.Windows.Forms.Label();
            this.tbDiagMax = new System.Windows.Forms.TextBox();
            this.tbDiagLast = new System.Windows.Forms.TextBox();
            this.lblDiagMax = new System.Windows.Forms.Label();
            this.lblDiagLast = new System.Windows.Forms.Label();
            this.tbDiagElapsed = new System.Windows.Forms.TextBox();
            this.lblDiagElapsed = new System.Windows.Forms.Label();
            this.cbStep = new System.Windows.Forms.ComboBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblFreezeThold = new System.Windows.Forms.Label();
            this.cbFreezeThold = new System.Windows.Forms.ComboBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.gbDiag.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDiag
            // 
            this.gbDiag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDiag.Controls.Add(this.lstFreezes);
            this.gbDiag.Controls.Add(this.tbDiagFreezes);
            this.gbDiag.Controls.Add(this.lblDiagFreeze);
            this.gbDiag.Controls.Add(this.tbDiagMax);
            this.gbDiag.Controls.Add(this.tbDiagLast);
            this.gbDiag.Controls.Add(this.lblDiagMax);
            this.gbDiag.Controls.Add(this.lblDiagLast);
            this.gbDiag.Controls.Add(this.tbDiagElapsed);
            this.gbDiag.Controls.Add(this.lblDiagElapsed);
            this.gbDiag.Location = new System.Drawing.Point(13, 163);
            this.gbDiag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDiag.Name = "gbDiag";
            this.gbDiag.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDiag.Size = new System.Drawing.Size(424, 324);
            this.gbDiag.TabIndex = 0;
            this.gbDiag.TabStop = false;
            this.gbDiag.Text = "Timer && Thread Monitoring";
            // 
            // lstFreezes
            // 
            this.lstFreezes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFreezes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFreezeNumber,
            this.chFreezeTimestamp,
            this.chFreezeDeviation});
            this.lstFreezes.GridLines = true;
            this.lstFreezes.Location = new System.Drawing.Point(7, 166);
            this.lstFreezes.Name = "lstFreezes";
            this.lstFreezes.Size = new System.Drawing.Size(409, 150);
            this.lstFreezes.TabIndex = 7;
            this.lstFreezes.UseCompatibleStateImageBehavior = false;
            this.lstFreezes.View = System.Windows.Forms.View.Details;
            // 
            // chFreezeNumber
            // 
            this.chFreezeNumber.Text = "";
            this.chFreezeNumber.Width = 40;
            // 
            // chFreezeTimestamp
            // 
            this.chFreezeTimestamp.Text = "Timestamp (ms)";
            this.chFreezeTimestamp.Width = 180;
            // 
            // chFreezeDeviation
            // 
            this.chFreezeDeviation.Text = "Deviation (ms)";
            this.chFreezeDeviation.Width = 170;
            // 
            // tbDiagFreezes
            // 
            this.tbDiagFreezes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiagFreezes.BackColor = System.Drawing.SystemColors.Window;
            this.tbDiagFreezes.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiagFreezes.Location = new System.Drawing.Point(294, 122);
            this.tbDiagFreezes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDiagFreezes.Name = "tbDiagFreezes";
            this.tbDiagFreezes.ReadOnly = true;
            this.tbDiagFreezes.Size = new System.Drawing.Size(122, 26);
            this.tbDiagFreezes.TabIndex = 7;
            this.tbDiagFreezes.TabStop = false;
            this.tbDiagFreezes.Text = "0";
            this.tbDiagFreezes.Enter += new System.EventHandler(this.textBox_FocusEnter);
            // 
            // lblDiagFreeze
            // 
            this.lblDiagFreeze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiagFreeze.Location = new System.Drawing.Point(17, 125);
            this.lblDiagFreeze.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagFreeze.Name = "lblDiagFreeze";
            this.lblDiagFreeze.Size = new System.Drawing.Size(278, 20);
            this.lblDiagFreeze.TabIndex = 6;
            this.lblDiagFreeze.Text = "Freeze count:";
            this.lblDiagFreeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDiagMax
            // 
            this.tbDiagMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiagMax.BackColor = System.Drawing.SystemColors.Window;
            this.tbDiagMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiagMax.Location = new System.Drawing.Point(294, 90);
            this.tbDiagMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDiagMax.Name = "tbDiagMax";
            this.tbDiagMax.ReadOnly = true;
            this.tbDiagMax.Size = new System.Drawing.Size(122, 26);
            this.tbDiagMax.TabIndex = 5;
            this.tbDiagMax.TabStop = false;
            this.tbDiagMax.Text = "0";
            this.tbDiagMax.Enter += new System.EventHandler(this.textBox_FocusEnter);
            // 
            // tbDiagLast
            // 
            this.tbDiagLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiagLast.BackColor = System.Drawing.SystemColors.Window;
            this.tbDiagLast.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiagLast.Location = new System.Drawing.Point(294, 57);
            this.tbDiagLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDiagLast.Name = "tbDiagLast";
            this.tbDiagLast.ReadOnly = true;
            this.tbDiagLast.Size = new System.Drawing.Size(122, 26);
            this.tbDiagLast.TabIndex = 4;
            this.tbDiagLast.TabStop = false;
            this.tbDiagLast.Text = "0";
            this.tbDiagLast.Enter += new System.EventHandler(this.textBox_FocusEnter);
            // 
            // lblDiagMax
            // 
            this.lblDiagMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiagMax.Location = new System.Drawing.Point(17, 92);
            this.lblDiagMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagMax.Name = "lblDiagMax";
            this.lblDiagMax.Size = new System.Drawing.Size(278, 20);
            this.lblDiagMax.TabIndex = 3;
            this.lblDiagMax.Text = "Max thread wakeup deviation (ms):";
            this.lblDiagMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiagLast
            // 
            this.lblDiagLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiagLast.Location = new System.Drawing.Point(17, 60);
            this.lblDiagLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagLast.Name = "lblDiagLast";
            this.lblDiagLast.Size = new System.Drawing.Size(278, 20);
            this.lblDiagLast.TabIndex = 2;
            this.lblDiagLast.Text = "Last thread wakeup deviation (ms):";
            this.lblDiagLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDiagElapsed
            // 
            this.tbDiagElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiagElapsed.BackColor = System.Drawing.SystemColors.Window;
            this.tbDiagElapsed.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiagElapsed.Location = new System.Drawing.Point(294, 25);
            this.tbDiagElapsed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDiagElapsed.Name = "tbDiagElapsed";
            this.tbDiagElapsed.ReadOnly = true;
            this.tbDiagElapsed.Size = new System.Drawing.Size(122, 26);
            this.tbDiagElapsed.TabIndex = 1;
            this.tbDiagElapsed.TabStop = false;
            this.tbDiagElapsed.Text = "0";
            this.tbDiagElapsed.Enter += new System.EventHandler(this.textBox_FocusEnter);
            // 
            // lblDiagElapsed
            // 
            this.lblDiagElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiagElapsed.Location = new System.Drawing.Point(17, 28);
            this.lblDiagElapsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagElapsed.Name = "lblDiagElapsed";
            this.lblDiagElapsed.Size = new System.Drawing.Size(278, 20);
            this.lblDiagElapsed.TabIndex = 0;
            this.lblDiagElapsed.Text = "Diagnostic timer elapsed time (ms):";
            this.lblDiagElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbStep
            // 
            this.cbStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStep.FormattingEnabled = true;
            this.cbStep.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "10000"});
            this.cbStep.Location = new System.Drawing.Point(296, 23);
            this.cbStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStep.Name = "cbStep";
            this.cbStep.Size = new System.Drawing.Size(120, 28);
            this.cbStep.TabIndex = 2;
            // 
            // lblStep
            // 
            this.lblStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStep.Location = new System.Drawing.Point(24, 28);
            this.lblStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(270, 20);
            this.lblStep.TabIndex = 3;
            this.lblStep.Text = "Thread sleep time (ms):";
            this.lblStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFreezeThold
            // 
            this.lblFreezeThold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFreezeThold.Location = new System.Drawing.Point(24, 60);
            this.lblFreezeThold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFreezeThold.Name = "lblFreezeThold";
            this.lblFreezeThold.Size = new System.Drawing.Size(270, 20);
            this.lblFreezeThold.TabIndex = 5;
            this.lblFreezeThold.Text = "Freeze threshold (ms):";
            this.lblFreezeThold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbFreezeThold
            // 
            this.cbFreezeThold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFreezeThold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFreezeThold.FormattingEnabled = true;
            this.cbFreezeThold.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "10000"});
            this.cbFreezeThold.Location = new System.Drawing.Point(296, 55);
            this.cbFreezeThold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFreezeThold.Name = "cbFreezeThold";
            this.cbFreezeThold.Size = new System.Drawing.Size(120, 28);
            this.cbFreezeThold.TabIndex = 4;
            // 
            // gbControl
            // 
            this.gbControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControl.Controls.Add(this.btnStartStop);
            this.gbControl.Controls.Add(this.lblFreezeThold);
            this.gbControl.Controls.Add(this.cbFreezeThold);
            this.gbControl.Controls.Add(this.cbStep);
            this.gbControl.Controls.Add(this.lblStep);
            this.gbControl.Location = new System.Drawing.Point(13, 14);
            this.gbControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbControl.Name = "gbControl";
            this.gbControl.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbControl.Size = new System.Drawing.Size(424, 139);
            this.gbControl.TabIndex = 6;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Controls";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(8, 93);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(408, 35);
            this.btnStartStop.TabIndex = 7;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // frmFreezeMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 501);
            this.Controls.Add(this.gbDiag);
            this.Controls.Add(this.gbControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(472, 557);
            this.Name = "frmFreezeMonitor";
            this.Text = "Freeze Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Closing);
            this.gbDiag.ResumeLayout(false);
            this.gbDiag.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDiag;
        private System.Windows.Forms.Label lblDiagLast;
        private System.Windows.Forms.TextBox tbDiagElapsed;
        private System.Windows.Forms.Label lblDiagElapsed;
        private System.Windows.Forms.Label lblDiagMax;
        private System.Windows.Forms.TextBox tbDiagMax;
        private System.Windows.Forms.TextBox tbDiagLast;
        private System.Windows.Forms.TextBox tbDiagFreezes;
        private System.Windows.Forms.Label lblDiagFreeze;
        private System.Windows.Forms.ComboBox cbStep;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label lblFreezeThold;
        private System.Windows.Forms.ComboBox cbFreezeThold;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.ListView lstFreezes;
        private System.Windows.Forms.ColumnHeader chFreezeNumber;
        private System.Windows.Forms.ColumnHeader chFreezeTimestamp;
        private System.Windows.Forms.ColumnHeader chFreezeDeviation;
    }
}

