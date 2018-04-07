using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Threading.Tasks;

namespace Controllers
{
    class ContaPController
    {
        static List<ContaPoupanca> MinhasContasPoupanca = new List<ContaPoupanca>();
        static int ultimoID = 0;

        public void SalvarContaPoupanca(ContaPoupanca conta)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            conta.ContaID = id;
            MinhasContasPoupanca.Add(conta);
        }

        public ContaPoupanca PesquisarContaPorID(int idConta)
        {
            var c = from x in MinhasContasPoupanca
                    where x.ClienteID.Equals(idConta)
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        public void ExcluirConta(int idConta)
        {
            ContaPoupanca cont = PesquisarContaPorID(idConta);

            if (cont != null)
                MinhasContasPoupanca.Remove(cont);
        }

        public List<ContaPoupanca> ListarContas()
        {
            return MinhasContasPoupanca;
        }

        public void EditarCliente(int idContaEditar, ContaPoupanca contaEditada)
        {
            ContaPoupanca contaEditar = PesquisarContaPorID(idContaEditar);

            contaEditar.Saldo = contaEditada.Saldo;
           
        }
    }
}
