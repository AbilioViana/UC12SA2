// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using UC12.Classes;



//---------------------------------------------Pessoa Física---------------------------------------------------


//Método construtor
PessoaFisica novaPF = new PessoaFisica();
Endereco novoEndPf = new Endereco();


novaPF.nome = "Abílio Tavares Viana Filho";
novaPF.cpf = 6584123;
novaPF.dataNasc = new DateTime(1979, 01, 15);

novaPF.rendimento = 7000;

novoEndPf.logradouro = "Rua Niteroi";
novoEndPf.numero = 180;
novoEndPf.complemento = "Senai Informática";
novoEndPf.endComercial = true;

novaPF.endereco = novoEndPf;

Console.WriteLine(@$"

Nome: {novaPF.nome}
CPF: {novaPF.cpf}
Data de nascimento: {novaPF.dataNasc}
Endereço: {novoEndPf.logradouro} , {novoEndPf.numero} , {novoEndPf.complemento} , {novoEndPf.endComercial}
Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}

");




//Console.WriteLine(novaPF.nome);
//Console.WriteLine(novaPF.cpf);
//Console.WriteLine(novaPF.dataNasc);
//Console.WriteLine(novaPF.endereco);
//Console.WriteLine(novaPF.rendimento);

//Concatenação

//Console.WriteLine("Nome do funcionário: " + novaPF.nome);

//Interpolação
//Console.WriteLine($"Nome do funcionário: {novaPF.nome} - CPF: {novaPF.cpf} - Data de Nascimento: {novaPF.dataNasc} - Endereço: {novaPF.endereco} - Rendimento: {novaPF.rendimento}");

//novaPF.CalcularImposto(novaPF.rendimento);
//Console.WriteLine(novaPF.CalcularImposto(novaPF.rendimento));

//Verificação de idade

//DateTime datNascimento = new DateTime(2015,12,06);
//Console.WriteLine(novaPF.ValidadarDataNasc(dat1));


//DateTime date1 = DateTime.Now;
//DateTime date2 = DateTime.UtcNow;
//DateTime date3 = DateTime.Today;



//Console.WriteLine(date1);
//Console.WriteLine(date2);
//Console.WriteLine(date3);

//var dataResult = date3 - datNascimento;

//WriteLine(dataResult.TotalDays/365);

//Console.WriteLine(novaPF.ValidadarDataNasc(datNascimento));
//Console.WriteLine(novaPF.ValidarDataNasc("26-02-2010"));


//----------------------------------------Pessoa Jurídica----------------------------------------------------------------------


//PessoaJuridica novaPj = new PessoaJuridica();
//float x = novaPj.rendimento = 16600.3f;
//Console.WriteLine(novaPj.CalcularImposto(x));

//float impostoPagar = novaPJ.CalcularImposto(10000.5f);
//Console.WriteLine($ "O imposto a pagar será de: {impostoPagar: 0.00}");
//Console.WriteLine(impostoPagar.ToString("C"));

