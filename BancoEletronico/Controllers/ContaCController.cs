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

        public void SalvarContaCorrente(ContaCorrente conta)
        {
            ContextoSingleton.Instancia.ContaCorrente.Add(conta);
            ContextoSingleton.Instancia.SaveChanges();
        }

        public ContaCorrente PesquisarContaPorID(int idConta)
        {
            return ContextoSingleton.Instancia.ContaCorrente.Find(idConta);
        }

        public void ExcluirConta(int idConta)
        {
            ContaCorrente c = ContextoSingleton.Instancia.ContaCorrente.Find(idConta);

            ContextoSingleton.Instancia.Entry(c).State =
                System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();
        }

        public List<ContaPoupanca> ListarContas()
        {
            return ContextoSingleton.Instancia.ContasCorrente.ToList();
        }

        public void Movimento(int idContaEditar, ContaPoupanca contaEditada)
        {
            ContaCorrente contaEditar = PesquisarContaPorID(idContaEditar);

            if (contaEditar != null)
            {

                contaEditar.Saldo = contaEditada.Saldo;

                ContextoSingleton
                   .Instancia
                   .Entry(contaEditar).State =
                   System.Data.Entity.EntityState.Modified;

                ContextoSingleton.Instancia.SaveChanges();

            }

        }
    }
}
