using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokobanEditor
{
    public enum Cell
    {
        none,
        wall,
        abox,
        done,
        here,
        user
    };
    
    public partial class SokobanEditor : Form
    {
        PictureBox[,] box;
        Cell[,] cell;
        int width, height;
        Cell currentCell = Cell.none;
        LevelFile Level;
        int CurrentLevel;

        static int MinWidth = 5;
        static int MaxWidth = 40;
        static int MinHeight = 5;
        static int MaxHeight = 40;

        public SokobanEditor()
        {
            InitializeComponent();
        }

        private void SokobanEditor_Load(object sender, EventArgs e)
        {
           // cell[,] cell;
            Level = new LevelFile("Levels.txt");
            CurrentLevel = 1;
            LoadLevel();
        }
         public void CalcStat()
        {
            int boxes = 0;
            int heres = 0;
            for(int x=0; x<width; x++)
                for(int y = 0; y<height; y++)
                {
                    if (cell[x, y] == Cell.abox)
                        boxes++;
                    if (cell[x, y] == Cell.here)
                        heres++;
                }

            statBox.Text = boxes.ToString() + "x";
            statPlace.Text = heres.ToString() + "x";
        }
        public void InitPictures ()
        {
            int bw, bh;
            bw = panel.Width / width;
            bh = panel.Height / height;
            if (bw < bh)
                bh = bw;
            else
                bw = bh;

            box = new PictureBox[width, height];
            for (int x = 0; x < width; x ++)
                for (int y = 0; y < height; y ++)
                {
                    PictureBox picture = new PictureBox();
                    picture.BackColor = System.Drawing.Color.White;
                    picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    picture.Location = new System.Drawing.Point(x*(bw-1), y*(bh-1));
                    picture.Size = new System.Drawing.Size(bw, bh);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
                    picture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
                    picture.Tag = new Point(x, y);
                    panel.Controls.Add(picture);
                    box[x, y] = picture;
                    
                }
        }
        public void LoadPictures()
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                   box[x, y].Image = CellToPicture(cell[x, y]);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x, y;
            x = ((Point)((PictureBox)sender).Tag).X;
            y = ((Point)((PictureBox)sender).Tag).Y;
            Cell curr = Cell.none;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                curr = currentCell;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                curr = Cell.none;
            }
            if (last_mouse_x==-1)
            {
                ShowCell(x, y, curr);
            }
            else
            {
                ShowRectCell(x, y, curr);
                last_mouse_x = -1;
                last_mouse_y = -1;
            }
        }

        int last_mouse_x = -1;
        int last_mouse_y = -1;

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            last_mouse_x = ((Point)((PictureBox)sender).Tag).X;
            last_mouse_y = ((Point)((PictureBox)sender).Tag).Y;
        }

        private void ShowRectCell(int x,int y, Cell curr)
        {
            int x1, x2;
            int y1, y2;
            x1 = Math.Min(x, last_mouse_x);
            x2 = Math.Max(x, last_mouse_x);
            y1 = Math.Min(y, last_mouse_y);
            y2 = Math.Max(y, last_mouse_y);
            for (int xx = x1; xx <= x2; xx++)
                for (int yy = y1; yy <= y2; yy++)
                    ShowCell(xx, yy, curr);
        }
        private void ShowCell(int x, int y, Cell c)
        {
            if (c==Cell.user)
            {
                for (int xx = 0; xx < width; xx++)
                    for (int yy = 0; yy < height; yy++)
                        if (cell[xx, yy] == Cell.user)
                            ShowCell(xx, yy, Cell.none);
            }
            cell[x, y] = c;
            box[x, y].Image = CellToPicture(c);
            CalcStat();
        }

        private Image CellToPicture (Cell c)
        {
            switch (c)
            {
                case Cell.none: return Properties.Resources.none_Mark;
                case Cell.wall: return Properties.Resources.wallMark1;
                case Cell.abox: return Properties.Resources.bee_abox;
                case Cell.here: return Properties.Resources.placeMark;
                case Cell.done: return Properties.Resources.doneMark;
                case Cell.user: return Properties.Resources.PlayerMark;
                default: return Properties.Resources.none_Mark;
            }
        }

        private void SetCurrentCell(Cell SelectedCell)
        {
            currentCell = SelectedCell;
            toolWall.Checked = currentCell == Cell.wall;
            toolAbox.Checked = currentCell == Cell.abox;
            toolHere.Checked = currentCell == Cell.here;
            toolDone.Checked = currentCell == Cell.done;
            toolNone.Checked = currentCell == Cell.none;
            toolUser.Checked = currentCell == Cell.user;
        }

        private void toolWall_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.wall);
        }

        private void toolAbox_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.abox);
        }

        private void toolHere_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.here);
        }

        private void toolDone_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.done);
        }

        private void toolNone_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.none);
        }

        private void toolUser_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.user);
        }

      
        private void ResizeLevel(int w,int h)
        {
            if (w < MinWidth) return;
            if (w > MaxWidth) return;
            if (h < MinHeight) return;
            if (h > MaxHeight) return;
            Cell [,] NewCell = new Cell[w, h];
            for (int x = 0; x < Math.Min(w, width); x++)
                for (int y = 0; y < Math.Min(h, height); y++)
                    NewCell[x, y] = cell[x, y];
            width = w;
            height = h;
            cell = null;
            panel.Controls.Clear();
            cell = NewCell;
            InitPictures();
            LoadPictures();
        }

        private void SokobanEditor_Resize(object sender, EventArgs e)
        {

            int bw, bh;
            bw = panel.Width / width;
            bh = panel.Height / height;
            if (bw < bh)
                bh = bw;
            else
                bw = bh;


            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    box[x, y].Size = new System.Drawing.Size(bw, bh);
                    box[x, y].Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));

                }

        }
        private string IsGoodLevel ()
        {
            int users = CountItems(Cell.user);
            if (users == 0)
                return "Нужно указать начальное место для игрока";
            if (users > 1)
                return "Нужно указать только одного игрока";
            int aboxes = CountItems(Cell.abox);
            int heres = CountItems(Cell.here);
            if (aboxes == 0)
                return "Нужно поставить хотя бы один ящик";
            if (aboxes != heres)
                return "Количество ящиков должно соответствовать количеству мест";
            return "";
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            SaveLevel();
        }
            private void SaveLevel()
        {
            string error = IsGoodLevel();
            if (error!="")
            {
                MessageBox.Show(error, "Ошибка!");
                return;
            }
            Level.SaveLevel(CurrentLevel, cell);
        }

        private void toolPrev_Click(object sender, EventArgs e)
        {
            if(CurrentLevel>1)
            {
                SaveLevel();
                CurrentLevel--;
                LoadLevel();
            }
        }
        private void LoadLevel()
        {
            cell = Level.LoadLevel(CurrentLevel);
            width = cell.GetLength(0);
            height = cell.GetLength(1);
            toolStripTextBoxResize.Text = width.ToString() + "x" + height.ToString();
            panel.Controls.Clear();
            InitPictures();
            LoadPictures();
        }

        private void toolNext_Click(object sender, EventArgs e)
        {
            SaveLevel();
            CurrentLevel++;
            LoadLevel();
        }

        private void toolStripTextBoxResize_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSetSize_Click(object sender, EventArgs e)
        {
            string[] dl = { "x" };
            string[] wh = toolStripTextBoxResize.Text.Split(dl,
                StringSplitOptions.RemoveEmptyEntries);
            int w = int.Parse(wh[0]);
            int h = int.Parse(wh[1]);
            ResizeLevel(w, h);
        }

        private void toolStripTextBoxResize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                toolStripButtonSetSize_Click(sender, null);
               
        }

       

        private int CountItems (Cell item)
        {
            int count = 0;
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    if (cell[x, y] == item)
                       count++;
            return count;
        }
    }
}
