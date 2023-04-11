using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_Week3_Valencia_E
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public Label label;

        public Form2()
        {
            InitializeComponent();
            Instance = this;
            label = label_submitbtnShow;
        }
        public string label1
        {
            get
            {
                return this.label_submitbtnShow.Text;
            }
            set
            {
                this.label_submitbtnShow.Text = value;
            }
        }

        private void checkBox_Agree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Agree.Checked && checkBox_validTrue.Checked)
            {
                btn_Magic.Enabled = true;
            }
            else
            {
                btn_Magic.Enabled = false;
            }
        }

        private void checkBox_validTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_validTrue.Checked && checkBox_Agree.Checked)
            {
                btn_Magic.Enabled = true;
            }
            else
            {
                btn_Magic.Enabled = false;
            }
        }


        private void btn_Magic_Click(object sender, EventArgs e)
        {
            if (!radioButton_Blue.Checked && !radioButton_Pink.Checked && !radioButton_Purple.Checked && !radioButton_Green.Checked && !radioButton_Yellow.Checked)
            {
                MessageBox.Show("There's no chosen background color radio buttons, user must choose radio buttons", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string FavoriteBGColors = "";
            if (radioButton_Blue.Checked)
            {
                Form1.formInstance.BackColor = Color.Blue;
            }
            if (radioButton_Purple.Checked)
            {
                Form1.formInstance.BackColor = Color.Purple;
            }
            if (radioButton_Pink.Checked)
            {
                Form1.formInstance.BackColor = Color.Pink;
            }
            if (radioButton_Green.Checked)
            {
                Form1.formInstance.BackColor = Color.Green;
            }
            if (radioButton_Yellow.Checked)
            {
                Form1.formInstance.BackColor = Color.Yellow;
            }
            if (!radioButton_Brown.Checked && !radioButton_Red.Checked && !radioButton_Gray.Checked)
            {
                MessageBox.Show("There's no chosen text color radio buttons, user must choose radio buttons", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string textColors = "";
            if (radioButton_Brown.Checked)
            {
                Form1.formInstance.ForeColor = Color.Brown;
            }
            if (radioButton_Red.Checked)
            {
                Form1.formInstance.ForeColor = Color.Red;
            }
            if (radioButton_Gray.Checked)
            {
                Form1.formInstance.ForeColor = Color.Gray;
            }
            
        }

        private void label_submitbtnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
