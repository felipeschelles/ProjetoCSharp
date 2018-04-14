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
using Controllers;

namespace TelaInicial
{
    /// <summary>
    /// Interaction logic for ExcluirCliente.xaml
    /// </summary>
    public partial class ExcluirCliente : Window
    {
        public ExcluirCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            ClienteController cc = new ClienteController();
            if (cc.PesquisarPorID(int.Parse(txtID.Text)) != null)
            {
             
                MessageBox.Show("Cliente encontrado.");
                btnExcluir.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
                btnExcluir.IsEnabled = false;
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {

            ClienteController cc = new ClienteController();
            cc.ExcluirCliente(int.Parse(txtID.Text));
            MessageBox.Show("Cliente excluido com sucesso.");
            btnExcluir.IsEnabled = false;
        }
    }
}
