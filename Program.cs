using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Conversão.cotacao;

namespace Conversão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Infome um valor entre 1 a 100");
            var valor = Convert.ToDouble(Console.ReadLine());
            
            new retorno().Resultado(valor).Wait();
        }

    }
}
