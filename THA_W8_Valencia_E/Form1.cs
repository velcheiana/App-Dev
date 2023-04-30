using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace THA_W8_Valencia_E
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=Fernandut99#;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);
            panel1.Visible= false;
            panel2.Visible= false;
        }

        private void pLAYERDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt1 = new DataTable();
            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt1);
            comboBox_Team.DataSource = dt1;
            comboBox_Team.DisplayMember = "team_name";
            comboBox_Team.ValueMember = "team_id";
            comboBox_Team.Visible = true;
            comboBox_Team.Text = "";
            comboBox_Player.Text = "";
            label1.Text = "_____";
            label2.Text = "_____";
            label3.Text = "_____";
            label4.Text = "_____";
            label5.Text = "_____";
            label6.Text = "_____";
            label7.Text = "_____";
            label8.Text = "_____";
            label9.Text = "_____";
            panel1.Visible = true;
            panel2.Visible = false;
        }

        string simpan;
        private void comboBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt2 = new DataTable();
            simpan = comboBox_Team.SelectedValue.ToString();
            sqlQuery = $"SELECT player_name, player_id FROM player WHERE player.team_id = '{simpan}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt2);
            comboBox_Player.DisplayMember = "player_name";
            comboBox_Player.ValueMember = "player_id";
            comboBox_Player.DataSource = dt2;
        }
        
        string simpan2;
        string simpan3;
        private void comboBox_Player_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt3 = new DataTable();
            simpan = comboBox_Player.GetItemText(comboBox_Player.SelectedItem).ToString();
            simpan2 = comboBox_Team.GetItemText(comboBox_Team.SelectedItem).ToString();
            sqlQuery = $"SELECT p.player_name, t.team_name, p.playing_pos, n.nation, p.team_number FROM player p,nationality n,dmatch d,team t WHERE player_name = '{simpan}' AND team_name = '{simpan2}' AND p.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt3);
            label1.Text = dt3.Rows[0][0].ToString();
            label2.Text = dt3.Rows[0][1].ToString();
            label3.Text = dt3.Rows[0][2].ToString();
            label4.Text = dt3.Rows[0][3].ToString();
            label5.Text = dt3.Rows[0][4].ToString();
            dt4 = new DataTable();
            simpan3 = comboBox_Player.GetItemText(comboBox_Player.SelectedItem).ToString();
            sqlQuery = $"SELECT COUNT(if(d.type = 'CR',1,null)) as 'RED CARD', COUNT(if(d.type = 'GO',1,null)) as 'GOALS SCORED', COUNT(if(d.type = 'PM',1,null)) as 'PENALTY MISSED', COUNT(if(d.type = 'CY',1,null)) as 'YELLOW CARD' FROM dmatch d, player p WHERE d.player_id = p.player_id AND p.player_name = '{simpan3}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt4);
            label6.Text = dt4.Rows[0][0].ToString();
            label7.Text = dt4.Rows[0][1].ToString();
            label8.Text = dt4.Rows[0][2].ToString();
            label9.Text = dt4.Rows[0][3].ToString();
        }

        private void sHOWMATCHDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt5 = new DataTable();
            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt5);
            comboBox_chooseTeam.DataSource = dt5;
            comboBox_chooseTeam.DisplayMember = "team_name";
            comboBox_chooseTeam.ValueMember = "team_id";
            comboBox_chooseTeam.Visible = true;
            //comboBox_chooseTeam.Text = "";
            //comboBox_Match.Text = "";
            panel1.Visible = false;
            panel2.Visible = true;
        }

        string simpan4;
        private void comboBox_chooseTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt6 = new DataTable();
            simpan4 = comboBox_chooseTeam.SelectedValue.ToString();
            sqlQuery = $"SELECT match_id FROM `match` where `match`.team_home = '{simpan4}' OR team_away = '{simpan4}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt6);
            comboBox_Match.DisplayMember = "match_id";
            comboBox_Match.ValueMember = "match_id";
            comboBox_Match.DataSource = dt6;
        }

        string simpan5;
        private void comboBox_Match_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt7 = new DataTable();
            //simpan4 = comboBox_chooseTeam.GetItemText(comboBox_chooseTeam.SelectedItem).ToString();
            simpan5 = comboBox_Match.GetItemText(comboBox_Match.SelectedItem).ToString();
            sqlQuery = $"SELECT team_name, player_name,playing_pos FROM player INNER JOIN team ON player.team_id = team.team_id INNER JOIN `match` on player.team_id = `match`.team_home OR player.team_id = `match`.team_away WHERE match_id='{simpan5}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt7);
            dataGridView1.DataSource = dt7;

            dt8 = new DataTable();
            //simpan4 = comboBox_chooseTeam.GetItemText(comboBox_chooseTeam.SelectedItem).ToString();
            simpan5 = comboBox_Match.GetItemText(comboBox_Match.SelectedItem).ToString();
            sqlQuery = $"SELECT t.team_name, p.player_name, if(d.`type`='GO','Goal Scored',if(d.`type`='GW','Own Goal',if(d.`type`='GP','Penalty Goal',if(d.`type`='PM','Penalty Missed',if(d.`type`='CY','Yellow Card','Red Card'))))) as 'type', d.`minute` from dmatch d, player p, team t WHERE t.team_id = d.team_id AND d.player_id = p.player_id AND d.match_id = '{simpan5}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt8);
            dataGridView2.DataSource = dt8;
        }
    }
}
