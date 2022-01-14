using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME2048
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        public int LastScoreWin;
        public int TotalWinScore;


        private void Form4_Load(object sender, EventArgs e)
        {
            Babach();
        }

        private void Babach()
        {
            LoadWins();
            try
            {
                TotalWinScore = Convert.ToInt32(rtbInvizWinNumber.Text);
            }
            catch
            {
                //MessageBox.Show("Щось пішло не так!");
            }
            TotalWinNumber();
            HowYouWin();
        }

        public void TotalWinNumber()
        {
            while (LastScoreWin != 0)
            {
                LastScoreWin--;
                TotalWinScore++;
            }
            rtbInvizWinNumber.Text = Convert.ToString(TotalWinScore);
        }

        public void HowYouWin()
        {
            if (TotalWinScore == 0)
            {
                rtbWinsNumbers.Text = "Оу, ти ще жодного разу не переміг, але не засмучуйся!\nВпевнений, ти ще здобудеш далеко не одну перемогу!";
            }
            else if (TotalWinScore == 1)
            {
                rtbWinsNumbers.Text = "Ого, вітаю, на твоєму рахунку вже є одна переміга!";
            }
            else if (TotalWinScore > 1 && TotalWinScore < 5)
            {
                rtbWinsNumbers.Text = "Ого, вітаю, на твоєму рахунку вже " + TotalWinScore + " перемoги!";
            }
            else if (TotalWinScore >= 5)
            {
                rtbWinsNumbers.Text = "Ти наче звір! Пермогти " + TotalWinScore + " разів?!\nНавіть не хочу знати скільки спроб ти на це витратив!";
            }
        }

        void SaveWins()
        {
            try
            {
                rtbInvizWinNumber.SaveFile("WinScore.rtf");
            }
            catch
            {
                //MessageBox.Show("Помилка при завантаженні");
            }
        }

        void LoadWins()
        {
            try
            {
                rtbInvizWinNumber.LoadFile("WinScore.rtf");
            }
            catch
            {
                //MessageBox.Show("Помилка при завантаженні");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveWins();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbInvizWinNumber.Text = "0";
            SaveWins();
            Babach();
        }
    }
}
