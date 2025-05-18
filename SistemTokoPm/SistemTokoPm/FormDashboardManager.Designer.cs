namespace SistemTokoPm
{
    partial class FormDashboardManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnDaftarGaji = new System.Windows.Forms.Button();
            this.btnGajiKaryawan = new System.Windows.Forms.Button();
            this.btnDaftarBarang = new System.Windows.Forms.Button();
            this.btnDaftarHadir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDataHadir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnDataHadir);
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnDaftarGaji);
            this.panel1.Controls.Add(this.btnGajiKaryawan);
            this.panel1.Controls.Add(this.btnDaftarBarang);
            this.panel1.Controls.Add(this.btnDaftarHadir);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 461);
            this.panel1.TabIndex = 0;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(25, 367);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(143, 33);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnDaftarGaji
            // 
            this.btnDaftarGaji.Location = new System.Drawing.Point(25, 259);
            this.btnDaftarGaji.Name = "btnDaftarGaji";
            this.btnDaftarGaji.Size = new System.Drawing.Size(143, 33);
            this.btnDaftarGaji.TabIndex = 4;
            this.btnDaftarGaji.Text = "Daftar Gaji";
            this.btnDaftarGaji.UseVisualStyleBackColor = true;
            this.btnDaftarGaji.Click += new System.EventHandler(this.btnDaftarGaji_Click);
            // 
            // btnGajiKaryawan
            // 
            this.btnGajiKaryawan.Location = new System.Drawing.Point(25, 310);
            this.btnGajiKaryawan.Name = "btnGajiKaryawan";
            this.btnGajiKaryawan.Size = new System.Drawing.Size(143, 33);
            this.btnGajiKaryawan.TabIndex = 4;
            this.btnGajiKaryawan.Text = "Data Gaji";
            this.btnGajiKaryawan.UseVisualStyleBackColor = true;
            this.btnGajiKaryawan.Click += new System.EventHandler(this.btnGajiKaryawan_Click);
            // 
            // btnDaftarBarang
            // 
            this.btnDaftarBarang.Location = new System.Drawing.Point(25, 151);
            this.btnDaftarBarang.Name = "btnDaftarBarang";
            this.btnDaftarBarang.Size = new System.Drawing.Size(131, 33);
            this.btnDaftarBarang.TabIndex = 4;
            this.btnDaftarBarang.Text = "Daftar Barang";
            this.btnDaftarBarang.UseVisualStyleBackColor = true;
            this.btnDaftarBarang.Click += new System.EventHandler(this.btnDaftarBarang_Click);
            // 
            // btnDaftarHadir
            // 
            this.btnDaftarHadir.Location = new System.Drawing.Point(25, 99);
            this.btnDaftarHadir.Name = "btnDaftarHadir";
            this.btnDaftarHadir.Size = new System.Drawing.Size(131, 33);
            this.btnDaftarHadir.TabIndex = 3;
            this.btnDaftarHadir.Text = "Daftar Hadir";
            this.btnDaftarHadir.UseVisualStyleBackColor = true;
            this.btnDaftarHadir.Click += new System.EventHandler(this.btnDaftarHadir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // btnDataHadir
            // 
            this.btnDataHadir.Location = new System.Drawing.Point(25, 208);
            this.btnDataHadir.Name = "btnDataHadir";
            this.btnDataHadir.Size = new System.Drawing.Size(143, 29);
            this.btnDataHadir.TabIndex = 2;
            this.btnDataHadir.Text = "Data Hadir";
            this.btnDataHadir.UseVisualStyleBackColor = true;
            this.btnDataHadir.Click += new System.EventHandler(this.btnDataHadir_Click);
            // 
            // FormDashboardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDashboardManager";
            this.Text = "FormDashboardManager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnDaftarGaji;
        private System.Windows.Forms.Button btnGajiKaryawan;
        private System.Windows.Forms.Button btnDaftarBarang;
        private System.Windows.Forms.Button btnDaftarHadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDataHadir;
    }
}