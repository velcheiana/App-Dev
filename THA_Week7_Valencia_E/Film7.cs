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
    public partial class Film7 : Form
    {
        Panel film7 = new Panel();
        Label chooseseat = new Label();
        Label chooseseat2 = new Label();
        Label chooseseat3 = new Label();
        Random rndSeat = new Random();
        List<Button> button1 = new List<Button>();
        List<Button> button2 = new List<Button>();
        List<Button> button3 = new List<Button>();
        List<List<Button>> save = new List<List<Button>>();
        public Film7()
        {
            InitializeComponent();
        }
        private void Film7_Load(object sender, EventArgs e)
        {
            PictureBox starWars = new PictureBox();
            starWars.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\StarWars.jpg");
            starWars.Size = new Size(130, 140);
            starWars.Location = new Point(20, 30);
            starWars.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(starWars);

            Label labelStarWars = new Label();
            labelStarWars.Text = "StarWars";
            labelStarWars.Size = new Size(60, 40);
            labelStarWars.Location = new Point(58, 175);
            this.Controls.Add(labelStarWars);

            Button btnJamFilm7 = new Button();
            btnJamFilm7.Text = "11.45";
            btnJamFilm7.Size = new Size(60, 30);
            btnJamFilm7.Location = new Point(190, 35);
            this.Controls.Add(btnJamFilm7);
            btnJamFilm7.Click += BtnJamFilm7_Click;

            Button btnJammFilm7 = new Button();
            btnJammFilm7.Text = "13.40";
            btnJammFilm7.Size = new Size(60, 30);
            btnJammFilm7.Location = new Point(190, 85);
            this.Controls.Add(btnJammFilm7);
            btnJammFilm7.Click += BtnJammFilm7_Click;

            Button btnJammmFilm7 = new Button();
            btnJammmFilm7.Text = "18.00";
            btnJammmFilm7.Size = new Size(60, 30);
            btnJammmFilm7.Location = new Point(190, 135);
            this.Controls.Add(btnJammmFilm7);
            btnJammmFilm7.Click += BtnJammmFilm7_Click;

            Button back = new Button();
            back.Location = new Point(20, 250);
            back.Size = new Size(60, 30);
            back.Text = "Back";
            this.Controls.Add(back);
            back.Click += Back_Click;

            Button Reset = new Button();
            Reset.Location = new Point(105, 250);
            Reset.Size = new Size(60, 30);
            Reset.Text = "Reset";
            Controls.Add(Reset);
            Reset.Click += Reset_Click;

            Button reserve = new Button();
            reserve.Location = new Point(190, 250);
            reserve.Size = new Size(60, 30);
            reserve.Text = "Reserve";
            Controls.Add(reserve);
            reserve.Click += Reserve_Click;

            film7.Location = new Point(280, -4);
            film7.Name = "panel3";
            film7.Size = new Size(505, 505);
            film7.TabIndex = 0;
            this.Controls.Add(film7);

            chooseseat.Location = new Point(20, 230);
            chooseseat.Size = new Size(300, 300);
            chooseseat.Text = "Selected Seat: ";
            Controls.Add(chooseseat);

            chooseseat2.Location = new Point(20, 230);
            chooseseat2.Size = new Size(300, 300);
            chooseseat2.Text = "Selected Seat: ";
            Controls.Add(chooseseat2);

            chooseseat3.Location = new Point(20, 230);
            chooseseat3.Size = new Size(300, 300);
            chooseseat3.Text = "Selected Seat: ";
            Controls.Add(chooseseat3);

            film7.Controls.Clear();
            int cek = 0;
            int x = 10;
            int y = 10;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Button btn1 = new Button();
                    btn1.Tag = j.ToString() + "," + i.ToString();
                    btn1.Location = new Point(x, y);
                    btn1.Size = new Size(40, 40);
                    btn1.BackColor = Color.Green;
                    x += 50;
                    button1.Add(btn1);
                    btn1.Click += Btn1_Click;
                    cek++;
                    btn1.Text = cek.ToString();
                }
                x = 10;
                y += 50;
            }
            film7.Controls.Clear();
            int cek2 = 0;
            x = 10;
            y = 10;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Button btn2 = new Button();
                    btn2.Tag = j.ToString() + "," + i.ToString();
                    btn2.Location = new Point(x, y);
                    btn2.Size = new Size(40, 40);
                    btn2.BackColor = Color.Green;
                    x += 50;
                    button2.Add(btn2);
                    btn2.Click += Btn2_Click;
                    cek2++;
                    btn2.Text = cek2.ToString();
                }
                x = 10;
                y += 50;
            }
            film7.Controls.Clear();
            int cek3 = 0;
            x = 10;
            y = 10;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Button btn3 = new Button();
                    btn3.Tag = j.ToString() + "," + i.ToString();
                    btn3.Location = new Point(x, y);
                    btn3.Size = new Size(40, 40);
                    btn3.BackColor = Color.Green;
                    x += 50;
                    button3.Add(btn3);
                    btn3.Click += Btn3_Click;
                    cek3++;
                    btn3.Text = cek3.ToString();
                }
                x = 10;
                y += 50;
            }
            for (int i = 1; i < 70; i++)
            {
                int seat = rndSeat.Next(0, 99);
                button1[seat].BackColor = Color.Red;
                button1[seat].Enabled = false;
            }
            for (int i = 1; i < 70; i++)
            {
                int seat = rndSeat.Next(0, 99);
                button2[seat].BackColor = Color.Red;
                button2[seat].Enabled = false;
            }
            for (int i = 1; i < 70; i++)
            {
                int seat = rndSeat.Next(0, 99);
                button3[seat].BackColor = Color.Red;
                button3[seat].Enabled = false;
            }
        }
        int choose = 0;
        private void BtnJamFilm7_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film7.Controls.Clear();
            choose = 1;
            foreach (Button a in button1)
            {
                film7.Controls.Add(a);
                chooseseat.Text = "Selected Seat: ";
            }
        }
        private void BtnJammFilm7_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film7.Controls.Clear();
            choose = 2;
            foreach (Button a in button2)
            {
                film7.Controls.Add(a);
                chooseseat.Text = "Selected Seat: ";
            }
        }
        private void BtnJammmFilm7_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film7.Controls.Clear();
            choose = 3;
            foreach (Button a in button3)
            {
                film7.Controls.Add(a);
                chooseseat.Text = "Selected Seat: ";
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film7.Controls.Clear();
            foreach (Button a in button1)
            {
                film7.Controls.Add(a);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Yellow;
                chooseseat.Text += button.Text + ",";
            }
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film7.Controls.Clear();
            foreach (Button a in button2)
            {
                film7.Controls.Add(a);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Yellow;
                chooseseat.Text += button.Text + ",";
            }
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film7.Controls.Clear();
            foreach (Button a in button3)
            {
                film7.Controls.Add(a);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Yellow;
                chooseseat.Text += button.Text + ",";
            }
        }
        private void Reserve_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (choose == 1)
            {
                foreach (Button a in button1)
                {
                    film7.Controls.Add(a);
                    foreach (Button button in button1)
                    {
                        if (button.BackColor == Color.Yellow)
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                    }
                }
            }
            if (choose == 2)
            {
                foreach (Button a in button2)
                {
                    film7.Controls.Add(a);
                    foreach (Button button in button2)
                    {
                        if (button.BackColor == Color.Yellow)
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                    }
                }
            }
            if (choose == 3)
            {
                foreach (Button a in button3)
                {
                    film7.Controls.Add(a);
                    foreach (Button button in button3)
                    {
                        if (button.BackColor == Color.Yellow)
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                    }
                }
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (choose == 1)
            {
                foreach (Button a in button1)
                {
                    film7.Controls.Add(a);
                    foreach (Button button in button1)
                    {
                        if (button.BackColor == Color.Yellow)
                        {
                            button.BackColor = Color.Red;
                        }
                        if (button.BackColor == Color.Red)
                        {
                            button.BackColor = Color.Green;
                            button.Enabled = true;
                            chooseseat.Text = "Selected Seat: ";
                        }
                    }
                }
            }
            if (choose == 2)
            {
                foreach (Button a in button2)
                {
                    film7.Controls.Add(a);
                    foreach (Button button in button2)
                    {
                        if (button.BackColor == Color.Yellow)
                        {
                            button.BackColor = Color.Red;
                        }
                        if (button.BackColor == Color.Red)
                        {
                            button.BackColor = Color.Green;
                            button.Enabled = true;
                            chooseseat.Text = "Selected Seat: ";
                        }
                    }
                }
            }
            if (choose == 3)
            {
                foreach (Button a in button3)
                {
                    film7.Controls.Add(a);
                    foreach (Button button in button3)
                    {
                        if (button.BackColor == Color.Yellow)
                        {
                            button.BackColor = Color.Red;
                        }
                        if (button.BackColor == Color.Red)
                        {
                            button.BackColor = Color.Green;
                            button.Enabled = true;
                            chooseseat.Text = "Selected Seat: ";
                        }
                    }
                }
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.Close();
        }
    }
}
