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
            this.btnStartMonitor = new System.Windows.Forms.Button();
            this.btnCheckNetwork = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
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
            this.statusStrip1.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.Panel1.SuspendLayout();
            this.pnlMain.Panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartMonitor
            // 
            this.btnStartMonitor.Location = new System.Drawing.Point(16, 16);
            this.btnStartMonitor.Name = "btnStartMonitor";
            this.btnStartMonitor.Size = new System.Drawing.Size(99, 29);
            this.btnStartMonitor.TabIndex = 3;
            this.btnStartMonitor.Text = "Start";
            this.toolTip1.SetToolTip(this.btnStartMonitor, "Start \\ stop monitoring");
            this.btnStartMonitor.UseVisualStyleBackColor = true;
            this.btnStartMonitor.Click += new System.EventHandler(this.btnStartMonitor_Click);
            // 
            // btnCheckNetwork
            // 
            this.btnCheckNetwork.Location = new System.Drawing.Point(474, 16);
            this.btnCheckNetwork.Name = "btnCheckNetwork";
            this.btnCheckNetwork.Size = new System.Drawing.Size(211, 29);
            this.btnCheckNetwork.TabIndex = 4;
            this.btnCheckNetwork.Text = "Check Network";
            this.btnCheckNetwork.UseVisualStyleBackColor = true;
            this.btnCheckNetwork.Click += new System.EventHandler(this.btnCheckNetwork_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus});
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
            this.pnlControls.Controls.Add(this.btnClearLog);
            this.pnlControls.Controls.Add(this.chkClearLog);
            this.pnlControls.Controls.Add(this.btnToggleInfo);
            this.pnlControls.Controls.Add(this.btnStartMonitor);
            this.pnlControls.Controls.Add(this.btnCheckNetwork);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(918, 107);
            this.pnlControls.TabIndex = 6;
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnection.AutoEllipsis = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(12, 70);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblConnection.Size = new System.Drawing.Size(894, 34);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "label1";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(369, 16);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(99, 29);
            this.btnClearLog.TabIndex = 7;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // chkClearLog
            // 
            this.chkClearLog.AutoSize = true;
            this.chkClearLog.Checked = true;
            this.chkClearLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClearLog.Location = new System.Drawing.Point(139, 21);
            this.chkClearLog.Name = "chkClearLog";
            this.chkClearLog.Size = new System.Drawing.Size(205, 21);
            this.chkClearLog.TabIndex = 6;
            this.chkClearLog.Text = "Clear log on start monitoring";
            this.chkClearLog.UseVisualStyleBackColor = true;
            // 
            // btnToggleInfo
            // 
            this.btnToggleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleInfo.Location = new System.Drawing.Point(873, 16);
            this.btnToggleInfo.Name = "btnToggleInfo";
            this.btnToggleInfo.Size = new System.Drawing.Size(33, 29);
            this.btnToggleInfo.TabIndex = 5;
            this.btnToggleInfo.Text = "i";
            this.toolTip1.SetToolTip(this.btnToggleInfo, "Show \\ hide software information");
            this.btnToggleInfo.UseVisualStyleBackColor = true;
            this.btnToggleInfo.Click += new System.EventHandler(this.btnToggleInfo_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 107);
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
            this.pnlMain.Size = new System.Drawing.Size(918, 508);
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
            this.gridLog.Size = new System.Drawing.Size(567, 494);
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
            this.lblDescription.Size = new System.Drawing.Size(305, 414);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSoftwareInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(8, 421);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 637);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Network Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlMain.Panel1.ResumeLayout(false);
            this.pnlMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartMonitor;
        private System.Windows.Forms.Button btnCheckNetwork;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.SplitContainer pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSoftwareInfo;
        private System.Windows.Forms.Button btnToggleInfo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.CheckBox chkClearLog;
        private System.Windows.Forms.DataGridView gridLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLog;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

