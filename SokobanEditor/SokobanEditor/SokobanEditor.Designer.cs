namespace SokobanEditor
{
    partial class SokobanEditor
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolWall = new System.Windows.Forms.ToolStripButton();
            this.statBox = new System.Windows.Forms.ToolStripLabel();
            this.toolAbox = new System.Windows.Forms.ToolStripButton();
            this.statPlace = new System.Windows.Forms.ToolStripLabel();
            this.toolHere = new System.Windows.Forms.ToolStripButton();
            this.toolDone = new System.Windows.Forms.ToolStripButton();
            this.toolNone = new System.Windows.Forms.ToolStripButton();
            this.toolUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolPrev = new System.Windows.Forms.ToolStripButton();
            this.toolNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxResize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSetSize = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWall,
            this.statBox,
            this.toolAbox,
            this.statPlace,
            this.toolHere,
            this.toolDone,
            this.toolNone,
            this.toolUser,
            this.toolStripSeparator1,
            this.toolSave,
            this.toolPrev,
            this.toolNext,
            this.toolStripLabel1,
            this.toolStripTextBoxResize,
            this.toolStripButtonSetSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(637, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolWall
            // 
            this.toolWall.BackgroundImage = global::SokobanEditor.Properties.Resources.wallMark1;
            this.toolWall.Checked = true;
            this.toolWall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolWall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolWall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolWall.Name = "toolWall";
            this.toolWall.Size = new System.Drawing.Size(23, 34);
            this.toolWall.Text = "Стена";
            this.toolWall.Click += new System.EventHandler(this.toolWall_Click);
            // 
            // statBox
            // 
            this.statBox.Name = "statBox";
            this.statBox.Size = new System.Drawing.Size(18, 34);
            this.statBox.Text = "0x";
            // 
            // toolAbox
            // 
            this.toolAbox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbox.Image = global::SokobanEditor.Properties.Resources.bee_abox;
            this.toolAbox.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAbox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbox.Name = "toolAbox";
            this.toolAbox.Size = new System.Drawing.Size(34, 34);
            this.toolAbox.Text = "Ящик";
            this.toolAbox.Click += new System.EventHandler(this.toolAbox_Click);
            // 
            // statPlace
            // 
            this.statPlace.Name = "statPlace";
            this.statPlace.Size = new System.Drawing.Size(18, 34);
            this.statPlace.Text = "0x";
            // 
            // toolHere
            // 
            this.toolHere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHere.Image = global::SokobanEditor.Properties.Resources.placeMark;
            this.toolHere.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolHere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHere.Name = "toolHere";
            this.toolHere.Size = new System.Drawing.Size(34, 34);
            this.toolHere.Text = "Место для ящика";
            this.toolHere.Click += new System.EventHandler(this.toolHere_Click);
            // 
            // toolDone
            // 
            this.toolDone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDone.Image = global::SokobanEditor.Properties.Resources.doneMark;
            this.toolDone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(34, 34);
            this.toolDone.Text = "toolDone";
            this.toolDone.Click += new System.EventHandler(this.toolDone_Click);
            // 
            // toolNone
            // 
            this.toolNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNone.Image = global::SokobanEditor.Properties.Resources.none_Mark;
            this.toolNone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNone.Name = "toolNone";
            this.toolNone.Size = new System.Drawing.Size(34, 34);
            this.toolNone.Text = "toolNone";
            this.toolNone.Click += new System.EventHandler(this.toolNone_Click);
            // 
            // toolUser
            // 
            this.toolUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUser.Image = global::SokobanEditor.Properties.Resources.PlayerMark;
            this.toolUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser.Name = "toolUser";
            this.toolUser.Size = new System.Drawing.Size(34, 34);
            this.toolUser.Text = "toolUser";
            this.toolUser.Click += new System.EventHandler(this.toolUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = global::SokobanEditor.Properties.Resources.OkMark;
            this.toolSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(34, 34);
            this.toolSave.Text = "toolSave";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolPrev
            // 
            this.toolPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrev.Image = global::SokobanEditor.Properties.Resources.prevMark;
            this.toolPrev.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrev.Name = "toolPrev";
            this.toolPrev.Size = new System.Drawing.Size(34, 34);
            this.toolPrev.Text = "toolStripButton1";
            this.toolPrev.Click += new System.EventHandler(this.toolPrev_Click);
            // 
            // toolNext
            // 
            this.toolNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNext.Image = global::SokobanEditor.Properties.Resources.NextMark;
            this.toolNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNext.Name = "toolNext";
            this.toolNext.Size = new System.Drawing.Size(34, 34);
            this.toolNext.Text = "toolStripButton2";
            this.toolNext.Click += new System.EventHandler(this.toolNext_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 34);
            this.toolStripLabel1.Text = "Размер:";
            // 
            // toolStripTextBoxResize
            // 
            this.toolStripTextBoxResize.Name = "toolStripTextBoxResize";
            this.toolStripTextBoxResize.Size = new System.Drawing.Size(100, 37);
            this.toolStripTextBoxResize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxResize_KeyDown);
            this.toolStripTextBoxResize.Click += new System.EventHandler(this.toolStripTextBoxResize_Click);
            // 
            // toolStripButtonSetSize
            // 
            this.toolStripButtonSetSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSetSize.Image = global::SokobanEditor.Properties.Resources.adjustMark;
            this.toolStripButtonSetSize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSetSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetSize.Name = "toolStripButtonSetSize";
            this.toolStripButtonSetSize.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonSetSize.Text = "Установить размер";
            this.toolStripButtonSetSize.Click += new System.EventHandler(this.toolStripButtonSetSize_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 37);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(637, 395);
            this.panel.TabIndex = 1;
            this.panel.Resize += new System.EventHandler(this.SokobanEditor_Resize);
            // 
            // SokobanEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(637, 432);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SokobanEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "редактор уровней  Сокобан";
            this.Load += new System.EventHandler(this.SokobanEditor_Load);
            this.Resize += new System.EventHandler(this.SokobanEditor_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolWall;
        private System.Windows.Forms.ToolStripButton toolAbox;
        private System.Windows.Forms.ToolStripButton toolHere;
        private System.Windows.Forms.ToolStripButton toolDone;
        private System.Windows.Forms.ToolStripButton toolNone;
        private System.Windows.Forms.ToolStripButton toolUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolPrev;
        private System.Windows.Forms.ToolStripButton toolNext;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxResize;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetSize;
        private System.Windows.Forms.ToolStripLabel statBox;
        private System.Windows.Forms.ToolStripLabel statPlace;
    }
}

