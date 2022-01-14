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
    public partial class Form3 : Form
    {
        public int LostScore; 

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadRecords();
            if (LostScore>0)
            {
                rtbRecords.Text = (rtbRecords.Text + "Рахунок: " + LostScore + "  Дата та час встановлення твого результату - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
            }
        }

        void SaveRecords()
        {
            try
            {
                rtbRecords.SaveFile("Score.rtf");
            }
            catch
            {
                //MessageBox.Show("Помилка при завантаженні");
            }
        }

        void LoadRecords()
        {
            try
            {
                rtbRecords.LoadFile("Score.rtf");
            }
            catch
            {
                //MessageBox.Show("Помилка при завантаженні");
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            SaveRecords();
            this.Close();
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            rtbRecords.Text = "";
            SaveRecords();
        }
    }
}
