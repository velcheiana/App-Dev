using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_Valencia_E
{
    public partial class Film6 : Form
    {
        public Film6()
        {
            InitializeComponent();
        }

        private void Film6_Load(object sender, EventArgs e)
        {
            PictureBox Thor = new PictureBox();
            Thor.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Thor.jpeg");
            Thor.Size = new Size(130, 140);
            Thor.Location = new Point(190, 210);
            Thor.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Thor);
        }
    }
}
