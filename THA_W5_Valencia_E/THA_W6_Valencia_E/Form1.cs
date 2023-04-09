using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_Valencia_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int input;
        private void button_Play_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(textBox_Input.Text, out n);
            if (isNumeric)
            {
                input = Convert.ToInt32(textBox_Input.Text);
                if (input <= 3)
                {
                    MessageBox.Show("Must be greater than 3", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Form2 form = new Form2();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Must be an Integer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void textBox_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
