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
    /// Interaction logic for EditarCliente.xaml
    /// </summary>
    public partial class EditarCliente : Window
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

   
                ClienteController cc = new ClienteController();

                Cliente c = new Cliente();
                c.Nome = txtNome.Text;
                c.DtAniver = txtDtNascimento.Text;
                c.Cpf = txtCPF.Text;

                cc.EditarCliente(int.Parse(txtID.Text),c);
                MessageBox.Show("Cliente editado com sucesso.");
           
            
        }

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            ClienteController cc = new ClienteController();
            if (cc.PesquisarPorID(int.Parse(txtID.Text)) != null)
            {
                txtNome.IsEnabled = true;
                txtCPF.IsEnabled = true;
                txtDtNascimento.IsEnabled = true;
                MessageBox.Show("Cliente encontrado.");
                btnEditar.IsEnabled = true;
            }
            else{
                MessageBox.Show("Cliente não encontrado.");
            }
        }
    }
}
