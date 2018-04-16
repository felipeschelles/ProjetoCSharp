using Models;
using System.Linq;
using System.Collections.Generic;

namespace Controllers
{
    public class EnderecosController
    {


        public void SalvarEndereco(Endereco end)
        {
            ContextoSingleton.Instancia.Enderecos.Add(end);
            ContextoSingleton.Instancia.SaveChanges();
        }

        public Endereco PesquisarPorId(int idEnd)
        {
            return ContextoSingleton.Instancia.Enderecos.Find(idEnd);

        }

        public List<Endereco> listarEnderecos()
        {
            return ContextoSingleton.Instancia.Enderecos.ToList();
        }

        public void ExcluirEndereco(int idEndereco)
        {

            Endereco e = ContextoSingleton.Instancia.Enderecos.Find(idEndereco);

            ContextoSingleton.Instancia.Entry(e).State =
                System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();
        }


    }
}
