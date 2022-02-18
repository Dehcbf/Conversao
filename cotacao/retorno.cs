using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Conversão.cotacao
{
    public class retorno
    {
        public async Task Resultado(double valor){
            var client = new HttpClient();
            string contentRUB = await client.GetStringAsync("https://economia.awesomeapi.com.br/last/BRL-RUB");
            Moeda moeda = JsonSerializer.Deserialize<Moeda>(contentRUB);
            double valorFinalRUB = Convert.ToDouble(moeda.BRLRUB.high.Replace(".", ",")) * valor;
            Console.WriteLine("O valor convertido em Rublo Russo é: " + valorFinalRUB);
            string contentUSD = await client.GetStringAsync("https://economia.awesomeapi.com.br/last/RUB-USD");
            moeda = JsonSerializer.Deserialize<Moeda>(contentUSD);
            double valorFinalUSD = Convert.ToDouble(moeda.RUBUSD.high.Replace(".", ",")) * valorFinalRUB;
            Console.WriteLine("O valor convertido em Dólar é: " + valorFinalUSD);
        }
    }
}