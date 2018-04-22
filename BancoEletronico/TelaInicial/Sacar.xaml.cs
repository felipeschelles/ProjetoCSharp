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
using Controllers;

namespace TelaInicial
{
    /// <summary>
    /// Interaction logic for Sacar.xaml
    /// </summary>
    public partial class Sacar : Window
    {
        public int conta;
        public int tipoConta;


        public Sacar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSacar_Click(object sender, RoutedEventArgs e)
        {

            if (tipoConta == 1)
            {
                ContaCController cc = new ContaCController();
                double sacarConta = Convert.ToDouble(txtVlrSacar.Text);
                if(cc.Movimento(conta, sacarConta, 2))
                {
                    MessageBox.Show("Saque efetuado com sucesso!!");
                    txtVlrSacar.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar o saque");
                    txtVlrSacar.Clear();
                }
            }
            else
            {
                ContaPController cp = new ContaPController();
                double sacarConta = Convert.ToDouble(txtVlrSacar.Text);
                if (cp.Movimento(conta, sacarConta, 2))
                {
                    MessageBox.Show("Saque efetuado com sucesso!!");
                    txtVlrSacar.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar o saque");
                    txtVlrSacar.Clear();
                }

            }


        }
    }
}
