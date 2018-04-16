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
using Models;

using Controllers;

namespace TelaInicial

{
    /// <summary>
    /// Interaction logic for EditarConta.xaml
    /// </summary>
    public partial class EditarConta : Window
    {
        public EditarConta()
        {
            
            InitializeComponent();
            
           // this.comboBoxEditarTipoConta.Dro = 280;
           //// this.comboBoxEditarTipoConta.Items.Add("1 - Conta Corrente",
                       // "2 - Conta Poupança");
        }

        private void btnVoltarEditarConta_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        private void btnVerificarEditar_Click(object sender, RoutedEventArgs e)
        {
            ContaCController cc = new ContaCController();
            if (cc.PesquisarContaPorID(int.Parse(txtIdConta.Text)) != null)
            
            {
                
                MessageBox.Show("Cliente encontrado.");
                btnEditarConta.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
            }
        }

        private void btnEditarConta_Click(object sender, RoutedEventArgs e)
        {
            ContaCController cc = new ContaCController();

            /*Conta c = new Conta();
            c.Nome = txtNome.Text;
            

            
            MessageBox.Show("Cliente editado com sucesso.");*/

        }

        private void comboBoxEditarTipoConta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
