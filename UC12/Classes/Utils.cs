using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC12.Classes
{
    public static class Utils
    {

        public static void BarraCarregamento(string textoBarra)
        {
            Console.Clear();
            Console.Write($"{textoBarra}");

            for (var contador = 0; contador < 6; contador++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }




            Console.Clear();
        }


    }
}