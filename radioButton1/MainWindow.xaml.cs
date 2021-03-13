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

namespace radioButton1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //two ways: using ellipses or full images

        private void amarillo_Checked(object sender, RoutedEventArgs e)
        {
            //erojo.Visibility = Visibility.Hidden;
            //everde.Visibility = Visibility.Hidden;
            //eamarillo.Visibility = Visibility.Visible;
            semaforo.Source = new BitmapImage(new Uri("C:/Users/jpiquero/source/repos/radioButton1/radioButton1/images/yellow.png", UriKind.RelativeOrAbsolute));

        }

        private void verde_Checked(object sender, RoutedEventArgs e)
        {
            //erojo.Visibility = Visibility.Hidden;
            //everde.Visibility = Visibility.Visible;
            //eamarillo.Visibility = Visibility.Hidden;
            semaforo.Source = new BitmapImage(new Uri("C:/Users/jpiquero/source/repos/radioButton1/radioButton1/images/green.jpg", UriKind.RelativeOrAbsolute));

        }

        private void rojo_Checked(object sender, RoutedEventArgs e)
        {
            //erojo.Visibility = Visibility.Visible;
            //everde.Visibility = Visibility.Hidden;
            //eamarillo.Visibility = Visibility.Hidden;
            semaforo.Source = new BitmapImage(new Uri("C:/Users/jpiquero/source/repos/radioButton1/radioButton1/images/red.png", UriKind.RelativeOrAbsolute));

        }
    }
}
