namespace JobTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartWorkButton = new System.Windows.Forms.Button();
            this.timeWorkLabel = new System.Windows.Forms.Label();
            this.timerWork = new System.Windows.Forms.Timer(this.components);
            this.StartRestButton = new System.Windows.Forms.Button();
            this.timeRestLabel = new System.Windows.Forms.Label();
            this.timerRest = new System.Windows.Forms.Timer(this.components);
            this.DayResultWorkLabel = new System.Windows.Forms.Label();
            this.DayResultRestLabel = new System.Windows.Forms.Label();
            this.conButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeWorkRecordLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartWorkButton
            // 
            this.StartWorkButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartWorkButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartWorkButton.Location = new System.Drawing.Point(27, 68);
            this.StartWorkButton.Name = "StartWorkButton";
            this.StartWorkButton.Size = new System.Drawing.Size(138, 52);
            this.StartWorkButton.TabIndex = 0;
            this.StartWorkButton.Text = "Работа";
            this.StartWorkButton.UseVisualStyleBackColor = false;
            this.StartWorkButton.Click += new System.EventHandler(this.StartWorkButton_Click);
            // 
            // timeWorkLabel
            // 
            this.timeWorkLabel.AutoSize = true;
            this.timeWorkLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeWorkLabel.Location = new System.Drawing.Point(61, 23);
            this.timeWorkLabel.Name = "timeWorkLabel";
            this.timeWorkLabel.Size = new System.Drawing.Size(71, 32);
            this.timeWorkLabel.TabIndex = 1;
            this.timeWorkLabel.Text = "00:00";
            // 
            // timerWork
            // 
            this.timerWork.Interval = 1000;
            this.timerWork.Tick += new System.EventHandler(this.timerWork_Tick);
            // 
            // StartRestButton
            // 
            this.StartRestButton.BackColor = System.Drawing.Color.PaleGreen;
            this.StartRestButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartRestButton.Location = new System.Drawing.Point(182, 68);
            this.StartRestButton.Name = "StartRestButton";
            this.StartRestButton.Size = new System.Drawing.Size(138, 52);
            this.StartRestButton.TabIndex = 3;
            this.StartRestButton.Text = "Отдых";
            this.StartRestButton.UseVisualStyleBackColor = false;
            this.StartRestButton.Click += new System.EventHandler(this.StartRestButton_Click);
            // 
            // timeRestLabel
            // 
            this.timeRestLabel.AutoSize = true;
            this.timeRestLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeRestLabel.Location = new System.Drawing.Point(214, 23);
            this.timeRestLabel.Name = "timeRestLabel";
            this.timeRestLabel.Size = new System.Drawing.Size(71, 32);
            this.timeRestLabel.TabIndex = 4;
            this.timeRestLabel.Text = "00:00";
            // 
            // timerRest
            // 
            this.timerRest.Interval = 1000;
            this.timerRest.Tick += new System.EventHandler(this.timerRest_Tick);
            // 
            // DayResultWorkLabel
            // 
            this.DayResultWorkLabel.AutoSize = true;
            this.DayResultWorkLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DayResultWorkLabel.Location = new System.Drawing.Point(47, 141);
            this.DayResultWorkLabel.Name = "DayResultWorkLabel";
            this.DayResultWorkLabel.Size = new System.Drawing.Size(102, 32);
            this.DayResultWorkLabel.TabIndex = 5;
            this.DayResultWorkLabel.Text = "00:00:00";
            // 
            // DayResultRestLabel
            // 
            this.DayResultRestLabel.AutoSize = true;
            this.DayResultRestLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DayResultRestLabel.Location = new System.Drawing.Point(203, 141);
            this.DayResultRestLabel.Name = "DayResultRestLabel";
            this.DayResultRestLabel.Size = new System.Drawing.Size(102, 32);
            this.DayResultRestLabel.TabIndex = 6;
            this.DayResultRestLabel.Text = "00:00:00";
            // 
            // conButton
            // 
            this.conButton.Location = new System.Drawing.Point(12, 27);
            this.conButton.Name = "conButton";
            this.conButton.Size = new System.Drawing.Size(43, 35);
            this.conButton.TabIndex = 7;
            this.conButton.Text = "Con";
            this.conButton.UseVisualStyleBackColor = true;
            this.conButton.Click += new System.EventHandler(this.ConButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // timeWorkRecordLabel
            // 
            this.timeWorkRecordLabel.AutoSize = true;
            this.timeWorkRecordLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.timeWorkRecordLabel.Location = new System.Drawing.Point(127, 37);
            this.timeWorkRecordLabel.Name = "timeWorkRecordLabel";
            this.timeWorkRecordLabel.Size = new System.Drawing.Size(34, 15);
            this.timeWorkRecordLabel.TabIndex = 9;
            this.timeWorkRecordLabel.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 191);
            this.Controls.Add(this.timeWorkRecordLabel);
            this.Controls.Add(this.conButton);
            this.Controls.Add(this.DayResultRestLabel);
            this.Controls.Add(this.DayResultWorkLabel);
            this.Controls.Add(this.timeRestLabel);
            this.Controls.Add(this.StartRestButton);
            this.Controls.Add(this.timeWorkLabel);
            this.Controls.Add(this.StartWorkButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobTimer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartWorkButton;
        private Label timeWorkLabel;
        private System.Windows.Forms.Timer timerWork;
        private Button StartRestButton;
        private Label timeRestLabel;
        private System.Windows.Forms.Timer timerRest;
        private Button conButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem historyToolStripMenuItem;
        private Label timeWorkRecordLabel;
        private Label DayResultWorkLabel;
        private Label DayResultRestLabel;
    }
}