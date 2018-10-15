using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do funcionário?");
            string funcionario = Console.ReadLine();

            Console.WriteLine($"Qual é o salário atual do(a) {funcionario}");
            double salario = Convert.ToDouble(Console.ReadLine());

            double ajuste = (salario * 5) / 100;
            salario = salario + ajuste;

            Console.WriteLine($"O salário do(a) {funcionario} recebeu um ajuste de {ajuste.ToString("c")} e agora corresponde a {salario.ToString("c")}");
            Console.ReadKey();
        }
    }
}
