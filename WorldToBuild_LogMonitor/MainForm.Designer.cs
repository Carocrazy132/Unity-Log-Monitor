namespace WorldToBuild_LogMonitor
{
    partial class MainForm
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
            this.consoleBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.fileCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshCheckBox = new System.Windows.Forms.CheckBox();
            this.moreInfoBox = new System.Windows.Forms.TextBox();
            this.scrollStayBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.consoleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleBox.FormattingEnabled = true;
            this.consoleBox.ItemHeight = 16;
            this.consoleBox.Location = new System.Drawing.Point(12, 12);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(776, 292);
            this.consoleBox.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleName = "";
            this.refreshButton.AutoSize = true;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(12, 438);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(103, 35);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // fileCheckTimer
            // 
            this.fileCheckTimer.Enabled = true;
            this.fileCheckTimer.Interval = 250;
            // 
            // refreshCheckBox
            // 
            this.refreshCheckBox.AutoSize = true;
            this.refreshCheckBox.Checked = true;
            this.refreshCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refreshCheckBox.FlatAppearance.BorderSize = 0;
            this.refreshCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshCheckBox.Location = new System.Drawing.Point(121, 447);
            this.refreshCheckBox.Name = "refreshCheckBox";
            this.refreshCheckBox.Size = new System.Drawing.Size(80, 17);
            this.refreshCheckBox.TabIndex = 2;
            this.refreshCheckBox.Text = "Auto-refresh";
            this.refreshCheckBox.UseVisualStyleBackColor = true;
            // 
            // moreInfoBox
            // 
            this.moreInfoBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.moreInfoBox.Location = new System.Drawing.Point(12, 305);
            this.moreInfoBox.Multiline = true;
            this.moreInfoBox.Name = "moreInfoBox";
            this.moreInfoBox.Size = new System.Drawing.Size(776, 127);
            this.moreInfoBox.TabIndex = 3;
            // 
            // scrollStayBox
            // 
            this.scrollStayBox.AutoSize = true;
            this.scrollStayBox.Checked = true;
            this.scrollStayBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrollStayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrollStayBox.Location = new System.Drawing.Point(207, 447);
            this.scrollStayBox.Name = "scrollStayBox";
            this.scrollStayBox.Size = new System.Drawing.Size(84, 17);
            this.scrollStayBox.TabIndex = 4;
            this.scrollStayBox.Text = "Anchor scroll";
            this.scrollStayBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AccessibleName = "refresh";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.scrollStayBox);
            this.Controls.Add(this.moreInfoBox);
            this.Controls.Add(this.refreshCheckBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.consoleBox);
            this.Name = "MainForm";
            this.Text = "WorldToBuild Log Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox consoleBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Timer fileCheckTimer;
        private System.Windows.Forms.CheckBox refreshCheckBox;
        private System.Windows.Forms.TextBox moreInfoBox;
        private System.Windows.Forms.CheckBox scrollStayBox;
    }
}

