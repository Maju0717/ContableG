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
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bagregar_Click(object sender, EventArgs e)
        {

            string connStr = "server=127.0.0.1;uid=root;pwd=;database=contabilidad";
            MySqlConnection conexion = new MySqlConnection(connStr);
            conexion.Open();

            // Ingresa valores a la db
            string query = "INSERT INTO asientos(fecha, codigo, cuenta, descripcion, debe, haber) VALUES (@fecha, @codigo, @cuenta, @descripcion, @debe, @haber)";

            MySqlCommand comando = new MySqlCommand(query, conexion);

            // Agrega estos valores desde la interfaz a la db
            comando.Parameters.AddWithValue("@fecha", textfecha.Text);
            comando.Parameters.AddWithValue("@codigo", textcodigo.Text);
            comando.Parameters.AddWithValue("@cuenta", textcuenta.Text);
            comando.Parameters.AddWithValue("@descripcion", textdescripcion.Text);
            comando.Parameters.AddWithValue("@debe", textdebe.Text);
            comando.Parameters.AddWithValue("@haber", texthaber.Text);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Asiento ingresado");

            //Limpia los txt
            textfecha.Text = "";
            textcodigo.Text = "";
            textcuenta.Text = "";
            textdescripcion.Text = "";
            textdebe.Text = "";
            texthaber.Text = "";

            
            dtgvLibrodiarios.Rows.Clear();
            this.refresh();

        }

        private void textfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvLibrodiarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ldescripcion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

                int n = dtgvLibrodiarios.Rows.Add();
                dtgvLibrodiarios.Rows[n].Cells[0].Value = rdr[0];
                dtgvLibrodiarios.Rows[n].Cells[1].Value = rdr[1];
                dtgvLibrodiarios.Rows[n].Cells[2].Value = rdr[2];
                dtgvLibrodiarios.Rows[n].Cells[3].Value = rdr[3];
                dtgvLibrodiarios.Rows[n].Cells[4].Value = rdr[4];
                dtgvLibrodiarios.Rows[n].Cells[5].Value = rdr[5];
                dtgvLibrodiarios.Rows[n].Cells[6].Value = rdr[6];
                n++;

            }

            conexion.Close();
            
                

        }

        private void lhaber_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
