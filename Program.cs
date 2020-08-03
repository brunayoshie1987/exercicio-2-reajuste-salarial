using System;

namespace Exercicio_2___Reajuste_Salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salário");

            var salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o reajuste em % (10%, 20%, 30% - Não colocar o sinal de %)");

            var reajuste = Convert.ToDouble(Console.ReadLine());

            var valorReajuste = salario * (reajuste / 100);

            var valorComReajuste = salario + valorReajuste;

            Console.WriteLine("O salário com reajuste ficou em " + valorComReajuste);

            Console.ReadLine();
        }
    }
}
