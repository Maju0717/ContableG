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


namespace ContableG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgvLibroMayor.Rows.Clear();

            // Crea una nueva conexion a la base de datos
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=contabilidad";
            MySqlConnection conexion = new MySqlConnection(connStr);
            conexion.Open();

            // Busca todos los valores de la db que coinciden con el numero de cuenta ingresado por el usuario
            string query = "SELECT * FROM contabilidad.asientos WHERE codigo = '" + textIngcodigo.Text + "'";

            // Executa reader
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader rdr = cmd.ExecuteReader();

            //Muestra los datos que tiene en la base de datos 
            while (rdr.Read())
            {

                int n = dtgvLibroMayor.Rows.Add();
                dtgvLibroMayor.Rows[n].Cells[0].Value = rdr[0];
                dtgvLibroMayor.Rows[n].Cells[1].Value = rdr[1];
                dtgvLibroMayor.Rows[n].Cells[2].Value = rdr[2];
                dtgvLibroMayor.Rows[n].Cells[3].Value = rdr[3];
                dtgvLibroMayor.Rows[n].Cells[4].Value = rdr[4];
                dtgvLibroMayor.Rows[n].Cells[5].Value = rdr[5];
                dtgvLibroMayor.Rows[n].Cells[6].Value = rdr[6];
                n++;

            }

            conexion.Close();

            

            

        }

        private void textfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textsaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sumaDebe = 0;
            foreach (DataGridViewRow row in dtgvLibroMayor.Rows)
            {
                sumaDebe += Convert.ToDouble(row.Cells["debe"].Value);
            }

            double sumaHaber = 0;
            foreach (DataGridViewRow row in dtgvLibroMayor.Rows)
            {
                sumaHaber += Convert.ToDouble(row.Cells["haber"].Value);
            }

            textsaldo.Text = Convert.ToString(sumaDebe - sumaHaber);

            //limpia el campo donde se coloca el numero de linea
            textIngcodigo.Text = "";
        }
    }
}
