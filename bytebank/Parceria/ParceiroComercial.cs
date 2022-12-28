﻿using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string  Senha { get; set; }
        public string Login { get; set; }
        public bool Autenticar(string senha, string login)
        {
            return (Senha == senha && Login == login);
        }
    }
}
