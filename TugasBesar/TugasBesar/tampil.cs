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

namespace TugasBesar
{
    public partial class tampil : Form
    {

        string member = "server=localhost; uid=root; pwd=; database=Perpustakaan";

        MySqlConnection koneksi;

        MySqlCommand query;

        public void DaftarMember()
        {
            koneksi = new MySqlConnection(member);

            DataSet ds;

            try
            {
                ds = new DataSet();
                koneksi.Open();
                query = new MySqlCommand();
                query.Connection = koneksi;
                query.CommandType = CommandType.Text;
                query.CommandText = "select * from anggota";
                MySqlDataAdapter dt = new MySqlDataAdapter(query);
                dt.Fill(ds, "anggota");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "anggota";
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        public tampil()
        {
            InitializeComponent();
        }

        private void tampil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DaftarMember();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
            this.Hide();
        }
    }
}
