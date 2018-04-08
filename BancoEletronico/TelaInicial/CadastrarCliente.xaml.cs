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
            Cliente c = new Cliente();
            c.Nome = txtNome.Text;
            c.DtAniver = txtDtNascimento.Text;
            c.Cpf = txtCPF.Text;

            Endereco end = cadastrarEndereco();

            c.EnderecoID = end.EnderecoID;

            MessageBox.Show("Cliente cadastrado com sucesso.");
        }

        private Endereco cadastrarEndereco()
        {
            // ... Endereco
            Endereco end = new Endereco();

            Console.Write("Digite o nome da rua: ");
            end.Rua = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o numero: ");
            end.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine();

            EnderecosController ec = new EnderecosController();
            ec.SalvarEndereco(end);
            return end;
        }
    }
}
