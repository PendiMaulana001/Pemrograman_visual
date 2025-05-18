namespace SistemTokoPm
{
    partial class FormDaftarGaji
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtGajiPokok = new System.Windows.Forms.TextBox();
            this.txtTunjangan = new System.Windows.Forms.TextBox();
            this.txtPotongan = new System.Windows.Forms.TextBox();
            this.txtTotalGaji = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAFTAR GAJI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Karyawan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potongan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tunjangan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Gaji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gaji Pokok";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(226, 99);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(231, 26);
            this.txtNama.TabIndex = 6;
            // 
            // txtGajiPokok
            // 
            this.txtGajiPokok.Location = new System.Drawing.Point(226, 140);
            this.txtGajiPokok.Name = "txtGajiPokok";
            this.txtGajiPokok.Size = new System.Drawing.Size(231, 26);
            this.txtGajiPokok.TabIndex = 7;
            // 
            // txtTunjangan
            // 
            this.txtTunjangan.Location = new System.Drawing.Point(226, 181);
            this.txtTunjangan.Name = "txtTunjangan";
            this.txtTunjangan.Size = new System.Drawing.Size(231, 26);
            this.txtTunjangan.TabIndex = 8;
            // 
            // txtPotongan
            // 
            this.txtPotongan.Location = new System.Drawing.Point(226, 220);
            this.txtPotongan.Name = "txtPotongan";
            this.txtPotongan.Size = new System.Drawing.Size(231, 26);
            this.txtPotongan.TabIndex = 9;
            // 
            // txtTotalGaji
            // 
            this.txtTotalGaji.Location = new System.Drawing.Point(226, 265);
            this.txtTotalGaji.Name = "txtTotalGaji";
            this.txtTotalGaji.Size = new System.Drawing.Size(231, 26);
            this.txtTotalGaji.TabIndex = 10;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(508, 359);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 34);
            this.btnHitung.TabIndex = 11;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(634, 359);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 34);
            this.btnSimpan.TabIndex = 12;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(0, 2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(84, 28);
            this.btnKembali.TabIndex = 13;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FormDaftarGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtTotalGaji);
            this.Controls.Add(this.txtPotongan);
            this.Controls.Add(this.txtTunjangan);
            this.Controls.Add(this.txtGajiPokok);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDaftarGaji";
            this.Text = "FormDaftarGaji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtGajiPokok;
        private System.Windows.Forms.TextBox txtTunjangan;
        private System.Windows.Forms.TextBox txtPotongan;
        private System.Windows.Forms.TextBox txtTotalGaji;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKembali;
    }
}