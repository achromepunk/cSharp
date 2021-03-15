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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionABBDD1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //creamos una cadena de conexion
            string miConexion = ConfigurationManager.ConnectionStrings["ConexionABBDD1.Properties.Settings.MiBaseDeDatos1ConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();

        }

        private void MuestraClientes()
        {
            string consulta = "select * from Cliente";

            //hace falta una estructura especial... un dataTable
            //SqlDataAdapter es una clase sellada leer descripcion

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            //ahora por fin lo almaceno en un datatable

            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();

                //ahora uso el adaptador para rellenar la datatable
                miAdaptadorSql.Fill(clientesTabla);

                //me interesa solo el campo nombre en el listbox
                listaCliente.DisplayMemberPath = "nombre";
                //esto sera util mas adelante
                listaCliente.SelectedValuePath = "Id";

                //ahora le digo de donde saco los datos para el listbox
                listaCliente.ItemsSource = clientesTabla.DefaultView;
            }




        }



        SqlConnection miConexionSql;
    }
}
