﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Data.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}