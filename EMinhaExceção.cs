using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_Exceções___pt._2
{
    class EMinhaExceção : Exception
    {
        int numero = 0, soma = 0;
        public EMinhaExceção(string msg)
        {

        }

        public static int Somatorio(int _num, int _soma)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Clear();
                Console.Write("Digite um número: ");
                _num = int.Parse(Console.ReadLine());
                _soma = _soma + _num;
            }
            return _soma;
        }
    }
}
