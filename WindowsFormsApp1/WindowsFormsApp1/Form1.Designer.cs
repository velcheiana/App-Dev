namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mulai = new System.Windows.Forms.Button();
            this.txt_isi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_mulai
            // 
            this.btn_mulai.Location = new System.Drawing.Point(336, 197);
            this.btn_mulai.Name = "btn_mulai";
            this.btn_mulai.Size = new System.Drawing.Size(75, 23);
            this.btn_mulai.TabIndex = 1;
            this.btn_mulai.Text = "Mulai";
            this.btn_mulai.UseVisualStyleBackColor = true;
            this.btn_mulai.Click += new System.EventHandler(this.btn_mulai_Click);
            // 
            // txt_isi
            // 
            this.txt_isi.Location = new System.Drawing.Point(322, 162);
            this.txt_isi.Name = "txt_isi";
            this.txt_isi.Size = new System.Drawing.Size(100, 20);
            this.txt_isi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_isi);
            this.Controls.Add(this.btn_mulai);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mulai;
        private System.Windows.Forms.TextBox txt_isi;
    }
}

