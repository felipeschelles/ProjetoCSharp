using System;
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
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            Controllers.ClienteController cc = new Controllers.ClienteController();
           
            dtgListar.DataContext = cc.ListarClientes();
           
        }
    }
}
