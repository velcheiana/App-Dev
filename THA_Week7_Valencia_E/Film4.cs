﻿using System;
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
    public partial class Film4 : Form
    {
        Panel film4 = new Panel();
        Label chooseseat = new Label();
        Label chooseseat2 = new Label();
        Label chooseseat3 = new Label();
        Random rndSeat = new Random();
        List<Button> button1 = new List<Button>();
        List<Button> button2 = new List<Button>();
        List<Button> button3 = new List<Button>();
        List<List<Button>> save = new List<List<Button>>();
        public Film4()
        {
            InitializeComponent();
        }
        private void Film4_Load(object sender, EventArgs e)
        {
            //Film4
            PictureBox Annabelle = new PictureBox();
            Annabelle.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\AD Week 8\\Annabelle.jpg");
            Annabelle.Size = new Size(130, 140);
            Annabelle.Location = new Point(20, 30);
            Annabelle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(Annabelle);

            Label labelAnabelle = new Label();
            labelAnabelle.Text = "Annabelle";
            labelAnabelle.Size = new Size(60, 40);
            labelAnabelle.Location = new Point(58, 175);
            this.Controls.Add(labelAnabelle);

            Button btnJamFilm4 = new Button();
            btnJamFilm4.Text = "11.00";
            btnJamFilm4.Size = new Size(60, 30);
            btnJamFilm4.Location = new Point(190, 35);
            this.Controls.Add(btnJamFilm4);
            btnJamFilm4.Click += BtnJamFilm4_Click;

            Button btnJammFilm4 = new Button();
            btnJammFilm4.Text = "12.20";
            btnJammFilm4.Size = new Size(60, 30);
            btnJammFilm4.Location = new Point(190, 85);
            this.Controls.Add(btnJammFilm4);
            btnJammFilm4.Click += BtnJammFilm4_Click;

            Button btnJammmFilm4 = new Button();
            btnJammmFilm4.Text = "19.00";
            btnJammmFilm4.Size = new Size(60, 30);
            btnJammmFilm4.Location = new Point(190, 135);
            this.Controls.Add(btnJammmFilm4);
            btnJammmFilm4.Click += BtnJammmFilm4_Click;

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

            film4.Location = new Point(280, -4);
            film4.Name = "panel3";
            film4.Size = new Size(505, 505);
            film4.TabIndex = 0;
            this.Controls.Add(film4);

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

            film4.Controls.Clear();
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
            film4.Controls.Clear();
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
            film4.Controls.Clear();
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
        private void BtnJamFilm4_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film4.Controls.Clear();
            choose = 1;
            foreach (Button a in button1)
            {
                film4.Controls.Add(a);
                chooseseat.Text = "Selected Seat: ";
            }
        }
        private void BtnJammFilm4_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film4.Controls.Clear();
            choose = 2;
            foreach (Button a in button2)
            {
                film4.Controls.Add(a);
                chooseseat.Text = "Selected Seat: ";
            }
        }
        private void BtnJammmFilm4_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film4.Controls.Clear();
            choose = 3;
            foreach (Button a in button3)
            {
                film4.Controls.Add(a);
                chooseseat.Text = "Selected Seat: ";
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            film4.Controls.Clear();
            foreach (Button a in button1)
            {
                film4.Controls.Add(a);
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
            film4.Controls.Clear();
            foreach (Button a in button2)
            {
                film4.Controls.Add(a);
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
            film4.Controls.Clear();
            foreach (Button a in button3)
            {
                film4.Controls.Add(a);
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
                    film4.Controls.Add(a);
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
                    film4.Controls.Add(a);
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
                    film4.Controls.Add(a);
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
                    film4.Controls.Add(a);
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
                    film4.Controls.Add(a);
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
                    film4.Controls.Add(a);
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
