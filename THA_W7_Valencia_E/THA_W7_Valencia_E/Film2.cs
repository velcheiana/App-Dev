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
    public partial class Film2 : Form
    {
        public Film2()
        {
            InitializeComponent();
        }

        private void Film2_Load(object sender, EventArgs e)
        {
            PictureBox Avatar = new PictureBox();
            Avatar.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Avatar.jpg");
            Avatar.Size = new Size(130, 140);
            Avatar.Location = new Point(190, 10);
            Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Avatar);
        }
    }
}
