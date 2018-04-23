using System;
using Controllers;
using Models;
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
    /// Interaction logic for Extrato.xaml
    /// </summary>
    public partial class Extrato : Window
    {
        public int conta;
        public int tipoConta;

        public Extrato()
        {
            InitializeComponent();
            
        }

        private void lblNomeExtrato_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            Cliente c = new Cliente();
            //lblNomeExtrato = Convert.ToString(c.Nome);
        }

        private void btnGerar_Click(object sender, RoutedEventArgs e)
        {
            if (tipoConta == 1)
            {
                ContaCController cc = new ContaCController();
                ContaCorrente co = cc.ClienteConta(conta);
                if (co != null)
                {
                    txtNome.Text = co._Cliente.Nome;
                    txtCpf.Text = co._Cliente.Cpf;
                    txtNumeroConta.Text = co.Numero.ToString();
                    txtSaldo.Text = co.Saldo.ToString();


                    
                }
                else
                {
                    MessageBox.Show("Operação não realizada.");

                }
            }
            else
            {
                ContaPController cp = new ContaPController();
                ContaPoupanca cpp = cp.ClienteConta(conta);
                if (cpp != null)
                {
                    txtNome.Text = cpp._Cliente.Nome;
                    txtCpf.Text = cpp._Cliente.Cpf;
                    txtNumeroConta.Text = cpp.Numero.ToString();
                    txtSaldo.Text = cpp.Saldo.ToString();
                }
                else
                {
                    MessageBox.Show("Operação não realizada.");

                }
            }
        }
    }
}
