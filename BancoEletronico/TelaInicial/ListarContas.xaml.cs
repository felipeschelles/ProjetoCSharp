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

namespace TelaInicial
{
    /// <summary>
    /// Interaction logic for ListarConta.xaml
    /// </summary>
    public partial class ListarContas : Window
    {
        List<ContaCorrente> ContaLista = new List<ContaCorrente>();
        int ContaValue;

        public ListarContas()
        {
            InitializeComponent();
            
            Controllers.ContaCController co = new Controllers.ContaCController();

            ContaLista = co.ListarContas();

            foreach (var x in ContaLista)
            {
                dtgListarContas.Items.Add(x);
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
            ContaValue = int.Parse(dtgListarContas.SelectedValue.ToString());
        }
    }
}
