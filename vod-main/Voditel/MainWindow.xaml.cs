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

namespace Voditel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ZapExBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DOBDTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nasbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void upBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DelDTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, RoutedEventArgs e)
        {
            enter enter = new enter();
            enter.Show();
            this.Close();
        }
    }
}
