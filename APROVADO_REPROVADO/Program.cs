using System;
using System.Globalization;

namespace APROVADO_REPROVADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com suas duas notas: ");
            double n1 = double.Parse(Console.ReadLine()); 
            double n2 = double.Parse(Console.ReadLine());

            double media = (n1 + n2) / 2;

            if (media < 60.0)
            {
                Console.WriteLine("MÉDIA FINAL = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
            else 
            {
                Console.WriteLine("MÉDIA FINAL = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO!");
            }
            
        }
    }
}
