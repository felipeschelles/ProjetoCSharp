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

        public ContaCorrente ClienteConta (int numero)
        {
    
            ContaCorrente c = (from x in ContextoSingleton.Instancia.ContasCorrente
                                 where x.Numero == numero
                                 select x).FirstOrDefault();


            if (c != null) {
             
                return c;
            }
            else
            {
                return null;
            }
        }

        

        public string NomeClienteConta(int numero)
        {

            ContaCorrente c = (from x in ContextoSingleton.Instancia.ContasCorrente
                               where x.Numero == numero
                               select x).FirstOrDefault();


            if (c != null)
            {

                return c._Cliente.Nome ;
            }
            else
            {
                return "Nulo";
            }
        }


        public Boolean Movimento(int idContaEditar, Double valor, int tipoMovimento)
        {
            ContaCorrente contaEditar = ClienteConta(idContaEditar);


            if (tipoMovimento == 1)
            {
                if (valor < 1)
                {
                    return false;
                } else
                {
                    if (contaEditar != null)
                    {
                        contaEditar.Saldo = contaEditar.Saldo + valor;

                        ContextoSingleton
                            .Instancia
                            .Entry(contaEditar).State =
                            System.Data.Entity.EntityState.Modified;

                        ContextoSingleton.Instancia.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                if(valor > contaEditar.Saldo)
                {
                    return false;
                }
                else
                {
                    contaEditar.Saldo = contaEditar.Saldo - valor;

                    ContextoSingleton
                            .Instancia
                            .Entry(contaEditar).State =
                            System.Data.Entity.EntityState.Modified;

                    ContextoSingleton.Instancia.SaveChanges();
                    return true;
                }
            }
        }
    }
}
