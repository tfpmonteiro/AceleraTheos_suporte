using System;
using System.Globalization;

/*3. Calcular o consumo de combustivel numa determinada distancia. (Km/l)
1. Solicitar Kilometragem inicial.
2. Solicitar Kilometragem final.
3. Solicitar quantidade de litros gasto
OBS: Deve ser considerado apenas a parte inteira do valor.*/
namespace Aula04_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a kilometragem inicial do percurso: ");
            int kminicial = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a kilometragem final do percurso: ");
            int kmfinal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a quantidade de combustível gasto, em litros: ");
            int combustivel = Convert.ToInt32(Console.ReadLine());

            int consumo = (kmfinal - kminicial) / combustivel;

            Console.WriteLine($"O percurso foi realizado com uma média de {consumo.ToString("n2", new CultureInfo("en-us"))} km/l.");
            Console.ReadKey();
        }
    }
}
