namespace THA_W8_Valencia_E
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pLAYERDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWMATCHDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_yellowCard = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Team = new System.Windows.Forms.ComboBox();
            this.comboBox_Player = new System.Windows.Forms.ComboBox();
            this.label_chooseTeam = new System.Windows.Forms.Label();
            this.label_choosePlayer = new System.Windows.Forms.Label();
            this.label_playerName = new System.Windows.Forms.Label();
            this.label_playerTeam = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.label_nationality = new System.Windows.Forms.Label();
            this.label_playingPos = new System.Windows.Forms.Label();
            this.label_redCard = new System.Windows.Forms.Label();
            this.label_goalsScored = new System.Windows.Forms.Label();
            this.label_Penalty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_chooseTeam = new System.Windows.Forms.ComboBox();
            this.comboBox_Match = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_team = new System.Windows.Forms.Label();
            this.label_Match = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLAYERDATAToolStripMenuItem,
            this.sHOWMATCHDETAILSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pLAYERDATAToolStripMenuItem
            // 
            this.pLAYERDATAToolStripMenuItem.Name = "pLAYERDATAToolStripMenuItem";
            this.pLAYERDATAToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.pLAYERDATAToolStripMenuItem.Text = "PLAYER DATA";
            this.pLAYERDATAToolStripMenuItem.Click += new System.EventHandler(this.pLAYERDATAToolStripMenuItem_Click);
            // 
            // sHOWMATCHDETAILSToolStripMenuItem
            // 
            this.sHOWMATCHDETAILSToolStripMenuItem.Name = "sHOWMATCHDETAILSToolStripMenuItem";
            this.sHOWMATCHDETAILSToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.sHOWMATCHDETAILSToolStripMenuItem.Text = "SHOW MATCH DETAILS";
            this.sHOWMATCHDETAILSToolStripMenuItem.Click += new System.EventHandler(this.sHOWMATCHDETAILSToolStripMenuItem_Click);
            // 
            // label_yellowCard
            // 
            this.label_yellowCard.AutoSize = true;
            this.label_yellowCard.Location = new System.Drawing.Point(0, 269);
            this.label_yellowCard.Name = "label_yellowCard";
            this.label_yellowCard.Size = new System.Drawing.Size(69, 13);
            this.label_yellowCard.TabIndex = 13;
            this.label_yellowCard.Text = "Yellow Card: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "_____";
            // 
            // comboBox_Team
            // 
            this.comboBox_Team.FormattingEnabled = true;
            this.comboBox_Team.Location = new System.Drawing.Point(43, 15);
            this.comboBox_Team.Name = "comboBox_Team";
            this.comboBox_Team.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Team.TabIndex = 1;
            this.comboBox_Team.SelectedIndexChanged += new System.EventHandler(this.comboBox_Team_SelectedIndexChanged);
            // 
            // comboBox_Player
            // 
            this.comboBox_Player.FormattingEnabled = true;
            this.comboBox_Player.Location = new System.Drawing.Point(319, 15);
            this.comboBox_Player.Name = "comboBox_Player";
            this.comboBox_Player.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Player.TabIndex = 2;
            this.comboBox_Player.SelectedIndexChanged += new System.EventHandler(this.comboBox_Player_SelectedIndexChanged);
            // 
            // label_chooseTeam
            // 
            this.label_chooseTeam.AutoSize = true;
            this.label_chooseTeam.Location = new System.Drawing.Point(0, 18);
            this.label_chooseTeam.Name = "label_chooseTeam";
            this.label_chooseTeam.Size = new System.Drawing.Size(37, 13);
            this.label_chooseTeam.TabIndex = 3;
            this.label_chooseTeam.Text = "Team:";
            // 
            // label_choosePlayer
            // 
            this.label_choosePlayer.AutoSize = true;
            this.label_choosePlayer.Location = new System.Drawing.Point(271, 18);
            this.label_choosePlayer.Name = "label_choosePlayer";
            this.label_choosePlayer.Size = new System.Drawing.Size(42, 13);
            this.label_choosePlayer.TabIndex = 4;
            this.label_choosePlayer.Text = "Player: ";
            // 
            // label_playerName
            // 
            this.label_playerName.AutoSize = true;
            this.label_playerName.Location = new System.Drawing.Point(0, 67);
            this.label_playerName.Name = "label_playerName";
            this.label_playerName.Size = new System.Drawing.Size(70, 13);
            this.label_playerName.TabIndex = 5;
            this.label_playerName.Text = "Player Name:";
            // 
            // label_playerTeam
            // 
            this.label_playerTeam.AutoSize = true;
            this.label_playerTeam.Location = new System.Drawing.Point(0, 92);
            this.label_playerTeam.Name = "label_playerTeam";
            this.label_playerTeam.Size = new System.Drawing.Size(69, 13);
            this.label_playerTeam.TabIndex = 6;
            this.label_playerTeam.Text = "Player Team:";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(0, 118);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(50, 13);
            this.label_position.TabIndex = 7;
            this.label_position.Text = "Position: ";
            // 
            // label_nationality
            // 
            this.label_nationality.AutoSize = true;
            this.label_nationality.Location = new System.Drawing.Point(0, 142);
            this.label_nationality.Name = "label_nationality";
            this.label_nationality.Size = new System.Drawing.Size(62, 13);
            this.label_nationality.TabIndex = 8;
            this.label_nationality.Text = "Nationality: ";
            // 
            // label_playingPos
            // 
            this.label_playingPos.AutoSize = true;
            this.label_playingPos.Location = new System.Drawing.Point(0, 167);
            this.label_playingPos.Name = "label_playingPos";
            this.label_playingPos.Size = new System.Drawing.Size(68, 13);
            this.label_playingPos.TabIndex = 9;
            this.label_playingPos.Text = "Playing Pos: ";
            // 
            // label_redCard
            // 
            this.label_redCard.AutoSize = true;
            this.label_redCard.Location = new System.Drawing.Point(0, 193);
            this.label_redCard.Name = "label_redCard";
            this.label_redCard.Size = new System.Drawing.Size(55, 13);
            this.label_redCard.TabIndex = 10;
            this.label_redCard.Text = "Red Card:";
            // 
            // label_goalsScored
            // 
            this.label_goalsScored.AutoSize = true;
            this.label_goalsScored.Location = new System.Drawing.Point(0, 218);
            this.label_goalsScored.Name = "label_goalsScored";
            this.label_goalsScored.Size = new System.Drawing.Size(74, 13);
            this.label_goalsScored.TabIndex = 11;
            this.label_goalsScored.Text = "Goals Scored:";
            // 
            // label_Penalty
            // 
            this.label_Penalty.AutoSize = true;
            this.label_Penalty.Location = new System.Drawing.Point(0, 244);
            this.label_Penalty.Name = "label_Penalty";
            this.label_Penalty.Size = new System.Drawing.Size(84, 13);
            this.label_Penalty.TabIndex = 12;
            this.label_Penalty.Text = "Penalty Missed: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "_____";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "_____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "_____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "_____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "_____";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "_____";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "_____";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "_____";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_yellowCard);
            this.panel1.Controls.Add(this.label_Penalty);
            this.panel1.Controls.Add(this.label_goalsScored);
            this.panel1.Controls.Add(this.label_redCard);
            this.panel1.Controls.Add(this.label_playingPos);
            this.panel1.Controls.Add(this.label_nationality);
            this.panel1.Controls.Add(this.label_position);
            this.panel1.Controls.Add(this.label_playerTeam);
            this.panel1.Controls.Add(this.label_playerName);
            this.panel1.Controls.Add(this.label_choosePlayer);
            this.panel1.Controls.Add(this.label_chooseTeam);
            this.panel1.Controls.Add(this.comboBox_Player);
            this.panel1.Controls.Add(this.comboBox_Team);
            this.panel1.Location = new System.Drawing.Point(27, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 400);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label_Match);
            this.panel2.Controls.Add(this.label_team);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.comboBox_Match);
            this.panel2.Controls.Add(this.comboBox_chooseTeam);
            this.panel2.Location = new System.Drawing.Point(12, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 351);
            this.panel2.TabIndex = 23;
            // 
            // comboBox_chooseTeam
            // 
            this.comboBox_chooseTeam.FormattingEnabled = true;
            this.comboBox_chooseTeam.Location = new System.Drawing.Point(43, 15);
            this.comboBox_chooseTeam.Name = "comboBox_chooseTeam";
            this.comboBox_chooseTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBox_chooseTeam.TabIndex = 0;
            this.comboBox_chooseTeam.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseTeam_SelectedIndexChanged);
            // 
            // comboBox_Match
            // 
            this.comboBox_Match.FormattingEnabled = true;
            this.comboBox_Match.Location = new System.Drawing.Point(228, 15);
            this.comboBox_Match.Name = "comboBox_Match";
            this.comboBox_Match.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Match.TabIndex = 1;
            this.comboBox_Match.SelectedIndexChanged += new System.EventHandler(this.comboBox_Match_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 226);
            this.dataGridView1.TabIndex = 2;
            // 
            // label_team
            // 
            this.label_team.AutoSize = true;
            this.label_team.Location = new System.Drawing.Point(3, 18);
            this.label_team.Name = "label_team";
            this.label_team.Size = new System.Drawing.Size(40, 13);
            this.label_team.TabIndex = 3;
            this.label_team.Text = "Team: ";
            // 
            // label_Match
            // 
            this.label_Match.AutoSize = true;
            this.label_Match.Location = new System.Drawing.Point(182, 18);
            this.label_Match.Name = "label_Match";
            this.label_Match.Size = new System.Drawing.Size(40, 13);
            this.label_Match.TabIndex = 4;
            this.label_Match.Text = "Match:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(353, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(408, 226);
            this.dataGridView2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pLAYERDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWMATCHDETAILSToolStripMenuItem;
        private System.Windows.Forms.Label label_yellowCard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Team;
        private System.Windows.Forms.ComboBox comboBox_Player;
        private System.Windows.Forms.Label label_chooseTeam;
        private System.Windows.Forms.Label label_choosePlayer;
        private System.Windows.Forms.Label label_playerName;
        private System.Windows.Forms.Label label_playerTeam;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_nationality;
        private System.Windows.Forms.Label label_playingPos;
        private System.Windows.Forms.Label label_redCard;
        private System.Windows.Forms.Label label_goalsScored;
        private System.Windows.Forms.Label label_Penalty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_Match;
        private System.Windows.Forms.ComboBox comboBox_chooseTeam;
        private System.Windows.Forms.Label label_team;
        private System.Windows.Forms.Label label_Match;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

