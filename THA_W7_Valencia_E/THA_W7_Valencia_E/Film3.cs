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
    public partial class Film3 : Form
    {
        public Film3()
        {
            InitializeComponent();
        }

        private void Film3_Load(object sender, EventArgs e)
        {
            PictureBox Avengers = new PictureBox();
            Avengers.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\AvengersEndGame.jpg");
            Avengers.Size = new Size(130, 140);
            Avengers.Location = new Point(360, 10);
            Avengers.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Avengers);
        }
    }
}
