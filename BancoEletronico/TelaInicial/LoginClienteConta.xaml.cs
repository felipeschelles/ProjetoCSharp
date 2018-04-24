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
            if (txtNumero.Text == "" || txtSenha.Password == "")
            {
                MessageBox.Show("Campo Obrigatorio!!");
            }else { 
            ContaCController cc = new ContaCController();
            Boolean testC = cc.LoginContaCorrente(int.Parse(txtNumero.Text), int.Parse(txtSenha.Password));

                if (testC)
                {
                    LoginCliente menuCliente = new LoginCliente();
                    menuCliente.contaLogada = int.Parse(txtNumero.Text);
                    menuCliente.tipoConta = 1;
                    menuCliente.lblCliente.Content = cc.NomeClienteConta(int.Parse(txtNumero.Text));
                    menuCliente.Show();
                    Close();
                }
                else
                {
                    ContaPController cp = new ContaPController();
                    Boolean testP = cp.LoginContaPoupanca(int.Parse(txtNumero.Text), int.Parse(txtSenha.Password));
                    if (testP)
                    {
                        LoginCliente menuCliente = new LoginCliente();
                        menuCliente.contaLogada = int.Parse(txtNumero.Text);
                        menuCliente.tipoConta = 2;
                        menuCliente.lblCliente.Content = cp.NomeClienteConta(int.Parse(txtNumero.Text));
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

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menuGeral = new MainWindow();
            menuGeral.Show();
            Close();
        }
    }
}
