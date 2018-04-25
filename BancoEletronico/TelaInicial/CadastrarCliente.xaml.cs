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
    /// Lógica interna para CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {

            if (txtCPF.Text == "" || txtDtNascimento.Text == "" || txtNome.Text == "" || txtNumero.Text == "" || txtRua.Text == "") {
                MessageBox.Show("Campo Obrigatorio!!");
            }
            else {
                ClienteController cc = new ClienteController();
                Cliente c = new Cliente();
                c.Nome = txtNome.Text;
                c.DtAniver = txtDtNascimento.Text;
                c.Cpf = txtCPF.Text;
                Boolean verifica = cc.VerificaCPF(txtCPF.Text);
                Endereco end = cadastrarEndereco();

                c.EnderecoID = end.EnderecoID;

                if (verifica)
                {
                    cc.SalvarCliente(c);
                    MessageBox.Show("Cliente cadastrado com sucesso.");
                }
                else
                {
                    MessageBox.Show("CPF ja cadastrado.");
                }
            }
        }

        private Endereco cadastrarEndereco()
        {
            // ... Endereco
            Endereco end = new Endereco();

            
            end.Rua = txtRua.Text;

            end.Numero = int.Parse(txtNumero.Text);

            

            EnderecosController ec = new EnderecosController();
            ec.SalvarEndereco(end);
            return end;
        }
    }
}
