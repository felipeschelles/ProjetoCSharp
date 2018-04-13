﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Threading.Tasks;

namespace Controllers
{
    class ContaPController
    {


        public void SalvarContaPoupanca(ContaPoupanca conta)
        {
            ContextoSingleton.Instancia.ContasPoupanca.Add(conta);
            ContextoSingleton.Instancia.SaveChanges();
        }

        public ContaPoupanca PesquisarContaPorID(int idConta)
        {
            return ContextoSingleton.Instancia.ContasPoupanca.Find(idConta);
        }

        public void ExcluirConta(int idConta)
        {
            ContaPoupanca c = ContextoSingleton.Instancia.ContasPoupanca.Find(idConta);

            ContextoSingleton.Instancia.Entry(c).State =
                System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();
        }

        public List<ContaPoupanca> ListarContas()
        {
            return ContextoSingleton.Instancia.ContasPoupanca.ToList();
        }

        public void Movimento(int idContaEditar, ContaPoupanca contaEditada)
        {
            ContaPoupanca contaEditar = PesquisarContaPorID(idContaEditar);

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
