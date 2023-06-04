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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void movieScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MovieSchedule movieSchedule = new MovieSchedule();
           movieSchedule.Dock = DockStyle.Fill;
           movieSchedule.TopLevel = false;
           panel1.Controls.Add(movieSchedule);
           this.panel1.Controls.Add(movieSchedule);
           movieSchedule.Show();

           
        }

    }
}
