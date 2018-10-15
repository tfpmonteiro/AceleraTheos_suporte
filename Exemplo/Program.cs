using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/pt-br/dotnet/api/system.string?view=netframework-4.7.2
            Console.WriteLine("STRING: MANIPULAÇÃO");

            string nome = "Thiago Borges";

            //indexOf
            var indicei = nome.IndexOf(" "); //conta quantos itens tem até o " ". Neste caso 6
            Console.WriteLine($"Indice: {indicei}");
            
            //substring
            var sobrenome = nome.Substring(indicei); // armazena em sobrenome o resultado da string a partir do indicei (6)
            Console.WriteLine($"Substring: {sobrenome.Trim()}");
            
            //isNullOrEmpty
            bool vazia = string.IsNullOrEmpty(nome.Trim());

            //isNullOrEmpty
            bool vaziaEspaco = string.IsNullOrWhiteSpace(nome);
            Console.WriteLine($"Vazia: {vaziaEspaco}");

            //replace
            nome = nome.Replace("g", "f");
            Console.WriteLine($"Nome: {nome}");

            //toUpper e toLower
            nome = nome.ToUpper();
            Console.WriteLine($"Nome: {nome}");

            Console.WriteLine($"Sobrenome: {sobrenome}");

            //https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings
            Console.WriteLine("TO STRING - FORMATAÇÃO");

            decimal valor = 100000000000;

            int numero = 9;

            Console.WriteLine($"Valor: {valor.ToString("c")}");
            Console.WriteLine($"Valor: {valor.ToString("c", new CultureInfo("en-US"))}");
            Console.WriteLine($"Numero: {numero.ToString("f2")}");
            Console.WriteLine($"Valor: {valor.ToString("n2", new CultureInfo("en-US"))}");

            Console.WriteLine($"Valor: {valor:c}");
            Console.WriteLine($"Numero: {numero:d2}");
            Console.WriteLine($"Valor: {valor:n2}");
            
            Console.ReadKey();
        }
    }
}
