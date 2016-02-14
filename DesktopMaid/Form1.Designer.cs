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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.lbItems = new System.Windows.Forms.ListView();
            this.linkRefresh = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.butRemove = new System.Windows.Forms.Button();
            this.butPreserve = new System.Windows.Forms.Button();
            this.butClean = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.chbAutoRestore = new System.Windows.Forms.CheckBox();
            this.cbRunAtStartup = new System.Windows.Forms.CheckBox();
            this.butBrowse = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabRestore.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRestore);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRestore
            // 
            this.tabRestore.Controls.Add(this.lbItems);
            this.tabRestore.Controls.Add(this.linkRefresh);
            this.tabRestore.Controls.Add(this.label5);
            this.tabRestore.Controls.Add(this.Log);
            this.tabRestore.Controls.Add(this.lbLog);
            this.tabRestore.Controls.Add(this.butCancel);
            this.tabRestore.Controls.Add(this.progressBar1);
            this.tabRestore.Controls.Add(this.butRemove);
            this.tabRestore.Controls.Add(this.butPreserve);
            this.tabRestore.Controls.Add(this.butClean);
            this.tabRestore.Controls.Add(this.label2);
            this.tabRestore.Controls.Add(this.label1);
            this.tabRestore.Location = new System.Drawing.Point(4, 22);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestore.Size = new System.Drawing.Size(522, 323);
            this.tabRestore.TabIndex = 0;
            this.tabRestore.Text = "Restore desktop layout";
            this.tabRestore.UseVisualStyleBackColor = true;
            // 
            // lbItems
            // 
            this.lbItems.Location = new System.Drawing.Point(12, 22);
            this.lbItems.Name = "lbItems";
            this.lbItems.ShowItemToolTips = true;
            this.lbItems.Size = new System.Drawing.Size(242, 277);
            this.lbItems.TabIndex = 12;
            this.lbItems.UseCompatibleStateImageBehavior = false;
            this.lbItems.View = System.Windows.Forms.View.List;
            // 
            // linkRefresh
            // 
            this.linkRefresh.AutoSize = true;
            this.linkRefresh.Location = new System.Drawing.Point(196, 6);
            this.linkRefresh.Name = "linkRefresh";
            this.linkRefresh.Size = new System.Drawing.Size(58, 13);
            this.linkRefresh.TabIndex = 11;
            this.linkRefresh.TabStop = true;
            this.linkRefresh.Text = "REFRESH";
            this.linkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRefresh_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current items on desktop";
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(260, 135);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(25, 13);
            this.Log.TabIndex = 9;
            this.Log.Text = "Log";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(261, 149);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(253, 121);
            this.lbLog.TabIndex = 8;
            // 
            // butCancel
            // 
            this.butCancel.Enabled = false;
            this.butCancel.Location = new System.Drawing.Point(467, 276);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(47, 23);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(261, 276);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // butRemove
            // 
            this.butRemove.Location = new System.Drawing.Point(261, 109);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(253, 23);
            this.butRemove.TabIndex = 5;
            this.butRemove.Text = "Dont preserve selected items";
            this.butRemove.UseVisualStyleBackColor = true;
            this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
            // 
            // butPreserve
            // 
            this.butPreserve.Location = new System.Drawing.Point(261, 80);
            this.butPreserve.Name = "butPreserve";
            this.butPreserve.Size = new System.Drawing.Size(253, 23);
            this.butPreserve.TabIndex = 4;
            this.butPreserve.Text = "Preserve selected items";
            this.butPreserve.UseVisualStyleBackColor = true;
            this.butPreserve.Click += new System.EventHandler(this.butPreserve_Click);
            // 
            // butClean
            // 
            this.butClean.Location = new System.Drawing.Point(263, 22);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(253, 42);
            this.butClean.TabIndex = 3;
            this.butClean.Text = "Clean desktop";
            this.butClean.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(143, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unwanted files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(21, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Files to preserve";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.label4);
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Controls.Add(this.numInterval);
            this.tabSettings.Controls.Add(this.chbAutoRestore);
            this.tabSettings.Controls.Add(this.cbRunAtStartup);
            this.tabSettings.Controls.Add(this.butBrowse);
            this.tabSettings.Controls.Add(this.tbPath);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(522, 323);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "interval:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "minutes";
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(356, 90);
            this.numInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 20);
            this.numInterval.TabIndex = 4;
            // 
            // chbAutoRestore
            // 
            this.chbAutoRestore.AutoSize = true;
            this.chbAutoRestore.Location = new System.Drawing.Point(9, 91);
            this.chbAutoRestore.Name = "chbAutoRestore";
            this.chbAutoRestore.Size = new System.Drawing.Size(161, 17);
            this.chbAutoRestore.TabIndex = 3;
            this.chbAutoRestore.Text = "restore desktop automaticaly";
            this.chbAutoRestore.UseVisualStyleBackColor = true;
            // 
            // cbRunAtStartup
            // 
            this.cbRunAtStartup.AutoSize = true;
            this.cbRunAtStartup.Location = new System.Drawing.Point(9, 68);
            this.cbRunAtStartup.Name = "cbRunAtStartup";
            this.cbRunAtStartup.Size = new System.Drawing.Size(88, 17);
            this.cbRunAtStartup.TabIndex = 2;
            this.cbRunAtStartup.Text = "run at startup";
            this.cbRunAtStartup.UseVisualStyleBackColor = true;
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(466, 28);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(50, 20);
            this.butBrowse.TabIndex = 1;
            this.butBrowse.Text = "...";
            this.butBrowse.UseVisualStyleBackColor = true;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(9, 28);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(448, 20);
            this.tbPath.TabIndex = 0;
            // 
            // DesktopMaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DesktopMaid";
            this.Text = "Desktop Maid";
            this.Load += new System.EventHandler(this.DesktopMaid_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRestore.ResumeLayout(false);
            this.tabRestore.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRestore;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
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
    }
}

