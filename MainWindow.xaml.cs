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
using System.Collections.ObjectModel;
namespace Praktika
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
        private void Btm_close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Serv(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ClientSer(object sender, RoutedEventArgs e)
        {
            ClientSer clientSer = new ClientSer();
            clientSer.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PD1 pD1 = new PD1();
            pD1.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sotr sotr = new Sotr();
            sotr.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            brend brend = new brend();
            brend.ShowDialog();

        }
    }
}