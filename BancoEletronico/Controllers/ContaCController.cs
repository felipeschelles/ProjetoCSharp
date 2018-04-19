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

        public Boolean LoginContaCorrente(int numero, int senha)
        {

            ContaCorrente n = (from x in ContextoSingleton.Instancia.ContasCorrente
                    where x.Numero == numero && x.Senha == senha
                    select x).FirstOrDefault();

            if (n == null){

                    return false;
 
            }else

            return true;
        }

        public string ClienteConta (int numero)
        {
            string nome;
            ContaCorrente c = (from x in ContextoSingleton.Instancia.ContasCorrente
                                 where x.Numero == numero
                                 select x).FirstOrDefault();


            if (c != null) {
                nome = c._Cliente.Nome;
                return nome;
            }
            else
            {
                return "Nulo";
            }
        }
      /*  public void Sacar()
        {

            ContaCorrente c = new ContaCorrente();


            if (c.Saldo >= 100.0)
            {
                c.Saldo -= 100.0;
            }
        }*/
    }
}
