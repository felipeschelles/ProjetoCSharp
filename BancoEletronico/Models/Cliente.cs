﻿using System;
namespace Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        public string Nome { get; set; }

        public DateTime DtAniver { get; set; }

        public int Cpf { get; set; }

        public int EnderecoID { get; set; }

    }
}