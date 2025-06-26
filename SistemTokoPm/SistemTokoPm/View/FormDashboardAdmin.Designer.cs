namespace SistemTokoPm
{
    partial class FormDashboardAdmin
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
            this.btnDaftarHadir = new System.Windows.Forms.Button();
            this.btnDataBarang = new System.Windows.Forms.Button();
            this.btnTambahBarang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnDaftarHadir);
            this.panel1.Controls.Add(this.btnDataBarang);
            this.panel1.Controls.Add(this.btnTambahBarang);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 445);
            this.panel1.TabIndex = 0;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(22, 252);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(140, 31);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnDaftarHadir
            // 
            this.btnDaftarHadir.Location = new System.Drawing.Point(22, 200);
            this.btnDaftarHadir.Name = "btnDaftarHadir";
            this.btnDaftarHadir.Size = new System.Drawing.Size(142, 35);
            this.btnDaftarHadir.TabIndex = 4;
            this.btnDaftarHadir.Text = "Daftar Hadir";
            this.btnDaftarHadir.UseVisualStyleBackColor = true;
            this.btnDaftarHadir.Click += new System.EventHandler(this.btnDaftarHadir_Click);
            // 
            // btnDataBarang
            // 
            this.btnDataBarang.Location = new System.Drawing.Point(22, 151);
            this.btnDataBarang.Name = "btnDataBarang";
            this.btnDataBarang.Size = new System.Drawing.Size(140, 35);
            this.btnDataBarang.TabIndex = 4;
            this.btnDataBarang.Text = "Data Barang";
            this.btnDataBarang.UseVisualStyleBackColor = true;
            this.btnDataBarang.Click += new System.EventHandler(this.btnDataBarang_Click);
            // 
            // btnTambahBarang
            // 
            this.btnTambahBarang.Location = new System.Drawing.Point(22, 98);
            this.btnTambahBarang.Name = "btnTambahBarang";
            this.btnTambahBarang.Size = new System.Drawing.Size(142, 35);
            this.btnTambahBarang.TabIndex = 3;
            this.btnTambahBarang.Text = "Tambah Barang";
            this.btnTambahBarang.UseVisualStyleBackColor = true;
            this.btnTambahBarang.Click += new System.EventHandler(this.btnTambahBarang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(196, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 100);
            this.panel2.TabIndex = 2;
            // 
            // FormDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDashboardAdmin";
            this.Text = "FormDashboardAdmin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDaftarHadir;
        private System.Windows.Forms.Button btnDataBarang;
        private System.Windows.Forms.Button btnTambahBarang;
        private System.Windows.Forms.Button btnKeluar;
    }
}