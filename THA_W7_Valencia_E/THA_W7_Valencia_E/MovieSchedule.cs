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
    public partial class MovieSchedule : Form
    {
        public MovieSchedule()
        {
            InitializeComponent();
        }

        private void MovieSchedule_Load(object sender, EventArgs e)
        {
            //Film1
            PictureBox Johnwick = new PictureBox();
            Johnwick.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\JohnWick.jpeg");
            Johnwick.Size = new Size(130, 140);
            Johnwick.Location = new Point(20, 10);
            Johnwick.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Johnwick);

            Button btnJohnWick = new Button();
            btnJohnWick.Text = "Choose";
            btnJohnWick.Size = new Size(60, 30);
            btnJohnWick.Location = new Point(55, 170);
            this.Controls.Add(btnJohnWick);

            Label labelJohnWick = new Label();
            labelJohnWick.Text = "JohnWick";
            labelJohnWick.Size = new Size(60, 40);
            labelJohnWick.Location = new Point(58, 155);
            this.Controls.Add(labelJohnWick);

            //Film2
            PictureBox Avatar = new PictureBox();
            Avatar.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Avatar.jpg");
            Avatar.Size = new Size(130, 140);
            Avatar.Location = new Point(190, 10);
            Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Avatar);

            Button btnAvatar = new Button();
            btnAvatar.Text = "Choose";
            btnAvatar.Size = new Size(60, 30);
            btnAvatar.Location = new Point(226, 170);
            this.Controls.Add(btnAvatar);

            Label labelAvatar = new Label();
            labelAvatar.Text = "Avatar";
            labelAvatar.Size = new Size(60, 40);
            labelAvatar.Location = new Point(236, 155);
            this.Controls.Add(labelAvatar);

            //Film3
            PictureBox Avengers = new PictureBox();
            Avengers.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\AvengersEndGame.jpg");
            Avengers.Size = new Size(130, 140);
            Avengers.Location = new Point(360, 10);
            Avengers.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Avengers);

            Button btnAvengers = new Button();
            btnAvengers.Text = "Choose";
            btnAvengers.Size = new Size(60, 30);
            btnAvengers.Location = new Point(397, 170);
            this.Controls.Add(btnAvengers);

            Label labelAvengers = new Label();
            labelAvengers.Text = "Avengers";
            labelAvengers.Size = new Size(60, 40);
            labelAvengers.Location = new Point(400, 155);
            this.Controls.Add(labelAvengers);


            //Film4
            PictureBox Annabelle = new PictureBox();
            Annabelle.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Annabelle.jpg");
            Annabelle.Size = new Size(130, 140);
            Annabelle.Location = new Point(530, 10);
            Annabelle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Annabelle);

            Button btnAnnabelle = new Button();
            btnAnnabelle.Text = "Choose";
            btnAnnabelle.Size = new Size(60, 30);
            btnAnnabelle.Location = new Point(568, 170);
            this.Controls.Add(btnAnnabelle);

            Label labelAnabelle = new Label();
            labelAnabelle.Text = "Annabelle";
            labelAnabelle.Size = new Size(60, 40);
            labelAnabelle.Location = new Point(572, 155);
            this.Controls.Add(labelAnabelle);

            //Film5
            PictureBox Titanic = new PictureBox();
            Titanic.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Titanic.jpeg");
            Titanic.Size = new Size(130, 140);
            Titanic.Location = new Point(20, 210);
            Titanic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Titanic);

            Button btnTitanic = new Button();
            btnTitanic.Text = "Choose";
            btnTitanic.Size = new Size(60, 30);
            btnTitanic.Location = new Point(55, 370);
            this.Controls.Add(btnTitanic);

            Label labelTitanic = new Label();
            labelTitanic.Text = "Titanic";
            labelTitanic.Size = new Size(60, 40);
            labelTitanic.Location = new Point(65, 355);
            this.Controls.Add(labelTitanic);

            //Film6
            PictureBox Thor = new PictureBox();
            Thor.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Thor.jpeg");
            Thor.Size = new Size(130, 140);
            Thor.Location = new Point(190, 210);
            Thor.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Thor);

            Button btnThor = new Button();
            btnThor.Text = "Choose";
            btnThor.Size = new Size(60, 30);
            btnThor.Location = new Point(226, 370);
            this.Controls.Add(btnThor);

            Label labelThor = new Label();
            labelThor.Text = "Thor";
            labelThor.Size = new Size(60, 40);
            labelThor.Location = new Point(240, 355);
            this.Controls.Add(labelThor);

            //Film7
            PictureBox starWars = new PictureBox();
            starWars.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\StarWars.jpg");
            starWars.Size = new Size(130, 140);
            starWars.Location = new Point(360, 210);
            starWars.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(starWars);

            Button btnStarWars = new Button();
            btnStarWars.Text = "Choose";
            btnStarWars.Size = new Size(60, 30);
            btnStarWars.Location = new Point(397, 370);
            this.Controls.Add(btnStarWars);

            Label labelStarWars = new Label();
            labelStarWars.Text = "StarWars";
            labelStarWars.Size = new Size(60, 40);
            labelStarWars.Location = new Point(402, 355);
            this.Controls.Add(labelStarWars);

            //Film8
            PictureBox Aladdin = new PictureBox();
            Aladdin.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Aladdin.jpg");
            Aladdin.Size = new Size(130, 140);
            Aladdin.Location = new Point(530, 210);
            Aladdin.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Aladdin);

            Button btnAladdin = new Button();
            btnAladdin.Text = "Choose";
            btnAladdin.Size = new Size(60, 30);
            btnAladdin.Location = new Point(568, 370);
            this.Controls.Add(btnAladdin);

            Label labelAladdin = new Label();
            labelAladdin.Text = "Aladdin";
            labelAladdin.Size = new Size(60, 40);
            labelAladdin.Location = new Point(578, 355);
            this.Controls.Add(labelAladdin);

        }
    }
}
