using System;

namespace Samples
{
    class Program
    {
        public class PosicaoClass // ReferenceType
        {
           public int x;
           public int y;
        }

        public static void Dobrar(ref int valor)
        {
            valor = valor * 2;
        }

        public static void Dobrar( PosicaoClass valor)
        {
            valor.x = valor.x * 2;
            valor.y = valor.y * 2;
        }

        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();

            pos1.x = 20;
            pos1.y = 40;

            PosicaoClass pos2 = new PosicaoClass();

            pos2.x = 30;
            pos2.y = 50;

            pos2 = pos1; // Apontam para a mesma posição de memória
            pos2.x = 10;

            //Dobrar(ref pos2.x);
            Dobrar(pos2);
            
            Console.WriteLine(pos1.x);
            Console.WriteLine(pos1.y);
            Console.WriteLine(pos2.x);
            Console.WriteLine(pos2.y);

            Console.ReadLine();
        }
    }
}
