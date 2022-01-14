using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform;
using Tao.FreeGlut;
using System.Net.NetworkInformation;

namespace GAME2048
{
    public partial class Form2 : Form
    {

        public int[,] map = new int[4, 4];
        public Label[,] labels = new Label[4, 4];
        public PictureBox[,] pics = new PictureBox[4, 4];
        public int score = 0;
        public int WinScore = 0;

        public Form2()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnKeyboardPressed);
            map[0, 0] = 1;
            map[0, 1] = 1;
            Map();
            Pics();
            NewPic();
        }

        public void SwapDataf4()
        {
            Form4 f4 = new Form4();
            f4.LastScoreWin = WinScore;
            f4.Show();
            this.Hide();
        }

        public void SwapDataf3()
        {
            Form3 f3 = new Form3();
            f3.LostScore = score;
            f3.Show();
            this.Hide();
        }



        public void Map() 
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(12 + 56 * j, 73 + 56 * i); 
                    pic.Size = new Size(50, 50); 
                    pic.BackColor = Color.Gray; 
                    this.Controls.Add(pic);
                }
            }
        }

        public void Pics() 
        {
            pics[0, 0] = new PictureBox();
            labels[0, 0] = new Label();
            labels[0, 0].Text = "2";
            labels[0, 0].Size = new Size(50, 50);
            labels[0, 0].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 0].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pics[0, 0].Controls.Add(labels[0, 0]);
            pics[0, 0].Location = new Point(12, 73);
            pics[0, 0].Size = new Size(50, 50);
            pics[0, 0].BackColor = Color.Gainsboro;
            this.Controls.Add(pics[0, 0]);
            pics[0, 0].BringToFront();

            pics[0, 1] = new PictureBox();
            labels[0, 1] = new Label();
            labels[0, 1].Text = "2";
            labels[0, 1].Size = new Size(50, 50);
            labels[0, 1].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 1].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pics[0, 1].Controls.Add(labels[0, 1]);
            pics[0, 1].Location = new Point(68, 73);
            pics[0, 1].Size = new Size(50, 50);
            pics[0, 1].BackColor = Color.Gainsboro;
            this.Controls.Add(pics[0, 1]);
            pics[0, 1].BringToFront();
        }

        public void NewPic() 
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 4);
            int b = rnd.Next(0, 4);
            while (pics[a, b] != null)
            {
                a = rnd.Next(0, 4);
                b = rnd.Next(0, 4);
            }
            map[a, b] = 1;
            pics[a, b] = new PictureBox();
            labels[a, b] = new Label();
            labels[a, b].Text = "2";
            labels[a, b].Size = new Size(50, 50);
            labels[a, b].TextAlign = ContentAlignment.MiddleCenter;
            labels[a, b].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pics[a, b].Controls.Add(labels[a, b]);
            pics[a, b].Location = new Point(12 + b * 56, 73 + 56 * a);
            pics[a, b].Size = new Size(50, 50);
            pics[a, b].BackColor = Color.Gainsboro;
            this.Controls.Add(pics[a, b]);
            pics[a, b].BringToFront();
        }

        public void OnKeyboardPressed(object sender, KeyEventArgs e) 
        {
            if (LoseGame())
            {
                return;
            }
            bool ifPicWasMoved = false;

            switch (e.KeyCode.ToString())
            {
                case "Right":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 2; l >= 0; l--)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l + 1; j < 4; j++)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j - 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j - 1];
                                        pics[k, j - 1] = null;
                                        labels[k, j] = labels[k, j - 1];
                                        labels[k, j - 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X + 56, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j - 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, k, j);
                                            label1.Text = "РАХУНОК: " + score;
                                            map[k, j - 1] = 0;
                                            this.Controls.Remove(pics[k, j - 1]);
                                            this.Controls.Remove(labels[k, j - 1]);
                                            pics[k, j - 1] = null;
                                            labels[k, j - 1] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Left":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 1; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l - 1; j >= 0; j--)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j + 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j + 1];
                                        pics[k, j + 1] = null;
                                        labels[k, j] = labels[k, j + 1];
                                        labels[k, j + 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X - 56, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j + 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, k, j);
                                            label1.Text = "РАХУНОК: " + score;
                                            map[k, j + 1] = 0;
                                            this.Controls.Remove(pics[k, j + 1]);
                                            this.Controls.Remove(labels[k, j + 1]);
                                            pics[k, j + 1] = null;
                                            labels[k, j + 1] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Down":
                    for (int k = 2; k >= 0; k--)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k + 1; j < 4; j++)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j - 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j - 1, l];
                                        pics[j - 1, l] = null;
                                        labels[j, l] = labels[j - 1, l];
                                        labels[j - 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y + 56);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j - 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, j, l);
                                            label1.Text = "РАХУНОК: " + score;
                                            map[j - 1, l] = 0;
                                            this.Controls.Remove(pics[j - 1, l]);
                                            this.Controls.Remove(labels[j - 1, l]);
                                            pics[j - 1, l] = null;
                                            labels[j - 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Up": 
                    for (int k = 1; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k - 1; j >= 0; j--)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j + 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j + 1, l];
                                        pics[j + 1, l] = null;
                                        labels[j, l] = labels[j + 1, l];
                                        labels[j + 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y - 56);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j + 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, j, l);
                                            label1.Text = "РАХУНОК: " + score;
                                            map[j + 1, l] = 0;
                                            this.Controls.Remove(pics[j + 1, l]);
                                            this.Controls.Remove(labels[j + 1, l]);
                                            pics[j + 1, l] = null;
                                            labels[j + 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
            if (ifPicWasMoved)
                NewPic(); 
        }

        public void ChangeColor(int sum, int k, int j)
        {
            if (sum % 4096 == 0)
            {
                pics[k, j].BackColor = Color.Blue;
                WinScore= WinScore+10;
                MessageBox.Show("Вітаю, ти виграв cупер гру та отримав на свій рахунок 10-ть перемог!", "You are Winner!");
                SwapDataf3();
                SwapDataf4();
                this.Close();
            }
            else 
                if (sum % 2048 == 0)
            {
                pics[k, j].BackColor = Color.Lime;
                WinScore++;
                DialogResult result = MessageBox.Show("Вітаю, ти виграв!\n\nПропоную тобі супер гру, якщо ти досягнеш результату «4096» в одній клітинці, то це буде рівносильно 10-ьом перемогам, але в разі поразки - твоя теперішня перемога анулюється!\n\nЯкщо приймаєш правила - тисни «‎Так»!\n\nЯкщо ж ти хочеш вийти та зберегти свій результат, просто натисни «‎Ні»!", "You are Winner!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.No)
                {
                    SwapDataf3();
                    SwapDataf4();
                    this.Close();
                }
            }
            else
                if (sum % 1024 == 0)
            {
                pics[k, j].BackColor = Color.Gold;
            }
            else
                if (sum % 512 == 0)
            {
                pics[k, j].BackColor = Color.Yellow;
            }
            else
                if (sum % 256 == 0)
            {
                pics[k, j].BackColor = Color.LemonChiffon;
            }
            else
                if (sum % 128 == 0)
            {
                pics[k, j].BackColor = Color.LightYellow;
            }
            else
                if (sum % 64 == 0)
            {
                pics[k, j].BackColor = Color.Red;
            }
            else
            if (sum % 32 == 0)
            {
                pics[k, j].BackColor = Color.Tomato;
            }
            else
            if (sum % 16 == 0)
            {
                pics[k, j].BackColor = Color.Coral;
            }
            else
            if (sum % 8 == 0)
            {
                pics[k, j].BackColor = Color.LightSalmon;
            }
            else
            {
                pics[k, j].BackColor = Color.MistyRose;
            }
        }

        public bool LoseGame() 
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (labels[i, j] == null) { return false; }
                }
            }
            DialogResult result = MessageBox.Show("Гра завершена, але не засмучуйся - зіграй ще раз!\n\nЗберегти твій результат?", "GAME OVER", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            

            if (result == DialogResult.Yes)
            {
                SwapDataf3();
                this.Close();   
            }
            else
            {
                this.Close();
            }
            return true;
        }
    }
}
