// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using UC12.Classes;


Console.Clear();

Utils.BarraCarregamento("Carregando o sistema");


Console.Clear();


Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine(@"

-----------------------------------------------------------------------------------------------
|                              Bem vindo ao nosso sistema de Cadastro de                      |
|                                   Pessoas Físicas e Jurídicas                               |
-----------------------------------------------------------------------------------------------

");

Thread.Sleep(3000);
Console.Clear();

Console.ResetColor();

string? opcao;

do
{
    Console.WriteLine(@"

-----------------------------------------------------------------------------------------------
|                              Escolha uma das opções abaixo:                                 |
|---------------------------------------------------------------------------------------------|
|                                     1 - Pessoa Física                                       |
|                                     2 - Pessoa Jurídica                                     |
|                                                                                             |
|                                     3 - Sair do Sistema                                     |
-----------------------------------------------------------------------------------------------

");
    Console.ResetColor();





    Console.WriteLine($"Digite uma das opções acima e tecle enter.");


    opcao = Console.ReadLine();

    //Console.WriteLine($"O texto digitado foi: {digitacao}");

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Pessoa física seleciona");

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

            Console.WriteLine($"Tecle 'Enter' para continuar.");
            Console.ReadLine();

            break;

        case "2":
            Console.WriteLine($"Pessoa Jurídica Selecionada");

            //----------------------------------------Pessoa Jurídica----------------------------------------------------------------------


            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Abílio Viana Corps";
            novaPj.cnpj = "42.653.716/0001-38";
            novaPj.rendimento = 200.000f;

            novoEndPj.logradouro = "Tv. Colômbia";
            novoEndPj.numero = 2872;
            novoEndPj.complemento = "Empresa Senai Informática";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.WriteLine(@$"

            Nome da razão social: {novaPj.nome}
            CNPJ: {novaPj.cnpj} - Válido: {novaPj.ValidarCnpj(novaPj.cnpj)}
            Endereço: {novoEndPj.logradouro} , {novoEndPj.numero}
            Complemento: {novoEndPj.complemento} 
            Endereço comercial: {novoEndPj.endComercial}
            ");


            //Console.WriteLine(novaPj.ValidarCnpj("42.653.716/0001-38"));





            //float x = novaPj.rendimento = 16600.3f;
            //Console.WriteLine(novaPj.CalcularImposto(x));

            //float impostoPagar = novaPJ.CalcularImposto(10000.5f);
            //Console.WriteLine($ "O imposto a pagar será de: {impostoPagar: 0.00}");
            //Console.WriteLine(impostoPagar.ToString("C"));


            Console.WriteLine($"Tecle 'Enter' para continuar.");
            Console.ReadLine();

            break;


        case "0":
            Console.WriteLine($"Saindo do sistema");
            break;
        default:
            Console.WriteLine($"Opção não encontrada. Digite o valor correto");
            Thread.Sleep(4000);
            break;
    }


    /* if (opcao == "1")
    {
        Console.WriteLine($"Pessoa física seleciona");
    }

    else if (opcao == "2")
    {
        Console.WriteLine($"Pessoa Jurídica Selecionada");
    }

    else if (opcao == "3")
    {
        Console.WriteLine($"Saindo do sistema");
    }
    else
    {
        Console.WriteLine($"Opção não encontrada");
    }

    */




    Console.Clear();


} while (opcao != "0");


Utils.BarraCarregamento("Finalizando");

//Console.Clear();









