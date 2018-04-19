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

namespace TelaInicial
{
    /// <summary>
    /// Interaction logic for LoginCliente.xaml
    /// </summary>
    public partial class LoginCliente : Window
    {
        public string contaLogada;
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
            sacar.Show();
        }

        private void btnDepositar_Click(object sender, RoutedEventArgs e)
        {
            Depositar depositar = new Depositar();
            depositar.Show();
        }

        private void textBlock_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            textBlock.Text = contaLogada;
        }



        /* private void lblNome_ContextMenuClosing(object sender, ContextMenuEventArgs e)
         {
             Cliente c= new Cliente();
             texto = c.Nome;
             lblNome = ;
         }*/
    }
}
