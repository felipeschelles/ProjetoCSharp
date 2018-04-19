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
        public Extrato()
        {
            InitializeComponent();
        }

        private void lblNomeExtrato_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            Cliente c = new Cliente();
            //lblNomeExtrato = Convert.ToString(c.Nome);
        }
    }
}
