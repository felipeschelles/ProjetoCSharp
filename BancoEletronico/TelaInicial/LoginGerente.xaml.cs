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
using System.Windows.Shapes;

namespace TelaInicial
{
    /// <summary>
    /// Interaction logic for LoginGerente.xaml
    /// </summary>
    public partial class LoginGerente : Window
    {
        

        public LoginGerente()
        {
            InitializeComponent();
        }

        private void btnCadastrarClientes_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCliente cadCli = new CadastrarCliente();
            cadCli.Show();
            Close();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menuGeral = new MainWindow();
            menuGeral.Show();
            Close();
        }

        private void btnListarClientes_Click(object sender, RoutedEventArgs e)
        {
            ListarClientes listClientes = new ListarClientes();
            listClientes.Show();
            Close();
        }

        private void btnEditarClientes_Click(object sender, RoutedEventArgs e)
        {
            EditarCliente editCliente = new EditarCliente();
            editCliente.Show();
            Close();
        }

        private void btnExcluirClientes_Click(object sender, RoutedEventArgs e)
        {
            ExcluirCliente exCliente = new ExcluirCliente();
            exCliente.Show();
            Close();
        }


        private void btnListarContas_Click(object sender, RoutedEventArgs e)
        {
            ListarContas listConta = new ListarContas();
            listConta.Show();
            Close();
            

        }


        private void btnExcluirContas_Click(object sender, RoutedEventArgs e)
        {
            ExcluirConta listExcluirConta = new ExcluirConta();
            listExcluirConta.Show();
            Close();
        }

        private void btnCadastrarContas_Click(object sender, RoutedEventArgs e)
        {
            CadastrarConta cadConta = new CadastrarConta();
            cadConta.Show();
            Close();
        }

    }
}
