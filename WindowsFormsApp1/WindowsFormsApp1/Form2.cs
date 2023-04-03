using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();
        Button[,] buttonarray;
        public int biru;
       
        private void Form2_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;

            //MessageBox.Show(Form1.input.ToString());
            buttonarray = new Button[Form1.input, Form1.input];
            for (int i = 0; i < Form1.input; i++)
            {
                for (int j = 0; j < Form1.input; j++)
                {
                    buttonarray[i, j] = new Button();
                    buttonarray[i,j].Location = new Point(x,y);
                    buttonarray[i,j].Size = new Size(40, 40);
                    x += 50;
                    buttonarray[i,j].Tag = i+","+j;
                    this.Controls.Add(buttonarray[i,j]);
                    buttonarray[i, j].Click += buttonarray_Click;
                    buttonarray[i,j].BackColor = Color.Gray;
                    buttonarray[i,j].Text =i+","+j;
                }
                x = 10;
                y += 50;
            }
            
        }
        private void buttonarray_Click (object sender, EventArgs e)
        {
            // MessageBox.Show((sender as Button).Tag.ToString());

            Button tmp = sender as Button;

            int posX = Convert.ToInt16(tmp.Tag.ToString().Substring(0, 1));
            int posY = Convert.ToInt32(tmp.Tag.ToString().Substring(2, 1));

            if (buttonarray[posX, posY].BackColor == Color.Gray)
            {
                buttonarray[posX,posY].BackColor = Color.Red;
            }
            else
            {
                if (buttonarray[posX, posY].BackColor == Color.Red)
                {
                    buttonarray[posX, posY].BackColor = Color.Blue;
                    if (posX - 1 > 0)
                    {
                        if (buttonarray[posX-1, posY].BackColor == Color.Red)
                        {
                            buttonarray[posX-1, posY].BackColor = Color.Blue;

                        }
                        else if (buttonarray[posX-1, posY].BackColor == Color.Blue)
                        {
                            buttonarray[posX-1, posY].BackColor = Color.Red;
                        }
                        else if (buttonarray[posX + 1, posY].BackColor == Color.Blue)
                        {
                            buttonarray[posX + 1, posY].BackColor = Color.Red;
                        }
                        else if (buttonarray[posX + 1, posY].BackColor == Color.Red)
                        {
                            buttonarray[posX + 1, posY].BackColor = Color.Blue;
                        }


                    }
                    else if (posX - 1 > Form1.input)
                    {
                        if (buttonarray[posX - 1, posY].BackColor == Color.Red)
                        {
                            buttonarray[posX - 1, posY].BackColor = Color.Blue;

                        }
                        else if (buttonarray[posX - 1, posY].BackColor == Color.Blue)
                        {
                            buttonarray[posX - 1, posY].BackColor = Color.Red;
                        }
                        else if (buttonarray[posX + 1, posY].BackColor == Color.Blue)
                        {
                            buttonarray[posX + 1, posY].BackColor = Color.Red;
                        }
                        else if (buttonarray[posX + 1, posY].BackColor == Color.Red)
                        {
                            buttonarray[posX + 1, posY].BackColor = Color.Blue;
                        }
                    }
                }
                else if (buttonarray[posX, posY].BackColor == Color.Blue)
                {
                    buttonarray[posX, posY].BackColor = Color.Red;
                    if (posY - 1 > 0)
                    {
                        if (buttonarray[posX , posY -1].BackColor == Color.Red)
                        {
                            buttonarray[posX, posY-1].BackColor = Color.Blue;

                        }
                        else if (buttonarray[posX, posY-1].BackColor == Color.Blue)
                        {
                            buttonarray[posX , posY-1].BackColor = Color.Red;
                        }
                        else if (buttonarray[posX, posY + 1].BackColor == Color.Blue)
                        {
                            buttonarray[posX, posY + 1].BackColor = Color.Red;
                        }
                        else if (buttonarray[posX, posY + 1].BackColor == Color.Red)
                        {
                            buttonarray[posX, posY + 1].BackColor = Color.Blue;
                        }


                    }
                    else if (posY + 1 > Form1.input )
                    {
                        if (buttonarray[posX, posY - 1].BackColor == Color.Red)
                        {
                            buttonarray[posX, posY - 1].BackColor = Color.Blue;

                        }
                        else if (buttonarray[posX, posY - 1].BackColor == Color.Blue)
                        {
                            buttonarray[posX, posY - 1].BackColor = Color.Red;
                        }
                        else if (buttonarray[posX, posY + 1].BackColor == Color.Blue)
                        {
                            buttonarray[posX, posY + 1].BackColor = Color.Red;
                        }
                        else if (buttonarray[posX, posY + 1].BackColor == Color.Red)
                        {
                            buttonarray[posX, posY + 1].BackColor = Color.Blue;
                        }
                    }
                }


            }
                                    

                if (merah == Form1.input * Form1.input)
                {
                    MessageBox.Show("Merah Menang");
                }
                else if (birut == Form1.input * Form1.input)
                {
                    MessageBox.Show("Biru Menang");
                }
                                
        }
        public int merah = 0;
        public int birut = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
             merah=0;
             birut=0;
            for ( int i = 0; i < Form1.input; i++ )
            {
                for (int j = 0; j< Form1.input; j++ )
                {
                    if(buttonarray[i,j].BackColor== Color.Red)
                    {
                        merah++;
                        label1.Text = merah.ToString();
                    }
                    else if (buttonarray[i, j].BackColor == Color.Blue)
                    {
                        birut++;
                        label2.Text = birut.ToString();
                    }
                }
            }
            
        }
    }
}
