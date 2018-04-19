using System;
using Models;
using Controllers;
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
    /// Interaction logic for CadastrarConta.xaml
    /// </summary>
    public partial class CadastrarConta : Window
    {
        public int conta=0;
        public CadastrarConta()
        {
            InitializeComponent();
        }

        private void btnVoltarCadastrarConta_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            ClienteController cc = new ClienteController();
            if (cc.PesquisarPorID(int.Parse(txtBuscarIdCliente.Text)) != null){


                MessageBox.Show("Cliente encontrado.");
                btnSalvar.IsEnabled = true;
            }
            else{
                MessageBox.Show("Cliente não encontrado.");
            }

        }   

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            //Conta co = new Conta();
            // ComboBox cbx = sender as ComboBox;
            if (txtCadastrarConta.Text == "" || txtSaldo.Text == "")
            {
                MessageBox.Show("Campo Obrigatorio!!");
            }
            else
            {
                if (conta == 1)
                {

                    ContaCorrente cc = new ContaCorrente();
                    cc.ClienteID = int.Parse(txtBuscarIdCliente.Text);
                    cc.Numero = int.Parse(txtCadastrarConta.Text);
                    cc.Saldo = float.Parse(txtSaldo.Text);
                    cc.Senha = int.Parse(txtSenha.Text);
                    ContaCController ccc = new ContaCController();
                    ccc.SalvarContaCorrente(cc);
                    MessageBox.Show("Conta cadastrada");
                    btnSalvar.IsEnabled = false;
                }
                else
                {
                    if (conta == 2)
                    {
                        ContaPoupanca cp = new ContaPoupanca();
                        cp.ClienteID = int.Parse(txtBuscarIdCliente.Text);
                        cp.Numero = int.Parse(txtCadastrarConta.Text);
                        cp.Saldo = float.Parse(txtSaldo.Text);
                        cp.Senha = int.Parse(txtSenha.Text);
                        ContaPController ccp = new ContaPController();
                        ccp.SalvarContaPoupanca(cp);
                        MessageBox.Show("Conta cadastrada");
                        btnSalvar.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Conta não cadastrada");
                    }
                }
            }

        }

        private void btnVerificarConta_Click(object sender, RoutedEventArgs e)
        {

            if(int.Parse(txtTipoConta.Text) == 1)
            {
                conta = 1;
                btnVerificarConta.IsEnabled = true;
                MessageBox.Show("Conta Corrente.");
            }
            else
            {
               if(int.Parse(txtTipoConta.Text) == 2)
                {
                    conta = 2;
                    btnVerificarConta.IsEnabled = true;
                    MessageBox.Show("Conta Poupança.");
                }
                else
                {
                    MessageBox.Show("Tipo de conta não existe. Digite 1 para conta corrente ou 2 para conta poupança.");
                    btnVerificarConta.IsEnabled = false;
                }
            }

        }
    }
    
}
