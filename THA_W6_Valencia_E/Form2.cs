using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace THA_W6_Valencia_E
{
    public partial class Form2 : Form
    {
        int counter = 0;
        int counter2 = 0;
        List<Button> button1 = new List<Button>();
        List<Button> button2 = new List<Button>();
        List<string> alphabet = new List<string>() { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
        string[] kata = File.ReadAllText("Wordle Word List.txt").Split(',');
        List<string> daftarkata = new List<string>();
        string simpan;
        List<string> tebak = new List<string>();
        List<string> sama = new List<string>();
        int ending = Form1.input;

        public Form2()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();
        int cek = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i = 1; i <= Form1.input; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Button btn = new Button();
                    btn.Tag = "button" + cek;
                    btn.Location = new Point(x, y);
                    btn.Size = new Size(50, 50);
                    x += 50;
                    button1.Add(btn);
                    cek++;
                }
                x = 10;
                y += 50;
            }
            foreach (Button a in button1)
            {
                this.Controls.Add(a);
            }

            int samping = 270;
            int tinggi = 20;
            foreach (var i in alphabet)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Location = new Point(samping, tinggi);
                button.Size = new Size(50, 50);
                this.Controls.Add(button);
                button.Click += btn2_Click;
                samping += 60;

                if (i == "P")
                {
                    tinggi += 60;
                    samping = 300;
                }
                else if (i == "L")
                {
                    tinggi += 60;
                    samping = 360;
                }
            }
            Button buttondel = new Button();
            buttondel.Location = new Point(295, 140);
            buttondel.Size = new Size(55, 40);
            buttondel.Click += btndel_Click;
            buttondel.Text = "Delete";
            this.Controls.Add(buttondel);
            Button buttonenter = new Button();
            buttonenter.Location = new Point(780, 140);
            buttonenter.Size = new Size(55, 40);
            buttonenter.Click += btnenter_Click;
            buttonenter.Text = "Enter";
            this.Controls.Add(buttonenter);

            string guess = kata[new Random().Next(0, kata.Length)];
            MessageBox.Show(guess);
            simpan = guess;

            for (int i = 0; i < simpan.Length; i++)
            {
                daftarkata.Add(simpan[i].ToString().ToUpper());
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (button1[0].Text != "")
            {
                button1[cekk - 1].Text = "";
                cekk--;
            }
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            bebas = bebas + 5;
            int cekk2 = 0;
            int countjumlahinput = 0;
           
            for (int z = counter2; z<counter2 + 5; z++)
            {
                if (button1[z].Text == " " || button1[z].Text == "")
                {
                    countjumlahinput++;
                }
                
            }
            if (countjumlahinput > 1)
            {
                MessageBox.Show("Please enter a 5 letter word!!", "Invalid Guess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(countjumlahinput < 1)
            {
                for (int i = counter2; i < counter2 + 5; i++)
                {
                    tebak.Add(button1[i].Text);
                    counter++;
                }
                //MessageBox.Show("counter "+counter.ToString());
                
                for (int i = counter - 5; i < counter; i++)
                {
                    //MessageBox.Show(i.ToString()+"i");
                    for (int j = counter - 5; j < counter; j++)
                    {
                        //MessageBox.Show(j.ToString()+"j");
                        if (daftarkata[i % 5] == tebak[j])
                        {
                            button1[i].BackColor = Color.Yellow;
                        }
                    }
                }

                foreach (var a in daftarkata)
                {
                    if (a == tebak[counter2])
                    {
                        button1[counter2].BackColor = Color.LightGreen;
                        cekk2++;
                    }
                    counter2++;
                }
                if (cekk2 == 5)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                }
                if (counter >= ending * 5)
                {
                    MessageBox.Show("You Lose! the answer is " + simpan );
                    this.Close();
                }
            }
            countjumlahinput = 0;
            
        }

        int cekk = 0;
        int bebas = 4;
        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string karakter = button.Text;
            for (int i = cekk; i < cekk + 1; i++)
            {
                if (cekk < bebas + 1)
                {
                    button1[i].Text = karakter;
                }
            }
            cekk++;
        }
    }
}
