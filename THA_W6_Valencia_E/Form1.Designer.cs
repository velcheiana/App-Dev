namespace THA_W6_Valencia_E
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
            this.lbl_Wordle = new System.Windows.Forms.Label();
            this.lbl_Guess = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Wordle
            // 
            this.lbl_Wordle.AutoSize = true;
            this.lbl_Wordle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Wordle.Location = new System.Drawing.Point(68, 28);
            this.lbl_Wordle.Name = "lbl_Wordle";
            this.lbl_Wordle.Size = new System.Drawing.Size(98, 24);
            this.lbl_Wordle.TabIndex = 0;
            this.lbl_Wordle.Text = "WORDLE";
            // 
            // lbl_Guess
            // 
            this.lbl_Guess.AutoSize = true;
            this.lbl_Guess.Location = new System.Drawing.Point(40, 64);
            this.lbl_Guess.Name = "lbl_Guess";
            this.lbl_Guess.Size = new System.Drawing.Size(158, 13);
            this.lbl_Guess.TabIndex = 1;
            this.lbl_Guess.Text = "Set How Much You Can Guess!";
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(72, 91);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(100, 20);
            this.textBox_Input.TabIndex = 2;
            this.textBox_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Input_KeyPress);
            // 
            // button_Play
            // 
            this.button_Play.Location = new System.Drawing.Point(82, 127);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(75, 23);
            this.button_Play.TabIndex = 3;
            this.button_Play.Text = "Play!";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 185);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.lbl_Guess);
            this.Controls.Add(this.lbl_Wordle);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Wordle;
        private System.Windows.Forms.Label lbl_Guess;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button button_Play;
    }
}

