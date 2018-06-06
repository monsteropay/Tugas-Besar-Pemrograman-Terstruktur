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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string member = "server=localhost; uid=root; pwd=; database=Perpustakaan";
                string Query = "update Perpustakaan.anggota set id='" + this.tbId.Text + "',nama='" + this.tbNama.Text + "',jenis_kelamin='" + this.cbKelamin.Text + "',prodi='" + this.tbProdi.Text + "',fakultas='" + this.cbFakultas.Text + "',alamat='" + this.tbAlamat.Text + "',no_hp='" + this.tbNo.Text + "' where id='" + this.tbId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(member);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Telah Diupdate");
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
    }
}
