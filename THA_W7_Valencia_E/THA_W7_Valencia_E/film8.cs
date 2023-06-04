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
    public partial class film8 : Form
    {
        public film8()
        {
            InitializeComponent();
        }

        private void film8_Load(object sender, EventArgs e)
        {
            PictureBox Aladdin = new PictureBox();
            Aladdin.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Aladdin.jpg");
            Aladdin.Size = new Size(130, 140);
            Aladdin.Location = new Point(530, 210);
            Aladdin.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Aladdin);
        }
    }
}
