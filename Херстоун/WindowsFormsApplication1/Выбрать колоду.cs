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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Меню Menu = new Меню();
            this.Hide();
            Menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 Redaction = new Form5();
            this.Hide();
            Redaction.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 Result = new Form1();
            this.Hide();
            Result.Show();
        }
    }
}
