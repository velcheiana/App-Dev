using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_Week7_Valencia_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Film1
            PictureBox Johnwick = new PictureBox();
            Johnwick.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\JohnWick.jpeg");
            Johnwick.Size = new Size(130, 140);
            Johnwick.Location = new Point(20, 30);
            Johnwick.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Johnwick);

            Button btnJohnWick = new Button();
            btnJohnWick.Text = "Choose";
            btnJohnWick.Size = new Size(60, 30);
            btnJohnWick.Location = new Point(55, 190);
            this.Controls.Add(btnJohnWick);
            btnJohnWick.Click += BtnJohnWick_Click;

            Label labelJohnWick = new Label();
            labelJohnWick.Text = "JohnWick";
            labelJohnWick.Size = new Size(60, 40);
            labelJohnWick.Location = new Point(58, 175);
            this.Controls.Add(labelJohnWick);

            //Film2
            PictureBox Avatar = new PictureBox();
            Avatar.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Avatar.jpg");
            Avatar.Size = new Size(130, 140);
            Avatar.Location = new Point(190, 30);
            Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Avatar);

            Button btnAvatar = new Button();
            btnAvatar.Text = "Choose";
            btnAvatar.Size = new Size(60, 30);
            btnAvatar.Location = new Point(226, 190);
            this.Controls.Add(btnAvatar);
            btnAvatar.Click += BtnAvatar_Click;

            Label labelAvatar = new Label();
            labelAvatar.Text = "Avatar";
            labelAvatar.Size = new Size(60, 40);
            labelAvatar.Location = new Point(236, 175);
            this.Controls.Add(labelAvatar);

            //Film3
            PictureBox Avengers = new PictureBox();
            Avengers.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\AvengersEndGame.jpg");
            Avengers.Size = new Size(130, 140);
            Avengers.Location = new Point(360, 30);
            Avengers.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Avengers);

            Button btnAvengers = new Button();
            btnAvengers.Text = "Choose";
            btnAvengers.Size = new Size(60, 30);
            btnAvengers.Location = new Point(397, 190);
            this.Controls.Add(btnAvengers);
            btnAvengers.Click += BtnAvengers_Click;

            Label labelAvengers = new Label();
            labelAvengers.Text = "Avengers";
            labelAvengers.Size = new Size(60, 40);
            labelAvengers.Location = new Point(400, 175);
            this.Controls.Add(labelAvengers);


            //Film4
            PictureBox Annabelle = new PictureBox();
            Annabelle.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Annabelle.jpg");
            Annabelle.Size = new Size(130, 140);
            Annabelle.Location = new Point(530, 30);
            Annabelle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Annabelle);

            Button btnAnnabelle = new Button();
            btnAnnabelle.Text = "Choose";
            btnAnnabelle.Size = new Size(60, 30);
            btnAnnabelle.Location = new Point(568, 190);
            this.Controls.Add(btnAnnabelle);
            btnAnnabelle.Click += BtnAnnabelle_Click;

            Label labelAnabelle = new Label();
            labelAnabelle.Text = "Annabelle";
            labelAnabelle.Size = new Size(60, 40);
            labelAnabelle.Location = new Point(572, 175);
            this.Controls.Add(labelAnabelle);

            //Film5
            PictureBox Titanic = new PictureBox();
            Titanic.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Titanic.jpeg");
            Titanic.Size = new Size(130, 140);
            Titanic.Location = new Point(20, 230);
            Titanic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Titanic);

            Button btnTitanic = new Button();
            btnTitanic.Text = "Choose";
            btnTitanic.Size = new Size(60, 30);
            btnTitanic.Location = new Point(55, 390);
            this.Controls.Add(btnTitanic);
            btnTitanic.Click += BtnTitanic_Click;

            Label labelTitanic = new Label();
            labelTitanic.Text = "Titanic";
            labelTitanic.Size = new Size(60, 40);
            labelTitanic.Location = new Point(65, 375);
            this.Controls.Add(labelTitanic);

            //Film6
            PictureBox Thor = new PictureBox();
            Thor.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Thor.jpeg");
            Thor.Size = new Size(130, 140);
            Thor.Location = new Point(190, 230);
            Thor.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Thor);

            Button btnThor = new Button();
            btnThor.Text = "Choose";
            btnThor.Size = new Size(60, 30);
            btnThor.Location = new Point(226, 390);
            this.Controls.Add(btnThor);
            btnThor.Click += BtnThor_Click;

            Label labelThor = new Label();
            labelThor.Text = "Thor";
            labelThor.Size = new Size(60, 40);
            labelThor.Location = new Point(240, 375);
            this.Controls.Add(labelThor);

            //Film7
            PictureBox starWars = new PictureBox();
            starWars.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\StarWars.jpg");
            starWars.Size = new Size(130, 140);
            starWars.Location = new Point(360, 230);
            starWars.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(starWars);

            Button btnStarWars = new Button();
            btnStarWars.Text = "Choose";
            btnStarWars.Size = new Size(60, 30);
            btnStarWars.Location = new Point(397, 390);
            this.Controls.Add(btnStarWars);
            btnStarWars.Click += BtnStarWars_Click;

            Label labelStarWars = new Label();
            labelStarWars.Text = "StarWars";
            labelStarWars.Size = new Size(60, 40);
            labelStarWars.Location = new Point(402, 375);
            this.Controls.Add(labelStarWars);

            //Film8
            PictureBox Aladdin = new PictureBox();
            Aladdin.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Aladdin.jpg");
            Aladdin.Size = new Size(130, 140);
            Aladdin.Location = new Point(530, 230);
            Aladdin.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Aladdin);

            Button btnAladdin = new Button();
            btnAladdin.Text = "Choose";
            btnAladdin.Size = new Size(60, 30);
            btnAladdin.Location = new Point(568, 390);
            this.Controls.Add(btnAladdin);
            btnAladdin.Click += BtnAladdin_Click;

            Label labelAladdin = new Label();
            labelAladdin.Text = "Aladdin";
            labelAladdin.Size = new Size(60, 40);
            labelAladdin.Location = new Point(578, 375);
            this.Controls.Add(labelAladdin);
        }

        private void BtnAladdin_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Film8 film8 = new Film8();
            film8.Show();
        }

        private void BtnStarWars_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Film7 film7 = new Film7();
            film7.Show();
        }

        private void BtnThor_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Film6 film6 = new Film6();
            film6.Show();
        }

        private void BtnTitanic_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Film5 film5 = new Film5();
            film5.Show();
        }

        private void BtnAnnabelle_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Film4 film4 = new Film4();
            film4.Show();
        }

        private void BtnAvengers_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Film3 film3 = new Film3();
            film3.Show();

        }

        private void BtnAvatar_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Film2 film2 = new Film2();
            film2.Show();
        }

        private void BtnJohnWick_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Film1 film1 = new Film1();
            film1.Show();
        }
    }
}