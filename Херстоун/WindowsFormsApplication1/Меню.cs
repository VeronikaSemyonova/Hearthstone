using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Авторизация Menu = new Авторизация();
            this.Hide();
            Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 CreateDeck = new Form4();
            this.Hide();
            CreateDeck.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 Red = new Form5();
            this.Hide();
            Red.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Choose = new Form2();
            this.Hide();
            Choose.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Статистика Statistics = new Статистика();
            this.Hide();
            Statistics.Show();
        }

    }
}
