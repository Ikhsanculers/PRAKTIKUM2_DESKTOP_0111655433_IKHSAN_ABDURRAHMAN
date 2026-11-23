using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;

namespace PRAKTIKUM2_DESKTOP_0111655433_IKHSAN_ABDURRAHMAN
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=db_kopi_gudang;Username=root;Password=;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tb_bahan_baku";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["kode_bahan"].ToString(),
                        reader["nama_bahan"].ToString(),
                        reader["kategori"].ToString(),
                        reader["stok"].ToString(),
                        reader["satuan"].ToString(),
                        reader["harga_satuan"].ToString(),
                        reader["batas_minimum"].ToString());
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO `tb_bahan_baku` (kode_bahan, nama_bahan, kategori, stok, satuan, harga_satuan, batas_minimum) VALUES (@kode_bahan, @nama_bahan, @kategori, @stok, @satuan, @harga_satuan, @batas_minimum)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kode_bahan", txt_kode.Text.);
                }
            }

            
        }
    }
}

