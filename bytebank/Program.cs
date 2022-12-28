using bytebank.Contas;
using bytebank.Funcionarios;
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

ContaCorrente conta = new ContaCorrente(74890, 87123);

Console.WriteLine(ContaCorrente.TaxaOperacao);


