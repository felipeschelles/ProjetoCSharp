using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ContaCController
    {

        public void SalvarContaCorrente(ContaCorrente conta)
        {
            ContextoSingleton.Instancia.ContasCorrente.Add(conta);
            ContextoSingleton.Instancia.SaveChanges();
        }

        public ContaCorrente PesquisarContaPorID(int idConta)
        {
            return ContextoSingleton.Instancia.ContasCorrente.Find(idConta);
        }

        public void ExcluirConta(int idConta)
        {
            ContaCorrente c = ContextoSingleton.Instancia.ContasCorrente.Find(idConta);

            ContextoSingleton.Instancia.Entry(c).State =
                System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();
        }

        public List<ContaCorrente> ListarContas()
        {
            return ContextoSingleton.Instancia.ContasCorrente.ToList();
        }

        public void Movimento(int idContaEditar, ContaCorrente contaEditada)
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

        public ContaCorrente PesquisarPorID(int idConta)
        {
            return ContextoSingleton.Instancia.ContasCorrente.Find(idConta);
        }

        public Boolean LoginConta(int numero, string senha)
        {

            var n = from x in ContextoSingleton.Instancia.ContasCorrente
                    where x.Numero == numero
                    select x;

            var s = from x in ContextoSingleton.Instancia.ContasCorrente
                    where x.Senha.Contains(senha)
                    select x;


            if (n != null && s != null){
                    return true;
 
            }else
            {
                ContaPController cp = new ContaPController();
                Boolean test = cp.LoginConta(numero, senha);
                if (test)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
