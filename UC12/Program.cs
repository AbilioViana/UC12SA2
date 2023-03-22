
//Sistema de Cadastro de pessoas físicas

using System;
using UC12.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();
string? opcao;

Console.Clear();
Console.ResetColor();

Utils.BarraCarregamento("Inicializando");

//Menu de boas vindas

Console.WriteLine(@$"
 ------------------------------------------------------------------
 |            Seja bem vindo ao Sistema de Cadastro de            |
 |                   Pessoas Físicas e Jurídicas                  |
 ------------------------------------------------------------------
");

Thread.Sleep(2000);
Console.Clear();


//Menu opções Geral

do
{
    Console.WriteLine(@$"
 ------------------------------------------------------------------
 |                 Escolha uma opção abaixo:                      |
 ------------------------------------------------------------------
 |                   1 - Pessaoa Física                           |
 |                   2 - Pessaoa Jurídica                         |
 |                                                                |
 |                   0 - Sair do Sistema                          |   
 ------------------------------------------------------------------
");
    Console.ResetColor();

    Console.WriteLine($"Digite uma das opções acima e tecle 'Enter' !");
    opcao = Console.ReadLine();
    // Console.WriteLine($" O texto digitado foi: {digitacao}");

    switch (opcao)
    {
        case "1":

            string? opcaoPf;


//Menu opções para pessoas físicas

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
 ------------------------------------------------------------------
 |                 Escolha uma opção abaixo:                      |
 ------------------------------------------------------------------
 |                   1 - Cadastrar Pessoa Física                  |
 |                   2 - Listar Pessoa Física                     |
 |                                                                |
 |                   0 - Volta ao menu anterior                   |   
 ------------------------------------------------------------------
");

                opcaoPf = Console.ReadLine();


//Input de dados para pessoa física


                switch (opcaoPf)
                {
                    case "1":
                        //metodo construtor
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da Pessoa Física, tecle 'ENTER' para continuar.");
                        novaPf.nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento (Ex: DD/MM/AAAA), 'ENTER' para continuar.");
                            string? dataNascimento = Console.ReadLine();

                            dataValida = novaPf.ValidarDataNasc(dataNascimento);

                            if (dataValida == true)
                            {
                                DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                                novaPf.dataNasc = dataConvertida;
                            }
                            else
                            {
                                Console.WriteLine($"Erro; Data inválida, digite um valor válido. Tecle Enter pra continuar");
                                Console.ReadLine();
                            }


                        } while (dataValida == false);


                        Console.WriteLine($"Digite o CPF da Pessoa Física, tecle 'ENTER' para continuar.");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o Rendimento da Pessoa Física, tecle 'ENTER' para continuar.");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o nome da rua da Pessoa Física, tecle 'ENTER' para continuar.");
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero do endereço da Pessoa Física, tecle 'ENTER' para continuar.");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento, tecle 'ENTER' para continuar.");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é Comercial? Digite S ou N ?");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }

                        novaPf.endereco = novoEndPf;

                        listaPf.Add(novaPf);

                        Console.WriteLine($"Objeto adicionado na lista!");
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();
                        if (listaPf.Count > 0)
                        {

                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.WriteLine(@$"
                            
                            NOME: {cadaPessoa.nome}
                            LOGRADOURO: {cadaPessoa.endereco.logradouro}, NUMERO {cadaPessoa.endereco.numero}, COMPLEM. {cadaPessoa.endereco.complemento}
                            RENDIMENTO MENSAL.: {cadaPessoa.rendimento.ToString("C")}
                            IMPOSTO A PAGAR: {cadaPessoa.CalcularImposto(cadaPessoa.rendimento).ToString("C")}
                            DATA NASC.: {cadaPessoa.dataNasc.ToString("d")}
                            ");

                                Console.WriteLine($"Tecle Enter para continuar a lista");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia, cadastre uma nova Pessoa Física.");
                            Thread.Sleep(4000);
                            Console.Clear();
                        }

                        break;

                    case "0":
                        Console.WriteLine($"Voltando ao menu anterior");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.WriteLine($"Valor não encontrado, digite um valor correto (1, 2 ou 0)");
                        Thread.Sleep(4000);
                        break;
                }


            } while (opcaoPf != "0");



            
            break;
 // Menu opções para pessoa jurídica

        case "2":
            Console.WriteLine($"Pessoa Jurídica Selecionada");
           
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();





            novaPj.razaoSocial = "Viana Corps";
            novaPj.cnpj = "31.876.411/0001-79";
            novaPj.rendimento = 200000.00f;

            novoEndPj.logradouro = "Tv. Colômbia";
            novoEndPj.numero = 2872;
            novoEndPj.complemento = "Sala 100";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.WriteLine(@$"
            Nome da Razão Social: {novaPj.razaoSocial}
            Endereço: {novoEndPj.logradouro}, {novoEndPj.numero}
            CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
            ");

           
            Console.WriteLine($"Tecle 'Enter' para continuar!");
            Console.ReadLine();
            break;

        case "0":
            
            break;


        default:
            Console.WriteLine($"Valor não encontrado, digite um valor correto (1, 2 ou 0)");
            Thread.Sleep(4000);
            break;
    }

    Console.Clear();
} while (opcao != "0");

Utils.BarraCarregamento("Finalizando");

//Console.Clear();




