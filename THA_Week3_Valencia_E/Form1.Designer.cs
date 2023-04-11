namespace THA_Week3_Valencia_E
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
            this.btn_nextForm = new System.Windows.Forms.Button();
            this.label_Nama = new System.Windows.Forms.Label();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.label_favArtist = new System.Windows.Forms.Label();
            this.textBox_favArtist = new System.Windows.Forms.TextBox();
            this.checkBox_Valid = new System.Windows.Forms.CheckBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nextForm
            // 
            this.btn_nextForm.Location = new System.Drawing.Point(25, 169);
            this.btn_nextForm.Name = "btn_nextForm";
            this.btn_nextForm.Size = new System.Drawing.Size(196, 47);
            this.btn_nextForm.TabIndex = 0;
            this.btn_nextForm.Text = "Open Next Form";
            this.btn_nextForm.UseVisualStyleBackColor = true;
            this.btn_nextForm.Click += new System.EventHandler(this.btn_nextForm_Click);
            // 
            // label_Nama
            // 
            this.label_Nama.AutoSize = true;
            this.label_Nama.Location = new System.Drawing.Point(22, 23);
            this.label_Nama.Name = "label_Nama";
            this.label_Nama.Size = new System.Drawing.Size(41, 13);
            this.label_Nama.TabIndex = 1;
            this.label_Nama.Text = "Name: ";
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Location = new System.Drawing.Point(122, 20);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nama.TabIndex = 2;
            this.textBox_Nama.TextChanged += new System.EventHandler(this.textBox_Nama_TextChanged);
            // 
            // label_favArtist
            // 
            this.label_favArtist.AutoSize = true;
            this.label_favArtist.Location = new System.Drawing.Point(22, 57);
            this.label_favArtist.Name = "label_favArtist";
            this.label_favArtist.Size = new System.Drawing.Size(94, 13);
            this.label_favArtist.TabIndex = 3;
            this.label_favArtist.Text = "My Favorite Artist: ";
            // 
            // textBox_favArtist
            // 
            this.textBox_favArtist.Location = new System.Drawing.Point(122, 54);
            this.textBox_favArtist.Name = "textBox_favArtist";
            this.textBox_favArtist.Size = new System.Drawing.Size(100, 20);
            this.textBox_favArtist.TabIndex = 4;
            // 
            // checkBox_Valid
            // 
            this.checkBox_Valid.AutoSize = true;
            this.checkBox_Valid.Location = new System.Drawing.Point(25, 93);
            this.checkBox_Valid.Name = "checkBox_Valid";
            this.checkBox_Valid.Size = new System.Drawing.Size(196, 17);
            this.checkBox_Valid.TabIndex = 5;
            this.checkBox_Valid.Text = "All of the content i put above is true!";
            this.checkBox_Valid.UseVisualStyleBackColor = true;
            this.checkBox_Valid.CheckedChanged += new System.EventHandler(this.checkBox_Agree_checkedChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(25, 131);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.checkBox_Valid);
            this.Controls.Add(this.textBox_favArtist);
            this.Controls.Add(this.label_favArtist);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.label_Nama);
            this.Controls.Add(this.btn_nextForm);
            this.Name = "Form1";
            this.Text = "Main Window Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nextForm;
        private System.Windows.Forms.Label label_Nama;
        private System.Windows.Forms.TextBox textBox_Nama;
        private System.Windows.Forms.Label label_favArtist;
        private System.Windows.Forms.TextBox textBox_favArtist;
        private System.Windows.Forms.CheckBox checkBox_Valid;
        private System.Windows.Forms.Button btn_Submit;
    }
}

