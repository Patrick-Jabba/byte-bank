using bytebank.Contas;
using bytebank.Exceptions;
using bytebank.Funcionarios;
using bytebank.LeitorDeArquivo;
using bytebank.Parceria;
using bytebank.SistemaInterno;
using bytebank.Utils;

#region
//Funcionario pedro = new Funcionario("123455", 2000);

//pedro.Nome = "Pedro Henrique Meirelles";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("123456");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine($"Total de bonificações:  {gerenciador.TotalDeBonificacao}");
//Console.WriteLine($"Total de funcionários:  {Funcionario.TotalDeFuncionarios}");

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Novo salário do Pedro: {pedro.Salario}");
//Console.WriteLine($"Novo salário do Roberta: {roberta.Salario}");
#endregion

#region
//CalcularBonificacao();
//usarSistema();
//void CalcularBonificacao()
//{
//    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//    Designer ulisses = new Designer("123456");
//    ulisses.Nome = "Ulisses Souza";

//    Diretor paula = new Diretor("123456");
//    paula.Nome = "Paula Miranda";
//    Console.WriteLine(paula.GetBonificacao());

//    Auxiliar igor = new Auxiliar("123456");
//    igor.Nome = "Igor Fernandes";

//    GerenteDeContas camila = new GerenteDeContas("123455");
//    camila.Nome = "Camila Oliveira";

//    gerenciador.Registrar(camila);
//    gerenciador.Registrar(igor);
//    gerenciador.Registrar(paula);
//    gerenciador.Registrar(ulisses);

//    Console.WriteLine($"Total de Bonificação: {gerenciador.TotalDeBonificacao}");
//}

//void usarSistema()
//{
//    SistemaInterno sistema = new SistemaInterno();

//    Diretor ingrid = new Diretor("123456");
//    ingrid.Nome = "Ingrid Novaes";
//    ingrid.Senha = "123";
//    ingrid.Login = "ingrid.dir.com";

//    GerenteDeContas ursula = new GerenteDeContas("12345");

//    ursula.Nome = "Ursula Teixeira";
//    ursula.Senha = "321";
//    ursula.Login = "ursula.ger.com";

//    ParceiroComercial caio = new ParceiroComercial();
//    caio.Login = "caio.parc.com";
//    caio.Senha = "9999";

//    sistema.logar(ingrid, "123", ingrid.Login);
//    sistema.logar(ursula, "321", ursula.Login);
//    sistema.logar(caio, "9999", caio.Login);
//}
#endregion

//try
//{
//    ContaCorrente conta = new ContaCorrente(32, 1245);
//    ContaCorrente conta2 = new ContaCorrente(32, 54321);

//    conta.Depositar(50);
//    conta.Sacar(500);
//    conta.Transferir(100, conta2);
//    Console.WriteLine(conta.Saldo);
//    Console.WriteLine(conta2.Saldo);

//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine($"Erro no parâmetro: {ex.ParamName}");
//    //Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Message);
//}
//catch (SaldoInsuficienteException ex)
//{
//    Console.WriteLine($"Exceção do tipo SaldoInusificienteException");
//    //Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Message);
//}
//catch (OperacaoFinanceiraException ex)
//{
//    Console.WriteLine($"Exceção do tipo SaldoInusificienteException");
//    //Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.InnerException.Message);
//    Console.WriteLine(ex.Message);
//}

//Console.WriteLine(ContaCorrente.ContadorSaquesNaoPermitidos);
//Console.WriteLine(ContaCorrente.ContadorTransferenciasNaoPermitidas);

//Console.WriteLine(ContaCorrente.TaxaOperacao);

CarregarContas();
void CarregarContas()
{
    LeitorDeArquivo leitor = null;
    try
    {
        leitor = new LeitorDeArquivo("contas.txt");
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
    }
    catch (IOException ex)
    {
        Console.WriteLine("Exceção do tipo IOException capturada");
        Console.WriteLine(ex.Message);
    }
    finally
    {
        if (leitor != null)
        {
        leitor.Fechar();
        }
    }
}


