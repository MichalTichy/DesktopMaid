namespace DesktopMaid
{
    partial class DesktopMaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopMaid));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.lVLog = new System.Windows.Forms.ListView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListView();
            this.linkRefresh = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.butRemove = new System.Windows.Forms.Button();
            this.butPreserve = new System.Windows.Forms.Button();
            this.butClean = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.chbStartMinimalized = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.chbAutoRestore = new System.Windows.Forms.CheckBox();
            this.cbRunAtStartup = new System.Windows.Forms.CheckBox();
            this.butBrowse = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.autoRestoreTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayRestoreNow = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabRestore.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRestore);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRestore
            // 
            this.tabRestore.Controls.Add(this.lVLog);
            this.tabRestore.Controls.Add(this.labelInfo);
            this.tabRestore.Controls.Add(this.lbItems);
            this.tabRestore.Controls.Add(this.linkRefresh);
            this.tabRestore.Controls.Add(this.label5);
            this.tabRestore.Controls.Add(this.Log);
            this.tabRestore.Controls.Add(this.butCancel);
            this.tabRestore.Controls.Add(this.progressBar);
            this.tabRestore.Controls.Add(this.butRemove);
            this.tabRestore.Controls.Add(this.butPreserve);
            this.tabRestore.Controls.Add(this.butClean);
            this.tabRestore.Controls.Add(this.label2);
            this.tabRestore.Controls.Add(this.label1);
            this.tabRestore.Location = new System.Drawing.Point(4, 25);
            this.tabRestore.Margin = new System.Windows.Forms.Padding(4);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(4);
            this.tabRestore.Size = new System.Drawing.Size(699, 401);
            this.tabRestore.TabIndex = 0;
            this.tabRestore.Text = "Restore desktop layout";
            this.tabRestore.UseVisualStyleBackColor = true;
            // 
            // lVLog
            // 
            this.lVLog.Location = new System.Drawing.Point(351, 186);
            this.lVLog.Margin = new System.Windows.Forms.Padding(4);
            this.lVLog.MultiSelect = false;
            this.lVLog.Name = "lVLog";
            this.lVLog.Size = new System.Drawing.Size(333, 146);
            this.lVLog.TabIndex = 14;
            this.lVLog.UseCompatibleStateImageBehavior = false;
            this.lVLog.View = System.Windows.Forms.View.List;
            this.lVLog.DoubleClick += new System.EventHandler(this.lVLog_DoubleClick);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(347, 320);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 17);
            this.labelInfo.TabIndex = 13;
            // 
            // lbItems
            // 
            this.lbItems.Location = new System.Drawing.Point(16, 27);
            this.lbItems.Margin = new System.Windows.Forms.Padding(4);
            this.lbItems.Name = "lbItems";
            this.lbItems.ShowItemToolTips = true;
            this.lbItems.Size = new System.Drawing.Size(321, 340);
            this.lbItems.TabIndex = 12;
            this.lbItems.UseCompatibleStateImageBehavior = false;
            this.lbItems.View = System.Windows.Forms.View.List;
            // 
            // linkRefresh
            // 
            this.linkRefresh.AutoSize = true;
            this.linkRefresh.Location = new System.Drawing.Point(261, 7);
            this.linkRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRefresh.Name = "linkRefresh";
            this.linkRefresh.Size = new System.Drawing.Size(73, 17);
            this.linkRefresh.TabIndex = 11;
            this.linkRefresh.TabStop = true;
            this.linkRefresh.Text = "REFRESH";
            this.linkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRefresh_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current items on desktop";
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(347, 166);
            this.Log.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(32, 17);
            this.Log.TabIndex = 9;
            this.Log.Text = "Log";
            // 
            // butCancel
            // 
            this.butCancel.Enabled = false;
            this.butCancel.Location = new System.Drawing.Point(623, 340);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(63, 28);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(348, 340);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(267, 28);
            this.progressBar.TabIndex = 6;
            // 
            // butRemove
            // 
            this.butRemove.Location = new System.Drawing.Point(348, 134);
            this.butRemove.Margin = new System.Windows.Forms.Padding(4);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(337, 28);
            this.butRemove.TabIndex = 5;
            this.butRemove.Text = "Dont preserve selected items";
            this.butRemove.UseVisualStyleBackColor = true;
            this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
            // 
            // butPreserve
            // 
            this.butPreserve.Location = new System.Drawing.Point(348, 98);
            this.butPreserve.Margin = new System.Windows.Forms.Padding(4);
            this.butPreserve.Name = "butPreserve";
            this.butPreserve.Size = new System.Drawing.Size(337, 28);
            this.butPreserve.TabIndex = 4;
            this.butPreserve.Text = "Preserve selected items";
            this.butPreserve.UseVisualStyleBackColor = true;
            this.butPreserve.Click += new System.EventHandler(this.butPreserve_Click);
            // 
            // butClean
            // 
            this.butClean.Location = new System.Drawing.Point(351, 27);
            this.butClean.Margin = new System.Windows.Forms.Padding(4);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(337, 52);
            this.butClean.TabIndex = 3;
            this.butClean.Text = "Clean desktop";
            this.butClean.UseVisualStyleBackColor = true;
            this.butClean.Click += new System.EventHandler(this.butClean_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(191, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unwanted files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(28, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Files to preserve";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.chbStartMinimalized);
            this.tabSettings.Controls.Add(this.label4);
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Controls.Add(this.numInterval);
            this.tabSettings.Controls.Add(this.chbAutoRestore);
            this.tabSettings.Controls.Add(this.cbRunAtStartup);
            this.tabSettings.Controls.Add(this.butBrowse);
            this.tabSettings.Controls.Add(this.tbPath);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(4);
            this.tabSettings.Size = new System.Drawing.Size(699, 401);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // chbStartMinimalized
            // 
            this.chbStartMinimalized.AutoSize = true;
            this.chbStartMinimalized.Location = new System.Drawing.Point(12, 140);
            this.chbStartMinimalized.Name = "chbStartMinimalized";
            this.chbStartMinimalized.Size = new System.Drawing.Size(135, 21);
            this.chbStartMinimalized.TabIndex = 7;
            this.chbStartMinimalized.Text = "start minimalized";
            this.chbStartMinimalized.UseVisualStyleBackColor = true;
            this.chbStartMinimalized.CheckedChanged += new System.EventHandler(this.chbStartMinimalized_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "interval:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "minutes";
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(475, 111);
            this.numInterval.Margin = new System.Windows.Forms.Padding(4);
            this.numInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(160, 22);
            this.numInterval.TabIndex = 4;
            this.numInterval.ValueChanged += new System.EventHandler(this.numInterval_ValueChanged);
            // 
            // chbAutoRestore
            // 
            this.chbAutoRestore.AutoSize = true;
            this.chbAutoRestore.Location = new System.Drawing.Point(12, 112);
            this.chbAutoRestore.Margin = new System.Windows.Forms.Padding(4);
            this.chbAutoRestore.Name = "chbAutoRestore";
            this.chbAutoRestore.Size = new System.Drawing.Size(212, 21);
            this.chbAutoRestore.TabIndex = 3;
            this.chbAutoRestore.Text = "restore desktop automaticaly";
            this.chbAutoRestore.UseVisualStyleBackColor = true;
            this.chbAutoRestore.CheckedChanged += new System.EventHandler(this.chbAutoRestore_CheckedChanged);
            // 
            // cbRunAtStartup
            // 
            this.cbRunAtStartup.AutoSize = true;
            this.cbRunAtStartup.Location = new System.Drawing.Point(12, 84);
            this.cbRunAtStartup.Margin = new System.Windows.Forms.Padding(4);
            this.cbRunAtStartup.Name = "cbRunAtStartup";
            this.cbRunAtStartup.Size = new System.Drawing.Size(115, 21);
            this.cbRunAtStartup.TabIndex = 2;
            this.cbRunAtStartup.Text = "run at startup";
            this.cbRunAtStartup.UseVisualStyleBackColor = true;
            this.cbRunAtStartup.CheckedChanged += new System.EventHandler(this.cbRunAtStartup_CheckedChanged);
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(621, 34);
            this.butBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(67, 25);
            this.butBrowse.TabIndex = 1;
            this.butBrowse.Text = "...";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(12, 34);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(596, 22);
            this.tbPath.TabIndex = 0;
            // 
            // autoRestoreTimer
            // 
            this.autoRestoreTimer.Tick += new System.EventHandler(this.autoRestoreTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Desktop maid";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayRestoreNow,
            this.eXITToolStripMenuItem});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.ShowImageMargin = false;
            this.trayContextMenu.Size = new System.Drawing.Size(161, 56);
            // 
            // trayRestoreNow
            // 
            this.trayRestoreNow.Name = "trayRestoreNow";
            this.trayRestoreNow.Size = new System.Drawing.Size(160, 26);
            this.trayRestoreNow.Text = "Restore desktop";
            this.trayRestoreNow.Click += new System.EventHandler(this.trayRestoreNow_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // DesktopMaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 431);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DesktopMaid";
            this.Text = "Desktop Maid";
            this.Shown += new System.EventHandler(this.DesktopMaid_Shown);
            this.Resize += new System.EventHandler(this.DesktopMaid_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabRestore.ResumeLayout(false);
            this.tabRestore.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRestore;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Button butPreserve;
        private System.Windows.Forms.Button butClean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.LinkLabel linkRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.CheckBox chbAutoRestore;
        private System.Windows.Forms.CheckBox cbRunAtStartup;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.ListView lbItems;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListView lVLog;
        private System.Windows.Forms.Timer autoRestoreTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox chbStartMinimalized;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem trayRestoreNow;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}

