﻿using Models;
using System.Collections.Generic;
using System.Linq;
using Models.DAL;

namespace Controllers
{
    public class ClienteController
    {
        
       

        public void SalvarCliente(Cliente cliente)
        {
            Contexto ctx = new Contexto();
            ctx.Clientes.Add(cliente);
            ctx.SaveChanges();
        }

        public Cliente PesquisarPorNome(string nome)
        {
            Contexto ctx = new Contexto();

            var c = from x in ctx.Clientes
                    where x.Nome.ToLower().Contains(nome.Trim().ToLower())
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        public Cliente PesquisarPorID(int idCliente)
        {
            Contexto ctx = new Contexto();

            return ctx.Clientes.Find(idCliente);

       
        }

        public void ExcluirCliente(int idCliente)
        {
            Contexto ctx = new Contexto();
            Cliente c = ctx.Clientes.Find(idCliente);

            ctx.Entry(c).State = System.Data.Entity.EntityState.Deleted;

            ctx.SaveChanges();
        }

        public List<Cliente> ListarClientes()
        {
            Contexto ctx = new Contexto();

            return ctx.Clientes.ToList();
        }

        public void EditarCliente(int idClienteEditar, Cliente clienteEditado)
        {
            Cliente clienteEditar = PesquisarPorID(idClienteEditar);

            clienteEditar.Nome = clienteEditado.Nome;
            clienteEditar.Cpf = clienteEditado.Cpf;
        }
    }
}
