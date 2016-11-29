using System;

namespace Structs
{
    public class PosicaoClass
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return "X = " + x.ToString() + ", Y = " + y.ToString();
        }
    }

    public struct PosicaoStrutc
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return "X = " + x.ToString() + ", Y = " + y.ToString();
        }
        /*public string ToString() //Anula a classe básica, pois o método tem o mesmo nome do ToString() da classe base, pois não utilizamos o override
        {
            return "X = " + x.ToString() + ", Y = " + y.ToString();
        }*/
    }

    public enum Role
    {
        Arquiteto, Developer, Tester
    }

    public enum Color
    {
        Red = 0, Green = 1, Blue = 2
    }

    class Program
    {
        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.x = 10;
            pos1.y = 20;

            PosicaoStrutc pos2 = new PosicaoStrutc();
            pos2.x = 30;
            pos2.y = 40;

            PosicaoStrutc pos3 = pos2; // Cópia pois structs são ValueTypes
            pos3.y = 50;

            Color color = Color.Green;
            Role role = Role.Arquiteto;

            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(pos3);
            Console.WriteLine(color);
            Console.WriteLine(role);

            /*Console.WriteLine(pos2.ToString()); // Não foi polimfórmico, por isso o ToString()
            Console.WriteLine(pos3.ToString()); */

            Console.ReadLine();
        }
    }
}
