using System;

namespace CsE8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 8
            Console.WriteLine("Descobrindo par/impar\n\nINFORME UM VALOR: ");
            int v = int.Parse(Console.ReadLine());
            //SE VALOR FOR DIVISIVEL POR 2 É PAR CASO CONTRARIO IMPAR
            if (v % 2 == 0)
                Console.WriteLine("\nNUMERO PAR");
            else 
                Console.WriteLine("\nNUMERO IMPAR");
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
