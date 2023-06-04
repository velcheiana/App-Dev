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
    public partial class Film1 : Form
    {
        public Film1()
        {
            InitializeComponent();
        }

        private void Film1_Load(object sender, EventArgs e)
        {
            //Film1
            PictureBox Johnwick = new PictureBox();
            Johnwick.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\JohnWick.jpeg");
            Johnwick.Size = new Size(130, 140);
            Johnwick.Location = new Point(20, 10);
            Johnwick.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Johnwick);


        }
    }
}
