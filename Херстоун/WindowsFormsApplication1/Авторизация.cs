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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Регистрация Form2 = new Регистрация();
            this.Hide();
            Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Меню Menu = new Меню();
            this.Hide();
            Menu.Show();
        }
    }
}
