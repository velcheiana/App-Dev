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
    public partial class Film5 : Form
    {
        public Film5()
        {
            InitializeComponent();
        }

        private void Film5_Load(object sender, EventArgs e)
        {
            PictureBox Titanic = new PictureBox();
            Titanic.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Titanic.jpeg");
            Titanic.Size = new Size(130, 140);
            Titanic.Location = new Point(20, 210);
            Titanic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Titanic);
        }
    }
}
