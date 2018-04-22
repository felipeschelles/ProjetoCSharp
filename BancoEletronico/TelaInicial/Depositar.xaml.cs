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
    /// Interaction logic for Depositar.xaml
    /// </summary>
    public partial class Depositar : Window
    {
        public int conta;
        public int tipoConta;

        public Depositar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDepositar_Click(object sender, RoutedEventArgs e)
        {
            if (tipoConta == 1)
            {
                ContaCController cc = new ContaCController();
                double sacarConta = Convert.ToDouble(txtVlrDepositar.Text);
                if(cc.Movimento(conta, sacarConta, 1))
                {
                    MessageBox.Show("Deposito efetuado com sucesso!!");
                    txtVlrDepositar.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar o deposito");
                    txtVlrDepositar.Clear();
                }
            }
            else
            {
                ContaPController cp = new ContaPController();
                double sacarConta = Convert.ToDouble(txtVlrDepositar.Text);
                if (cp.Movimento(conta, sacarConta, 1))
                {
                    MessageBox.Show("Deposito efetuado com sucesso!!");
                    txtVlrDepositar.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar o deposito");
                    txtVlrDepositar.Clear();
                }

            }
        }
    }
}
