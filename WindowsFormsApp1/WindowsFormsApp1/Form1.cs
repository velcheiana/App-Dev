using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static int input;
        private void btn_mulai_Click(object sender, EventArgs e)
        {
        
            Form2 form = new Form2();
            input = Convert.ToInt32(txt_isi.Text);
         
            form.Show();
        }
    }
}
