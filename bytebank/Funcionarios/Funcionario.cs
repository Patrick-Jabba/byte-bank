using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public abstract class Funcionario : IBonificacao
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public string Senha { get; set; }
        public string Login { get; set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
            
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

    }
}
