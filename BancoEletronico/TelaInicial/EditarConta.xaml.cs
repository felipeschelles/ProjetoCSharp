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
    /// Interaction logic for EditarConta.xaml
    /// </summary>
    public partial class EditarConta : Window
    {
        public EditarConta()
        {
            InitializeComponent();
        }

        private void btnVoltarEditarConta_Click(object sender, RoutedEventArgs e)
        {
            LoginGerente logGerente = new LoginGerente();
            logGerente.Show();
            Close();
        }
    }
}
