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
    public partial class Form4 : Form
    {
        public Form4()
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
            Авторизация Menu = new Авторизация();
            this.Hide();
            Menu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.друид;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Охотник;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.маг;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.паладин;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Жрец;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Разбойник;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.шаман;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Чернокнижник;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.воин;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            Меню Menu = new Меню();
            this.Hide();
            Menu.Show();
        }

    }
}
