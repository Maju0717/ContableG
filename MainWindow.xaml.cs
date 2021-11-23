using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ContableG
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Proyecto: Contabilidad
        Integrantes:
        Bustos Nahuel
        Espinoza Maria Julia
        Maya Pablo
        Soliz Nicolas
        Vinci Juan */


        public MainWindow()
        {
            InitializeComponent();
        }


        //Ver libro diario
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Abre una nueva pantalla
            Form1 pantalla3 = new Form1();
            pantalla3.Show();

        }

        //Nuevo ingreso a Libro Diario
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Abre una nueva pantalla
            Home pantalla2 = new Home();
            pantalla2.Show();

        }

        //Tiene que hacer el libro mayor y mostrarlo 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Form2 pantalla4 = new Form2();
            pantalla4.Show();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
