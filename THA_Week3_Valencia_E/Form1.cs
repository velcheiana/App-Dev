using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace THA_Week3_Valencia_E
{
    public partial class Form1 : Form
    {
        public static Form1 formInstance;
        public TextBox textbox;
        public Form1()
        {
  
            InitializeComponent();
            formInstance = this;
            textbox = textBox_Nama;
        }

        private void checkBox_Agree_checkedChanged(object sender, EventArgs e)
        {
            if ( Application.OpenForms.OfType<Form2>().Any() && checkBox_Valid.Checked)
            {
                btn_Submit.Enabled = true;
            }
            else
            {
                btn_Submit.Enabled = false;
            }
        }

        private void btn_nextForm_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_Nama.Text == "")
            {
                MessageBox.Show("The user must input name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox_favArtist.Text == "")
            {
                MessageBox.Show("The user must input favorite artist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form2.Instance.label.Text = "Hi my name is " + textBox_Nama.Text + "and my favorite artist is" + textBox_favArtist.Text;
            }
        }

        private void textBox_Nama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
