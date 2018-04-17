using Models;
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
using Controllers;

namespace TelaInicial
{
    /// <summary>
    /// Interaction logic for ListarConta.xaml
    /// </summary>
    public partial class ListarContas : Window
    {
        List<ContaCorrente> ContaCLista = new List<ContaCorrente>();
        List<ContaPoupanca> ContaPLista = new List<ContaPoupanca>();
        List<Cliente> Cli = new List<Cliente>();
        int ContaValue;

        public ListarContas()
        {
            InitializeComponent();
            
            ContaCController cc = new ContaCController();
            ContaPController cp = new ContaPController();
            ClienteController c = new ClienteController();
            Cli = c.ListarClientes();
            ContaCLista = cc.ListarContas();
            ContaPLista = cp.ListarContas();

            foreach (var x in ContaCLista)
            {
                dtgListarContasCorrente.Items.Add(x);
            }
            foreach (var x in ContaPLista)
            {
                dtgListarContasPoupanca.Items.Add(x);
            }
        }

        private void btnVoltarListarContas_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ContaValue = int.Parse(dtgListarContasCorrente.SelectedValue.ToString());
            ContaValue = int.Parse(dtgListarContasPoupanca.SelectedValue.ToString());
        }
    }
}
