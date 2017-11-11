using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_Exceções___pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, num = 0;

            for (int i = 0; i < 100; i++)
            {
                EMinhaExceção.Somatorio(num, soma);
            }
            soma = soma / 100;
            //throw new EMinhaExceção("");

        }
    }
}
