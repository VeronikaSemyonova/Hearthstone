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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Menu = new Form1();
            this.Hide();
            Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 CreateDeck = new Form4();
            this.Hide();
            CreateDeck.Show();
        }

    }
}
