namespace Sokoban
{
    partial class LabirintForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolPrevLevel = new System.Windows.Forms.ToolStripButton();
            this.toolNextLevel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLevelText = new System.Windows.Forms.ToolStripLabel();
            this.toolLevelNumber = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStatText = new System.Windows.Forms.ToolStripLabel();
            this.toolStat = new System.Windows.Forms.ToolStripLabel();
            this.toolFinish = new System.Windows.Forms.ToolStripLabel();
            this.toolRestart = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPrevLevel,
            this.toolNextLevel,
            this.toolStripSeparator3,
            this.toolLevelText,
            this.toolLevelNumber,
            this.toolStripSeparator1,
            this.toolStatText,
            this.toolStat,
            this.toolFinish,
            this.toolRestart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolPrevLevel
            // 
            this.toolPrevLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrevLevel.Image = global::Sokoban.Properties.Resources.prevMark;
            this.toolPrevLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrevLevel.Name = "toolPrevLevel";
            this.toolPrevLevel.Size = new System.Drawing.Size(23, 22);
            this.toolPrevLevel.Text = "На предыдущий";
            this.toolPrevLevel.Click += new System.EventHandler(this.toolPrevLevel_Click);
            // 
            // toolNextLevel
            // 
            this.toolNextLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNextLevel.Image = global::Sokoban.Properties.Resources.NextMark;
            this.toolNextLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNextLevel.Name = "toolNextLevel";
            this.toolNextLevel.Size = new System.Drawing.Size(23, 22);
            this.toolNextLevel.Text = "На следующий";
            this.toolNextLevel.Click += new System.EventHandler(this.toolNextLevel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolLevelText
            // 
            this.toolLevelText.Name = "toolLevelText";
            this.toolLevelText.Size = new System.Drawing.Size(69, 22);
            this.toolLevelText.Text = "Уровень №";
            // 
            // toolLevelNumber
            // 
            this.toolLevelNumber.Enabled = false;
            this.toolLevelNumber.Name = "toolLevelNumber";
            this.toolLevelNumber.Size = new System.Drawing.Size(15, 25);
            this.toolLevelNumber.Text = "1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStatText
            // 
            this.toolStatText.Name = "toolStatText";
            this.toolStatText.Size = new System.Drawing.Size(124, 22);
            this.toolStatText.Text = "Установлено ящиков";
            // 
            // toolStat
            // 
            this.toolStat.Name = "toolStat";
            this.toolStat.Size = new System.Drawing.Size(37, 22);
            this.toolStat.Text = "0 из 5";
            // 
            // toolFinish
            // 
            this.toolFinish.Name = "toolFinish";
            this.toolFinish.Size = new System.Drawing.Size(106, 22);
            this.toolFinish.Text = "Уровень пройден!";
            this.toolFinish.Visible = false;
            // 
            // toolRestart
            // 
            this.toolRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRestart.Image = global::Sokoban.Properties.Resources.adjustMark;
            this.toolRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRestart.Name = "toolRestart";
            this.toolRestart.Size = new System.Drawing.Size(23, 22);
            this.toolRestart.Text = "Начать заново";
            this.toolRestart.Click += new System.EventHandler(this.toolRestart_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(512, 465);
            this.panel.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LabirintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 490);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "LabirintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лабиринт";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LabirintForm_KeyDown);
            this.Resize += new System.EventHandler(this.LabirintForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolPrevLevel;
        private System.Windows.Forms.ToolStripButton toolNextLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolLevelText;
        private System.Windows.Forms.ToolStripTextBox toolLevelNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStatText;
        private System.Windows.Forms.ToolStripButton toolRestart;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripLabel toolStat;
        private System.Windows.Forms.ToolStripLabel toolFinish;
        private System.Windows.Forms.Timer timer;
    }
}