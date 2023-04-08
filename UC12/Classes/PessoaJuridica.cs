using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UC12.Interfaces;

//Adicionar à classe base de PessoaJuridica. e PessoaFisica, o método de PagarImposto, seguindo as seguintes instruções:
//- Pessoa jurídica
//Para Rendimentos até 3000, 3%
//Para rendimentos entre 3000 e 6000, 5%
//Para rendimentos entre 6000 e 10000, 7%
//Para rendimentos acima de 10000, 9%


namespace UC12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public string? Caminho { get; private set; } = "DataBase/PessoaJuridica.csv";
        
        

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                float resultado = rendimento * 0.03f;
                return resultado;

            } else if (rendimento > 3000 && rendimento <= 6000)
            {
                float resultado = rendimento * 0.05f;
                return resultado;

            } else if (rendimento > 6000 && rendimento <= 10000)
            {
                float resultado = rendimento * 0.07f;
                return resultado;

            } else 
            {
                float resultado = rendimento * 0.09f;
                return resultado;
            }
        }

        public bool ValidarCnpj(string cnpj)
            // fonte: https://www.4devs.com.br/
            // 18  CARACTERES - 31.876.411/0001-79
            // 14 CARACTERES - 27379542000173
        {
            bool retornoCnpjValido14 = Regex.IsMatch(cnpj, @"^(\d{14})$"); 
            
            if (retornoCnpjValido14)
            {
                string subStringCnpj14 = cnpj.Substring(8, 4);

                if (subStringCnpj14 == "0001")
                {
                    return true;
                }

            }

            
            bool retornoCnpjValido18 = Regex.IsMatch(cnpj, @"^(\d{18}|\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$"); 
            
            if (retornoCnpjValido18)
            {
                   string subStringCnpj18 = cnpj.Substring(11, 4);

                if (subStringCnpj18 == "0001")
                {
                    return true;
                }
            }
         
        return false;
        
        }

       public void Inserir(PessoaJuridica pj)
        {

            Utils.VerificarPastaArquivo(Caminho);
            string[] pjString = { $"{pj.razaoSocial} , {pj.endereco} ,{pj.cnpj}, {pj.rendimento}" };

            File.AppendAllLines(Caminho, pjString);

        }

        public List<PessoaJuridica> LerArquivo()
        {

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();
            string[] linhas = File.ReadAllLines(Caminho);


            foreach (var cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }


    }
}