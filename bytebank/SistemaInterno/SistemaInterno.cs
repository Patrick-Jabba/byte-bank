using bytebank.Funcionarios;
using bytebank.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bytebank.SistemaInterno
{
    public class SistemaInterno
    {
        public bool logar(IAutenticavel funcionario, string senha, string login)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha, login);
            if(usuarioAutenticado)
            {
                Console.WriteLine("Login efetuado com sucesso!");
                Console.WriteLine($"Seja bem-vindo {login}, ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Erro ao logar, tente novamente.");
                return false;
            }
        }
    }
}
