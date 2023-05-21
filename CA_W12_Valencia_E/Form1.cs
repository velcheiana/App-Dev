using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace CA_W12_Valencia_E
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        string connectionString;
        string sqlQuery;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt6 = new DataTable();
        DataTable dt7 = new DataTable();
        DataTable dt8 = new DataTable();
        DataTable dt9 = new DataTable();
        DataTable dt10 = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void updateManager()
        {
            dt8 = new DataTable();
            try
            {
                string simpan3 = comboBox1.GetItemText(comboBox1.SelectedItem).ToString();
                string command = $"select m.manager_id, m.manager_name, t.team_name, m.birthdate, n.nation from manager m left join team t on m.manager_id = t.manager_id left join nationality n on m.nationality_id = n.nationality_id where team_name = '{simpan3}';";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt8);
                dataGridView1.DataSource = dt8;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dt9 = new DataTable();
            try
            {
                string command = $"select m.manager_id, m.manager_name, n.nation, m.birthdate from manager m left join nationality n on m.nationality_id = n.nationality_id where working = '0';";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt9);
                dataGridView2.DataSource = dt9;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateDGV3()
        {
            dt10 = new DataTable();
            try
            {
                string simpan2 = comboBox2.GetItemText(comboBox2.SelectedItem).ToString();
                sqlQuery = $"select p.player_name, n.nation, p.playing_pos, p.team_number, p.height, p.weight, p.birthdate from player p left join nationality n on p.nationality_id = n.nationality_id left join team t on p.team_id = t.team_id where team_name = '{simpan2}' and status = '1';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt10);
                dataGridView3.DataSource = dt10;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=Fernandut99#;database=premier_league";
            sqlConnection = new MySqlConnection(connectionString);
            dt1 = new DataTable();
            sqlQuery = "SELECT nation, nationality_id FROM nationality;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt1);
            comboBox_Nationality.DataSource = dt1;
            comboBox_Nationality.DisplayMember = "nation";
            comboBox_Nationality.ValueMember = "nationality_id";

            dt2 = new DataTable();
            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt2);
            comboBox_teamName.DataSource = dt2;
            comboBox_teamName.DisplayMember = "team_name";
            comboBox_teamName.ValueMember = "team_id";

            dt3 = new DataTable();
            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt3);
            comboBox1.DataSource = dt3;
            comboBox1.DisplayMember = "team_name";
            comboBox1.ValueMember = "team_id";

            dt6 = new DataTable();
            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt6);
            comboBox2.DataSource = dt6;
            comboBox2.DisplayMember = "team_name";
            comboBox2.ValueMember = "team_id";

            dt5 = new DataTable();
            try
            {
                string command = $"select m.manager_id, m.manager_name, n.nation, m.birthdate from manager m left join nationality n on m.nationality_id = n.nationality_id where working = '0';";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt5);
                dataGridView2.DataSource = dt5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_addPlayer_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string teamNum = textBox_teamNumber.Text;
            string nationality = comboBox_Nationality.SelectedValue.ToString();
            string position = textBox_Position.Text;
            string height = textBox_Height.Text;
            string weight = textBox_Weight.Text;
            string birthdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string teamName = comboBox_teamName.SelectedValue.ToString();
            string playerId = textBox_PlayerID.Text;
            string command = $"insert into player values('{playerId}','{teamNum}','{name}','{nationality}','{position}','{height}','{weight}','{birthdate}','{teamName}', '1', '0');";
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt4 = new DataTable();
            try
            {
                string simpan = comboBox1.GetItemText(comboBox1.SelectedItem).ToString();
                string command = $"select m.manager_id, m.manager_name, t.team_name, m.birthdate, n.nation from manager m left join team t on m.manager_id = t.manager_id left join nationality n on m.nationality_id = n.nationality_id where team_name = '{simpan}';";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt4);
                dataGridView1.DataSource = dt4;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt7 = new DataTable();
            try
            {
                string simpan2 = comboBox2.GetItemText(comboBox2.SelectedItem).ToString();
                string command = $"select p.player_name, n.nation, p.playing_pos, p.team_number, p.height, p.weight, p.birthdate from player p left join nationality n on p.nationality_id = n.nationality_id left join team t on p.team_id = t.team_id where team_name = '{simpan2}' and status = '1';";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt7);
                dataGridView3.DataSource = dt7;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string dgv2 = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string command = $"update team set manager_id = '" + dgv2 + "' where team_id = '" + comboBox1.SelectedValue + "';";
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            string dgv1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string command2 = $"update manager set working = 0 where manager_id = '" + dgv1 + "';";
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(command2, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            string command3 = $"update manager set working = 1 where manager_id =  '" + dgv2 + "'; ";
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(command3, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                updateManager();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count >= 12)
            {
                int rowIndex = dataGridView3.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView3.Rows[rowIndex];
                string value = row.Cells[0].Value.ToString();
                //MessageBox.Show(value.ToString());
                string command = $"update player set status = '0' where player_name = '{value}';";
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new MySqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    updateDGV3();
                }
            }
            else
            {
                MessageBox.Show("Total number of players must be greater than 11", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
