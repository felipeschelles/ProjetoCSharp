using Controllers;
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
    /// Interaction logic for ExcluirConta.xaml
    /// </summary>
    public partial class ExcluirConta : Window
    {
        public ExcluirConta()
        {
            InitializeComponent();
        }

        private void btnVoltarExContas_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        private void btnVerificarConta_Click(object sender, RoutedEventArgs e)
        {
            ContaCController co = new ContaCController();
            if (co.PesquisarContaPorID(int.Parse(txtExcluirConta.Text)) != null)
            {

                MessageBox.Show("Conta encontrada.");
                btnExcluir.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Conta não encontrada.");
                btnExcluir.IsEnabled = false;
            }
        }
    }
}
