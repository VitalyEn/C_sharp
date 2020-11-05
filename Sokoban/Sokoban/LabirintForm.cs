using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public partial class LabirintForm : Form
    {
        int level_nr;
        int last_level_nr;
      
        int width, height;
        PictureBox[,] box;
        Game game;

        public LabirintForm()
        {
            InitializeComponent();
            last_level_nr = 1;
            game = new Game(ShowItem, ShowStat);
        }

        public void OpenLevel(int level_nr)
        {
            if (level_nr > last_level_nr)
                return;
           

            this.level_nr = level_nr;

            if(!game.Init(level_nr, out width, out height))
            {
                MessageBox.Show("Поздравляю!!!!!");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                return;
            }
           
            InitPictures();
            game.ShowLevel();
           
        }

        public void InitPictures()
        {
            box = new PictureBox[width, height];
            int bw, bh;
            bw = panel.Width / width;
            bh = panel.Height / height;
            if (bw < bh)
                bh = bw;
            else
                bw = bh;
            panel.Controls.Clear();
            box = new PictureBox[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.BackColor = System.Drawing.Color.White;
                    picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    picture.Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));
                    picture.Size = new System.Drawing.Size(bw, bh);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
                    picture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
                    picture.Tag = new Place(x, y);
                    panel.Controls.Add(picture);
                    box[x, y] = picture;

                }
        }
        public void ShowItem(Place place, Cell item)
        {
            box[place.x, place.y].Image = CellToPicture(item);
        }

        public void ShowStat(int placed, int totals)
        {
            toolStat.Text = placed.ToString() + " из " + totals.ToString();
            toolLevelNumber.Text = level_nr.ToString();
            toolFinish.Visible = placed == totals;
            if (placed == totals)
            {
               if (level_nr == last_level_nr)
                  last_level_nr = level_nr + 1;
            }

        }

        private void toolPrevLevel_Click(object sender, EventArgs e)
        {
            if (level_nr > 1)
                OpenLevel(level_nr - 1);
        }

        private void toolNextLevel_Click(object sender, EventArgs e)
        {
            OpenLevel(level_nr + 1);
        }

       

        private Image CellToPicture(Cell c)
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

        private void LabirintForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (path != "")
            {
                path = "";
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.Left: game.Step(-1, 0); break;
                case Keys.Right: game.Step(1, 0); break;
                case Keys.Down: game.Step(0, 1); break;
                case Keys.Up: game.Step(0, -1); break;
                case Keys.Escape: RestartLevel(); break;
            }
        }

        private void toolRestart_Click(object sender, EventArgs e)
        {
            RestartLevel();
        }

        private void LabirintForm_Resize(object sender, EventArgs e)
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
                   
                   box[x,y].Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));
                   box[x,y].Size = new System.Drawing.Size(bw, bh);
                   
                  
                   

                }
        }

        private void RestartLevel()
        {
            game.Init(level_nr, out width, out height);
                  
            game.ShowLevel();
        }


        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Place place = (Place)((PictureBox)sender).Tag;
            string my_path = "";
            if (apple.x == -1)
            {
                my_path = game.SolveMouse(place);
            }else
            {
                my_path = game.SolveApple(apple, place);
                apple.x = -1;
                apple.y = -1;
            }
            
            path = my_path;
        }

        Place apple = new Place(-1, -1);

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            apple = (Place)((PictureBox)sender).Tag;
        }

        string path = "";

        private void timer_Tick(object sender, EventArgs e)
        {
            if (path == "")
                return;
            switch (path[0])
            {
                case '4': game.Step(-1, 0); break;
                case '6': game.Step(1, 0); break;
                case '2': game.Step(0, 1); break;
                case '8': game.Step(0, -1); break;
            }
            path = path.Substring(1);
        }
    }  
}
