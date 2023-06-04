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
    public partial class Film7 : Form
    {
        public Film7()
        {
            InitializeComponent();
        }

        private void Film7_Load(object sender, EventArgs e)
        {
            PictureBox starWars = new PictureBox();
            starWars.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\StarWars.jpg");
            starWars.Size = new Size(130, 140);
            starWars.Location = new Point(360, 210);
            starWars.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(starWars);


        }
    }
}
