﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("stringConn")
        {
            Database.SetInitializer( new DropCreateDatabaseIfModelChanges<Contexto>());
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<ContaCorrente> ContasCorrente { get; set; }
        public DbSet<ContaPoupanca> ContasPoupanca { get; set; }
    }
}
