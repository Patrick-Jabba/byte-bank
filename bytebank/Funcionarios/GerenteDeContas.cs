﻿using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    internal class GerenteDeContas : FuncionarioAutenticavel
    { 
        public GerenteDeContas (string cpf) : base(cpf, 4000)
        {

        }
        public override double GetBonificacao()
        {

            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.5;
        }

    }
}
