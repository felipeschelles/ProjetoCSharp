using Models;
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
    /// Interaction logic for LoginCliente.xaml
    /// </summary>
    public partial class LoginCliente : Window
    {
        public int contaLogada;
        public int tipoConta;

        public LoginCliente()
        {
            InitializeComponent();


        }

        

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menuGeral = new MainWindow();
            menuGeral.Show();
            Close();
        }

        private void btnSacar_Click(object sender, RoutedEventArgs e)
        {
            Sacar sacar = new Sacar();
            sacar.conta = contaLogada;
            sacar.tipoConta = tipoConta;
            sacar.Show();
        }

        private void btnDepositar_Click(object sender, RoutedEventArgs e)
        {
            Depositar depositar = new Depositar();
            depositar.conta = contaLogada;
            depositar.tipoConta = tipoConta;
            depositar.Show();
        }

       

        private void lblCliente_Initialized(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tipoConta == 1)
            {
                ContaCController cc = new ContaCController();
                lblCliente.Content = cc.NomeClienteConta(contaLogada);
            }
            else
            {
                ContaPController cp = new ContaPController();
                lblCliente.Content = cp.NomeClienteConta(contaLogada);
            }
        }







        /* private void lblNome_ContextMenuClosing(object sender, ContextMenuEventArgs e)
         {
             Cliente c= new Cliente();
             texto = c.Nome;
             lblNome = ;
         }*/
    }
}
