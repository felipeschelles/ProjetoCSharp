using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class ContaCController
    {
        static List<ContaCorrente> MinhasContasCorrente = new List<ContaCorrente>();
        static int ultimoID = 0;

        public void SalvarContaCorrente(ContaCorrente conta)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            conta.ContaID = id;
            MinhasContasCorrente.Add(conta);
        }

        public ContaCorrente PesquisarContaPorID(int idConta)
        {
            var c = from x in MinhasContasCorrente
                    where x.ClienteID.Equals(idConta)
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        public void ExcluirConta(int idConta)
        {
            ContaCorrente cont = PesquisarContaPorID(idConta);

            if (cont != null)
                MinhasContasCorrente.Remove(cont);
        }

        public List<ContaCorrente> ListarContas()
        {
            return MinhasContasCorrente;
        }

        public void EditarCliente(int idContaEditar, ContaCorrente contaEditada)
        {
            ContaCorrente contaEditar = PesquisarContaPorID(idContaEditar);

            contaEditar.Saldo = contaEditada.Saldo;

        }
    }
}
