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
    public partial class Film4 : Form
    {
        public Film4()
        {
            InitializeComponent();
        }

        private void Film4_Load(object sender, EventArgs e)
        {
            PictureBox Annabelle = new PictureBox();
            Annabelle.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Annabelle.jpg");
            Annabelle.Size = new Size(130, 140);
            Annabelle.Location = new Point(530, 10);
            Annabelle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Annabelle);
        }
    }
}
