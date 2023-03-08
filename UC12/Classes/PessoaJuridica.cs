using System;
using System.Collections.Generic;
using System.Linq;
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
        public int cnpj { get; set;}

        public string? razaoSocial { get; set;}

        public override float CalcularImposto(float rendimento)
        {
            if(rendimento <= 3000)
           {
                float resultado = (rendimento / 100) * 3;
                return resultado;

           } else if (rendimento >3000 && rendimento<=6000)
           {

                float resultado = (rendimento / 100) * 5;
                return resultado;

           }else if (rendimento >6000 && rendimento<=10000)
           {

                float resultado = (rendimento / 100) * 7;
                return resultado;
                

           }else
           {

                float resultado = (rendimento / 100) * 9;
                return resultado;
                
           }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}