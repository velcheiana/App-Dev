using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace THA_W5_Valencia_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        public List<string> Category = new List<string>() { "Jas", "T-Shirt", "Rok", "Celana", "Cawat" };
        public List<string> IdCategory = new List<string>() { "C1", "C2", "C3", "C4", "C5" };
        int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            dtProdukSimpan.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtProdukSimpan.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtProdukSimpan.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtProdukSimpan.Rows.Add("R001", "Rok Mini", "82000", "26", "C3");
            dtProdukSimpan.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtProdukSimpan.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtProdukSimpan.Rows.Add("C002", "Cawat Blink-Blink", "1000000", "1", "C5");
            dtProdukSimpan.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");
            DGV_Product.DataSource = dtProdukSimpan;

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category"); 
            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");
            DGV_Category.DataSource = dtCategory;

            foreach (string a in Category)
            {
                comboBox_Filter.Items.Add(a);
                comboBox_Category.Items.Add(a);
            }
            

        }

        private void btn_All_Click(object sender, EventArgs e)
        {

        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Enabled = true;
        }

        int angka = 6;
        string data = "";
        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            data = "C" + angka;
            IdCategory.Add(data);
            angka = angka + 1;
            bool check = false;
            if (string.IsNullOrEmpty(textBox_Nama2.Text))
            {
                MessageBox.Show("Masukkan Nama Category Terlebih Dahulu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (DataRow dr in dtCategory.Rows)
            {
                if (dr[1].ToString() == textBox_Nama2.Text)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                dtCategory.Rows.Add(data, textBox_Nama2.Text);
                comboBox_Category.Items.Add(textBox_Nama2.Text);
                comboBox_Filter.Items.Add(textBox_Nama2.Text);

            }
            else
            {
                MessageBox.Show("Category Sudah Ada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
               
        }
        int count = 5;
        string cek = "";
        private void btn_RemoveCategory_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Items.Remove(DGV_Category.SelectedCells[1].Value.ToString());
            comboBox_Category.Items.Remove(DGV_Category.SelectedCells[1].Value.ToString());

            for (int i = dtProdukSimpan.Rows.Count - 1; i >= 0; i--)
            {
                if (dtProdukSimpan.Rows[i][4].ToString() == DGV_Category.SelectedCells[0].Value.ToString())
                {
                    dtProdukSimpan.Rows.RemoveAt(i);
                }
            }
            if (DGV_Category.SelectedCells[0].Value.ToString().Substring(1) == count.ToString())
            {
                count--;
            }
            foreach (DataRow b in dtCategory.Rows)
            {
                if (b[1].ToString() == cek)
                {
                    dtCategory.Rows.Remove(b);
                    break;
                }
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {

        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            dtProdukSimpan.Rows.RemoveAt(DGV_Product.CurrentCell.RowIndex);
        }

        private void textBox_Harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
