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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.i;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.i1;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources._1380692332_3126244_nevseoboi_com_ua;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = WindowsFormsApplication1.Properties.Resources.background_wide_wallpaper_1920x1080_005;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
