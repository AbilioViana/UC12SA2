using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC12.Interfaces;

//Adicionar à classe base de PessoaJuridica. e PessoaFisica, o método de PagarImposto, seguindo as seguintes instruções:

//- Pessoa física
//Para rendimentos até 1500, isento
//Para rendimentos entre 1500 e 3500, 2%
//Para rendimentos entre 3500 e 6000, 3,5%
//para rendimentos acima de 6000, 5%



namespace UC12.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public int cpf { get; set; }
        public DateTime dataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento / 100) * 2;
                return resultado;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                float resultado = (rendimento / 100) * 3.5f;
                return resultado;
            }
            else
            {
                float resultado = (rendimento / 100) * 5;
                return resultado;
            }

        }

        public bool ValidadarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }

            return false;

            }

        public bool ValidarDataNasc(string dataNasc)
        {
            if (DateTime.TryParse(dataNasc, out DateTime dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            return false;
        }

}

}

