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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string member = "server=localhost; uid=root; pwd=; database=Perpustakaan";
                string Query = "insert into Perpustakaan.anggota(nama,jenis_kelamin,prodi,fakultas,alamat,no_hp) values('" + this.tbNama.Text + "','" + this.cbKelamin.Text + "','" + this.tbProdi.Text + "','" + this.cbFakultas.Text + "','" + this.tbAlamat.Text + "','" + this.tbNo.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(member);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();  
                MessageBox.Show("Data Telah Disimpan");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tampil tampil = new tampil();
            tampil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tampil tampil = new tampil();
            tampil.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbProdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFakultas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
