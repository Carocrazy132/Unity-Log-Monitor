namespace UnityLogMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refreshButton = new System.Windows.Forms.Button();
            this.fileCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshCheckBox = new System.Windows.Forms.CheckBox();
            this.moreInfoBox = new System.Windows.Forms.TextBox();
            this.consoleBoxDGV = new System.Windows.Forms.DataGridView();
            this.occuranceCountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.scrollStayBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.alwaysOnTopCheckbox = new System.Windows.Forms.CheckBox();
            this.clearConsoleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consoleBoxDGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleName = "";
            this.refreshButton.AutoSize = true;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.refreshButton.Location = new System.Drawing.Point(3, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(122, 34);
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
            this.refreshCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshCheckBox.FlatAppearance.BorderSize = 0;
            this.refreshCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshCheckBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.refreshCheckBox.Location = new System.Drawing.Point(131, 3);
            this.refreshCheckBox.Name = "refreshCheckBox";
            this.refreshCheckBox.Size = new System.Drawing.Size(80, 34);
            this.refreshCheckBox.TabIndex = 2;
            this.refreshCheckBox.Text = "Auto-refresh";
            this.refreshCheckBox.UseVisualStyleBackColor = true;
            // 
            // moreInfoBox
            // 
            this.moreInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.moreInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moreInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moreInfoBox.Location = new System.Drawing.Point(3, 320);
            this.moreInfoBox.Multiline = true;
            this.moreInfoBox.Name = "moreInfoBox";
            this.moreInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.moreInfoBox.Size = new System.Drawing.Size(794, 109);
            this.moreInfoBox.TabIndex = 3;
            // 
            // consoleBoxDGV
            // 
            this.consoleBoxDGV.AllowUserToAddRows = false;
            this.consoleBoxDGV.AllowUserToDeleteRows = false;
            this.consoleBoxDGV.AllowUserToResizeColumns = false;
            this.consoleBoxDGV.AllowUserToResizeRows = false;
            this.consoleBoxDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.consoleBoxDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleBoxDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.consoleBoxDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.consoleBoxDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consoleBoxDGV.ColumnHeadersVisible = false;
            this.consoleBoxDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iconCol,
            this.outputCol,
            this.occuranceCountCol});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consoleBoxDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.consoleBoxDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleBoxDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.consoleBoxDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.consoleBoxDGV.Location = new System.Drawing.Point(3, 3);
            this.consoleBoxDGV.MultiSelect = false;
            this.consoleBoxDGV.Name = "consoleBoxDGV";
            this.consoleBoxDGV.ReadOnly = true;
            this.consoleBoxDGV.RowHeadersVisible = false;
            this.consoleBoxDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            this.consoleBoxDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.consoleBoxDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.consoleBoxDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBoxDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consoleBoxDGV.ShowCellErrors = false;
            this.consoleBoxDGV.ShowEditingIcon = false;
            this.consoleBoxDGV.ShowRowErrors = false;
            this.consoleBoxDGV.Size = new System.Drawing.Size(794, 311);
            this.consoleBoxDGV.TabIndex = 6;
            // 
            // occuranceCountCol
            // 
            this.occuranceCountCol.HeaderText = "#";
            this.occuranceCountCol.Name = "occuranceCountCol";
            this.occuranceCountCol.ReadOnly = true;
            this.occuranceCountCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.occuranceCountCol.Width = 40;
            // 
            // outputCol
            // 
            this.outputCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.outputCol.HeaderText = "Output:";
            this.outputCol.Name = "outputCol";
            this.outputCol.ReadOnly = true;
            this.outputCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // iconCol
            // 
            this.iconCol.Frozen = true;
            this.iconCol.HeaderText = "";
            this.iconCol.Name = "iconCol";
            this.iconCol.ReadOnly = true;
            this.iconCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iconCol.Width = 32;
            // 
            // scrollStayBox
            // 
            this.scrollStayBox.AutoSize = true;
            this.scrollStayBox.Checked = true;
            this.scrollStayBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrollStayBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.scrollStayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrollStayBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.scrollStayBox.Location = new System.Drawing.Point(227, 3);
            this.scrollStayBox.Name = "scrollStayBox";
            this.scrollStayBox.Size = new System.Drawing.Size(84, 34);
            this.scrollStayBox.TabIndex = 4;
            this.scrollStayBox.Text = "Anchor scroll";
            this.scrollStayBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.consoleBoxDGV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.moreInfoBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 478);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.Controls.Add(this.refreshCheckBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.scrollStayBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.refreshButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.alwaysOnTopCheckbox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.clearConsoleButton, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 435);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 40);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // alwaysOnTopCheckbox
            // 
            this.alwaysOnTopCheckbox.AutoSize = true;
            this.alwaysOnTopCheckbox.Checked = true;
            this.alwaysOnTopCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.alwaysOnTopCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alwaysOnTopCheckbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.alwaysOnTopCheckbox.Location = new System.Drawing.Point(323, 3);
            this.alwaysOnTopCheckbox.Name = "alwaysOnTopCheckbox";
            this.alwaysOnTopCheckbox.Size = new System.Drawing.Size(89, 34);
            this.alwaysOnTopCheckbox.TabIndex = 5;
            this.alwaysOnTopCheckbox.Text = "Always on top";
            this.alwaysOnTopCheckbox.UseVisualStyleBackColor = true;
            this.alwaysOnTopCheckbox.CheckedChanged += new System.EventHandler(this.alwaysOnTopCheckbox_CheckedChanged);
            // 
            // clearConsoleButton
            // 
            this.clearConsoleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearConsoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearConsoleButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.clearConsoleButton.Location = new System.Drawing.Point(669, 3);
            this.clearConsoleButton.Name = "clearConsoleButton";
            this.clearConsoleButton.Size = new System.Drawing.Size(122, 34);
            this.clearConsoleButton.TabIndex = 6;
            this.clearConsoleButton.Text = "Clear";
            this.clearConsoleButton.UseVisualStyleBackColor = true;
            this.clearConsoleButton.Click += new System.EventHandler(this.clearConsoleButton_Click);
            // 
            // MainForm
            // 
            this.AccessibleName = "refresh";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "WorldToBuild Log Monitor";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.consoleBoxDGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Timer fileCheckTimer;
        private System.Windows.Forms.CheckBox refreshCheckBox;
        private System.Windows.Forms.TextBox moreInfoBox;
        private System.Windows.Forms.DataGridView consoleBoxDGV;
        private System.Windows.Forms.DataGridViewImageColumn iconCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn occuranceCountCol;
        private System.Windows.Forms.CheckBox scrollStayBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox alwaysOnTopCheckbox;
        private System.Windows.Forms.Button clearConsoleButton;
    }
}

