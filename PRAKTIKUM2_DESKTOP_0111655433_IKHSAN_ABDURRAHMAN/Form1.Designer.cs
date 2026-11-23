namespace PRAKTIKUM2_DESKTOP_0111655433_IKHSAN_ABDURRAHMAN
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
            this.txt_kode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_satuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_batas = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.kode_bahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_bahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batas_minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_batas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Produk";
            // 
            // txt_kode
            // 
            this.txt_kode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kode.Location = new System.Drawing.Point(10, 43);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(165, 20);
            this.txt_kode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Produk";
            // 
            // txt_nama
            // 
            this.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nama.Location = new System.Drawing.Point(10, 93);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(165, 20);
            this.txt_nama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Items.AddRange(new object[] {
            "Biji Kopi",
            "Susu & Dairy",
            "Sirup & Pemanis",
            "Kemasan"});
            this.cmb_kategori.Location = new System.Drawing.Point(10, 144);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(165, 21);
            this.cmb_kategori.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok";
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(10, 195);
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(165, 20);
            this.nud_stok.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Satuan";
            // 
            // txt_satuan
            // 
            this.txt_satuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_satuan.Location = new System.Drawing.Point(10, 247);
            this.txt_satuan.Name = "txt_satuan";
            this.txt_satuan.Size = new System.Drawing.Size(165, 20);
            this.txt_satuan.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Harga Satuan";
            // 
            // txt_harga
            // 
            this.txt_harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_harga.Location = new System.Drawing.Point(10, 300);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(165, 20);
            this.txt_harga.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Batas Minimum";
            // 
            // nud_batas
            // 
            this.nud_batas.Location = new System.Drawing.Point(10, 354);
            this.nud_batas.Name = "nud_batas";
            this.nud_batas.Size = new System.Drawing.Size(165, 20);
            this.nud_batas.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_bahan,
            this.nama_bahan,
            this.kategori,
            this.stok,
            this.satuan,
            this.harga_satuan,
            this.batas_minimum,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(202, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(803, 346);
            this.dataGridView1.TabIndex = 14;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(610, 391);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 32);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_update.Location = new System.Drawing.Point(483, 391);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(104, 32);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Lime;
            this.btn_add.Location = new System.Drawing.Point(352, 391);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 32);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // kode_bahan
            // 
            this.kode_bahan.HeaderText = "Kode Produk";
            this.kode_bahan.Name = "kode_bahan";
            // 
            // nama_bahan
            // 
            this.nama_bahan.HeaderText = "Nama Produk";
            this.nama_bahan.Name = "nama_bahan";
            // 
            // kategori
            // 
            this.kategori.HeaderText = "Kategori";
            this.kategori.Name = "kategori";
            // 
            // stok
            // 
            this.stok.HeaderText = "Stok";
            this.stok.Name = "stok";
            // 
            // satuan
            // 
            this.satuan.HeaderText = "Satuan";
            this.satuan.Name = "satuan";
            // 
            // harga_satuan
            // 
            this.harga_satuan.HeaderText = "Harga Satuan";
            this.harga_satuan.Name = "harga_satuan";
            // 
            // batas_minimum
            // 
            this.batas_minimum.HeaderText = "Batas Minimum";
            this.batas_minimum.Name = "batas_minimum";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1011, 457);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nud_batas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_satuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_stok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_kategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_batas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_satuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_batas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_bahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_bahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn batas_minimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

