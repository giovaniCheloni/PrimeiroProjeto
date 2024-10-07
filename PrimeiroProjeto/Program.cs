using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua senha: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x != 2002)
            {
                Console.WriteLine("Senha Invalida!");                
                Console.Write("Digite sua senha: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Acesso Permitido");
        }
    }

}