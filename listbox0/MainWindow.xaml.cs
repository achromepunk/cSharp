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

namespace listbox0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int i = 2;

            List<MisNumeros> listaNums = new List<MisNumeros>();
            listaNums.Add(new MisNumeros() { Uno = i, Dos= i, Tres=i }) ;

            //asi le indicamos quien es el source de listanumeros (ver xaml)
            //listaNumeros.ItemsSource = listaNums;

        }
    }
}
