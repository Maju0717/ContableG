using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace ContableG
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dtgvLibroD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una nueva conexion a la base de datos
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=contabilidad";
            MySqlConnection conexion = new MySqlConnection(connStr);
            conexion.Open();
            

            // Busca la información guardada en la base de datos
            string sql = "SELECT * FROM contabilidad.asientos";

            
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            MySqlDataReader rdr = cmd.ExecuteReader();
            

            //Muestra los datos que tiene en la base de datos 
            while (rdr.Read())
            {
            
                int n = dtgvLibroD.Rows.Add();
                dtgvLibroD.Rows[n].Cells[0].Value = rdr[0];
                dtgvLibroD.Rows[n].Cells[1].Value = rdr[1];
                dtgvLibroD.Rows[n].Cells[2].Value = rdr[2];
                dtgvLibroD.Rows[n].Cells[3].Value = rdr[3]; 
                dtgvLibroD.Rows[n].Cells[4].Value = rdr[4];
                dtgvLibroD.Rows[n].Cells[5].Value = rdr[5];
                dtgvLibroD.Rows[n].Cells[6].Value = rdr[6];
                n++;
                
            }
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { //Botón borrar un asiento

            // Crea una nueva conexion a la base de datos
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=contabilidad";
            MySqlConnection conexion = new MySqlConnection(connStr);
            conexion.Open();

            // Borra UN asiento de la tabla
            string query = "DELETE FROM contabilidad.asientos WHERE id = '" + textBox1.Text + "'";

            MySqlCommand comando = new MySqlCommand(query, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("La linea nº" + textBox1.Text + "fue eliminada");

            
            dtgvLibroD.Rows.Clear();
            //dtgvLibroD.Refresh();

            this.refresh();

            //Limpiar campo donde se coloco la linea a borrar
            textBox1.Text =""; 
        }

        private void button3_Click(object sender, EventArgs e)
        {//Botón Borrar Todos los Asientos

            // Crea una nueva conexion a la base de datos
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=contabilidad";
            MySqlConnection conexion = new MySqlConnection(connStr);
            conexion.Open();

            // Borra todos los datos de la tabla
            string query = " DELETE FROM contabilidad.asientos";

            MySqlCommand comando = new MySqlCommand(query,conexion);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Todos los asientos fueron borrados");

            dtgvLibroD.Rows.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void refresh()
        {
            // Crea una nueva conexion a la base de datos
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=contabilidad";
            MySqlConnection conexion = new MySqlConnection(connStr);
            conexion.Open();
            

            // Busca la información guardada en la base de datos
            string sql = "SELECT * FROM contabilidad.asientos";

            
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            MySqlDataReader rdr = cmd.ExecuteReader();
            

            //Muestra los datos que tiene en la base de datos 
            while (rdr.Read())
            {
            
                int n = dtgvLibroD.Rows.Add();
                dtgvLibroD.Rows[n].Cells[0].Value = rdr[0];
                dtgvLibroD.Rows[n].Cells[1].Value = rdr[1];
                dtgvLibroD.Rows[n].Cells[2].Value = rdr[2];
                dtgvLibroD.Rows[n].Cells[3].Value = rdr[3]; 
                dtgvLibroD.Rows[n].Cells[4].Value = rdr[4];
                dtgvLibroD.Rows[n].Cells[5].Value = rdr[5];
                dtgvLibroD.Rows[n].Cells[6].Value = rdr[6];
                n++;
                
            }

            conexion.Close();
        }
    }
}
