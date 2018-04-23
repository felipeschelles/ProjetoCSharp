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
        public static int numConta;
        public CadastrarConta()
        {
            InitializeComponent();
        }

        private void UltimaConta()
        {
            ContaCController cc = new ContaCController();
            ContaPController cp = new ContaPController();

            if(cc.ListarContas() == null)
            {
                if(cp.ListarContas() == null)
                {
                    numConta = 1000;
                }
                else
                {
                    numConta = cp.ListarContas().Last().Numero + 1;
                }
            }
            else
            {
                numConta = cc.ListarContas().Last().Numero + 1;
            }
        }

        private void btnVoltarCadastrarConta_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (txtBuscarIdCliente.Text == "")
            {
                MessageBox.Show("Campo Obrigatorio!!");
            }
            else {
                ClienteController cc = new ClienteController();
                if (cc.PesquisarPorID(int.Parse(txtBuscarIdCliente.Text)) != null) {


                    MessageBox.Show("Conta encontrada.");
                    btnSalvar.IsEnabled = true;
                }
                else {
                    MessageBox.Show("Conta não encontrada.");
                }
            }

        }   

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            //Conta co = new Conta();
            // ComboBox cbx = sender as ComboBox;
            if (cboxConta.SelectedItem == null)
            {
                MessageBox.Show("Selecione o tipo de conta");
            }
            else
            {
                if (txtSaldo.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Campo Obrigatorio!!");
                }
                else
                {

                    
                    if (conta == 1)
                    {

                        ContaCorrente cc = new ContaCorrente();
                        cc.ClienteID = int.Parse(txtBuscarIdCliente.Text);
                        cc.Numero = numConta + 1;
                        cc.Saldo = float.Parse(txtSaldo.Text);
                        cc.Senha = int.Parse(txtSenha.Text);
                        ContaCController ccc = new ContaCController();
                        ccc.SalvarContaCorrente(cc);
                        MessageBox.Show("Conta cadastrada");
                        btnSalvar.IsEnabled = false;
                        numConta = numConta + 1;

                        cboxConta.SelectedItem = null;
                        txtBuscarIdCliente.Clear();
                        txtSaldo.Clear();
                        txtSenha.Clear();
                    }
                    else
                    {
                        if (conta == 2)
                        {
                            ContaPoupanca cp = new ContaPoupanca();
                            cp.ClienteID = int.Parse(txtBuscarIdCliente.Text);
                            cp.Numero = numConta + 1;
                            cp.Saldo = float.Parse(txtSaldo.Text);
                            cp.Senha = int.Parse(txtSenha.Text);
                            ContaPController ccp = new ContaPController();
                            ccp.SalvarContaPoupanca(cp);
                            MessageBox.Show("Conta cadastrada");
                            btnSalvar.IsEnabled = false;
                            numConta = numConta + 1;

                            cboxConta.SelectedItem = null;
                            txtBuscarIdCliente.Clear();
                            txtSaldo.Clear();
                            txtSenha.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Conta não cadastrada");
                        }
                    }
                }
            }

        }



        private void cboxConta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UltimaConta();
            lblNumero.Content = numConta;
            if (cboxConta.SelectedIndex == 0)
            {
                conta = 1;
            }
            else
            {
                if (cboxConta.SelectedIndex == 1)
                {
                    conta = 2;
                }
               
            }
            
            
        }
    }
    
}
