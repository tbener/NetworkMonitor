namespace NetworkMonitor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.chkClearLog = new System.Windows.Forms.CheckBox();
            this.btnToggleInfo = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.SplitContainer();
            this.gridLog = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSoftwareInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tbStartMonitor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCheckNetwork = new System.Windows.Forms.ToolStripButton();
            this.tbClearLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbFacebook = new System.Windows.Forms.ToolStripButton();
            this.tbLinkedin = new System.Windows.Forms.ToolStripButton();
            this.tbEmail = new System.Windows.Forms.ToolStripSplitButton();
            this.tbCopyEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.Panel1.SuspendLayout();
            this.pnlMain.Panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(899, 17);
            this.txtStatus.Spring = true;
            this.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblConnection);
            this.pnlControls.Controls.Add(this.chkClearLog);
            this.pnlControls.Controls.Add(this.btnToggleInfo);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 28);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(918, 94);
            this.pnlControls.TabIndex = 6;
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnection.AutoEllipsis = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(12, 57);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblConnection.Size = new System.Drawing.Size(894, 34);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "label1";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkClearLog
            // 
            this.chkClearLog.AutoSize = true;
            this.chkClearLog.Checked = true;
            this.chkClearLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClearLog.Location = new System.Drawing.Point(16, 16);
            this.chkClearLog.Name = "chkClearLog";
            this.chkClearLog.Size = new System.Drawing.Size(205, 21);
            this.chkClearLog.TabIndex = 6;
            this.chkClearLog.Text = "Clear log on start monitoring";
            this.chkClearLog.UseVisualStyleBackColor = true;
            // 
            // btnToggleInfo
            // 
            this.btnToggleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleInfo.Location = new System.Drawing.Point(803, 16);
            this.btnToggleInfo.Name = "btnToggleInfo";
            this.btnToggleInfo.Size = new System.Drawing.Size(103, 29);
            this.btnToggleInfo.TabIndex = 5;
            this.btnToggleInfo.Text = "More Info";
            this.toolTip1.SetToolTip(this.btnToggleInfo, "Show \\ hide software information");
            this.btnToggleInfo.UseVisualStyleBackColor = true;
            this.btnToggleInfo.Click += new System.EventHandler(this.btnToggleInfo_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 122);
            this.pnlMain.Name = "pnlMain";
            // 
            // pnlMain.Panel1
            // 
            this.pnlMain.Panel1.Controls.Add(this.gridLog);
            this.pnlMain.Panel1.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            // 
            // pnlMain.Panel2
            // 
            this.pnlMain.Panel2.Controls.Add(this.lblDescription);
            this.pnlMain.Panel2.Controls.Add(this.panel1);
            this.pnlMain.Panel2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnlMain.Size = new System.Drawing.Size(918, 493);
            this.pnlMain.SplitterDistance = 591;
            this.pnlMain.SplitterWidth = 6;
            this.pnlMain.TabIndex = 7;
            // 
            // gridLog
            // 
            this.gridLog.AllowUserToAddRows = false;
            this.gridLog.AllowUserToDeleteRows = false;
            this.gridLog.AllowUserToResizeRows = false;
            this.gridLog.BackgroundColor = System.Drawing.Color.White;
            this.gridLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLog.ColumnHeadersVisible = false;
            this.gridLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime,
            this.colLog});
            this.gridLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLog.GridColor = System.Drawing.Color.White;
            this.gridLog.Location = new System.Drawing.Point(12, 7);
            this.gridLog.Name = "gridLog";
            this.gridLog.ReadOnly = true;
            this.gridLog.RowHeadersVisible = false;
            this.gridLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLog.Size = new System.Drawing.Size(567, 479);
            this.gridLog.TabIndex = 1;
            this.gridLog.TabStop = false;
            // 
            // colTime
            // 
            this.colTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTime.HeaderText = "Time";
            this.colTime.MinimumWidth = 150;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Width = 150;
            // 
            // colLog
            // 
            this.colLog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLog.HeaderText = "Log";
            this.colLog.Name = "colLog";
            this.colLog.ReadOnly = true;
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(8, 7);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(305, 399);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSoftwareInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(8, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 80);
            this.panel1.TabIndex = 5;
            // 
            // lblSoftwareInfo
            // 
            this.lblSoftwareInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoftwareInfo.Location = new System.Drawing.Point(0, 0);
            this.lblSoftwareInfo.Name = "lblSoftwareInfo";
            this.lblSoftwareInfo.Size = new System.Drawing.Size(305, 80);
            this.lblSoftwareInfo.TabIndex = 0;
            this.lblSoftwareInfo.Text = "Info:\r\nAuthor:";
            this.lblSoftwareInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbStartMonitor,
            this.toolStripSeparator3,
            this.tbClearLog,
            this.toolStripSeparator5,
            this.tbCheckNetwork,
            this.tbFacebook,
            this.tbLinkedin,
            this.tbEmail,
            this.toolStripLabel1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(918, 28);
            this.toolStrip.TabIndex = 8;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton1.Text = "Start";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton2.Text = "Clear Log";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(124, 22);
            this.toolStripButton3.Text = "Check Network";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton4.Text = "Start";
            this.toolStripButton4.ToolTipText = "Start Monitoring";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton5.Text = "Start";
            // 
            // tbStartMonitor
            // 
            this.tbStartMonitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbStartMonitor.Image = ((System.Drawing.Image)(resources.GetObject("tbStartMonitor.Image")));
            this.tbStartMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStartMonitor.Name = "tbStartMonitor";
            this.tbStartMonitor.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbStartMonitor.Size = new System.Drawing.Size(161, 25);
            this.tbStartMonitor.Text = "Start Monitoring";
            this.tbStartMonitor.Click += new System.EventHandler(this.tbStartMonitor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // tbCheckNetwork
            // 
            this.tbCheckNetwork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbCheckNetwork.Image = ((System.Drawing.Image)(resources.GetObject("tbCheckNetwork.Image")));
            this.tbCheckNetwork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCheckNetwork.Name = "tbCheckNetwork";
            this.tbCheckNetwork.Size = new System.Drawing.Size(130, 25);
            this.tbCheckNetwork.Text = "Check Network";
            this.tbCheckNetwork.Click += new System.EventHandler(this.tbCheckNetwork_Click);
            // 
            // tbClearLog
            // 
            this.tbClearLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbClearLog.Image = ((System.Drawing.Image)(resources.GetObject("tbClearLog.Image")));
            this.tbClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClearLog.Name = "tbClearLog";
            this.tbClearLog.Size = new System.Drawing.Size(85, 25);
            this.tbClearLog.Text = "Clear Log";
            this.tbClearLog.Click += new System.EventHandler(this.tbClearLog_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 25);
            this.toolStripLabel1.Text = "Made by: Tal Bener";
            // 
            // tbFacebook
            // 
            this.tbFacebook.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbFacebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFacebook.Image = ((System.Drawing.Image)(resources.GetObject("tbFacebook.Image")));
            this.tbFacebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFacebook.Name = "tbFacebook";
            this.tbFacebook.Size = new System.Drawing.Size(23, 25);
            this.tbFacebook.Text = "toolStripButton9";
            this.tbFacebook.ToolTipText = "Open my Facebook page in browser";
            this.tbFacebook.Click += new System.EventHandler(this.tbFacebook_Click);
            this.tbFacebook.MouseEnter += new System.EventHandler(this.tbLinks_MouseEnter);
            this.tbFacebook.MouseLeave += new System.EventHandler(this.tbLinks_MouseLeave);
            // 
            // tbLinkedin
            // 
            this.tbLinkedin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbLinkedin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbLinkedin.Image = ((System.Drawing.Image)(resources.GetObject("tbLinkedin.Image")));
            this.tbLinkedin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbLinkedin.Name = "tbLinkedin";
            this.tbLinkedin.Size = new System.Drawing.Size(23, 25);
            this.tbLinkedin.Text = "toolStripButton10";
            this.tbLinkedin.ToolTipText = "Open my LinkedIn profile in browser";
            this.tbLinkedin.Click += new System.EventHandler(this.tbLinkedin_Click);
            this.tbLinkedin.MouseEnter += new System.EventHandler(this.tbLinks_MouseEnter);
            this.tbLinkedin.MouseLeave += new System.EventHandler(this.tbLinks_MouseLeave);
            // 
            // tbEmail
            // 
            this.tbEmail.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbEmail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbCopyEmail});
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(125, 25);
            this.tbEmail.Text = "tbener@gmail.com";
            this.tbEmail.ToolTipText = "Send me mail. Your opinion matters!";
            this.tbEmail.ButtonClick += new System.EventHandler(this.tbEmail_ButtonClick);
            this.tbEmail.MouseEnter += new System.EventHandler(this.tbLinks_MouseEnter);
            this.tbEmail.MouseLeave += new System.EventHandler(this.tbLinks_MouseLeave);
            // 
            // tbCopyEmail
            // 
            this.tbCopyEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCopyEmail.Name = "tbCopyEmail";
            this.tbCopyEmail.Size = new System.Drawing.Size(152, 22);
            this.tbCopyEmail.Text = "Copy Address";
            this.tbCopyEmail.ToolTipText = "Copy my mail address to clipboard";
            this.tbCopyEmail.Click += new System.EventHandler(this.tbCopyEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 637);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Network Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlMain.Panel1.ResumeLayout(false);
            this.pnlMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.SplitContainer pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSoftwareInfo;
        private System.Windows.Forms.Button btnToggleInfo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox chkClearLog;
        private System.Windows.Forms.DataGridView gridLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLog;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton tbStartMonitor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbCheckNetwork;
        private System.Windows.Forms.ToolStripButton tbClearLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tbFacebook;
        private System.Windows.Forms.ToolStripButton tbLinkedin;
        private System.Windows.Forms.ToolStripSplitButton tbEmail;
        private System.Windows.Forms.ToolStripMenuItem tbCopyEmail;
    }
}

