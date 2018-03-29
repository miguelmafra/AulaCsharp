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

namespace WpfView
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

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();
            cadCli.Show();

        }

        private void btnPesquisarCliente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnListarClientes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditarCliente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExcluirCliente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente sair?", "Saida do Menu", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Uhuuuuuulllll Yes!");
                
            }
                MessageBox.Show("Adeus!");
            

        }

      
    }
}
