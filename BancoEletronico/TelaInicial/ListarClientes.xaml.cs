using System;
using Models;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica interna para ListarClientes.xaml
    /// </summary>
    public partial class ListarClientes : Window
        
    {

        List<Cliente> ClienteLista = new List<Cliente>();
        List<Endereco> Enderecos = new List<Endereco>();
        int CellValue;

        public ListarClientes()
        {
            InitializeComponent();
            Controllers.ClienteController cc = new Controllers.ClienteController();
            Controllers.EnderecosController end = new Controllers.EnderecosController();
            Enderecos = end.listarEnderecos();
            ClienteLista = cc.ListarClientes();
            
            foreach (var x in ClienteLista)
            {
                dtgListar.Items.Add(x);
            }
            
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CellValue = int.Parse(dtgListar.SelectedValue.ToString());
        }
    }
}
