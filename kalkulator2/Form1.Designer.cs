namespace kalkulator2
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
            this.nilai1 = new System.Windows.Forms.TextBox();
            this.nilai2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_kurang = new System.Windows.Forms.Button();
            this.btn_kali = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nilai1
            // 
            this.nilai1.Location = new System.Drawing.Point(51, 12);
            this.nilai1.Name = "nilai1";
            this.nilai1.Size = new System.Drawing.Size(106, 20);
            this.nilai1.TabIndex = 0;
            // 
            // nilai2
            // 
            this.nilai2.Location = new System.Drawing.Point(51, 38);
            this.nilai2.Name = "nilai2";
            this.nilai2.Size = new System.Drawing.Size(106, 20);
            this.nilai2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nilai 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nilai 2";
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(51, 64);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(22, 23);
            this.btn_tambah.TabIndex = 4;
            this.btn_tambah.Text = "+";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_kurang
            // 
            this.btn_kurang.Location = new System.Drawing.Point(79, 64);
            this.btn_kurang.Name = "btn_kurang";
            this.btn_kurang.Size = new System.Drawing.Size(22, 23);
            this.btn_kurang.TabIndex = 5;
            this.btn_kurang.Text = "-";
            this.btn_kurang.UseVisualStyleBackColor = true;
            this.btn_kurang.Click += new System.EventHandler(this.btn_kurang_Click);
            // 
            // btn_kali
            // 
            this.btn_kali.Location = new System.Drawing.Point(107, 64);
            this.btn_kali.Name = "btn_kali";
            this.btn_kali.Size = new System.Drawing.Size(22, 23);
            this.btn_kali.TabIndex = 6;
            this.btn_kali.Text = "X";
            this.btn_kali.UseVisualStyleBackColor = true;
            this.btn_kali.Click += new System.EventHandler(this.btn_kali_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(135, 64);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(22, 23);
            this.btn_hapus.TabIndex = 7;
            this.btn_hapus.Text = "/";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // hasil
            // 
            this.hasil.Location = new System.Drawing.Point(51, 93);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(106, 20);
            this.hasil.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hasil";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(163, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(36, 101);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 125);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_kali);
            this.Controls.Add(this.btn_kurang);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nilai2);
            this.Controls.Add(this.nilai1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jefri tri muji pangestu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nilai1;
        private System.Windows.Forms.TextBox nilai2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_kurang;
        private System.Windows.Forms.Button btn_kali;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clear;
    }
}

