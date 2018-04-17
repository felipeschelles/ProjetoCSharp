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
    /// Interaction logic for LoginClienteConta.xaml
    /// </summary>
    public partial class LoginClienteConta : Window
    {
        public LoginClienteConta()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            ContaCController cc = new ContaCController();
            Boolean test = cc.LoginConta(int.Parse(txtNumero.Text), txtSenha.Text);
            if (test)
            {
                LoginCliente menuCliente = new LoginCliente();
                menuCliente.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Conta não encontrada!!.");
                txtNumero.Clear();
                txtSenha.Clear();
            }
           
        }
    }
}
