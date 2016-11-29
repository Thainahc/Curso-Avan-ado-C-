using System;
using System.Text;

namespace Objects
{
    class Program
    {
        public class Cliente : object // Reference Type
        {
            public int Codigo;
            public string Nome;
            public string Telefone;
            public override string ToString()
            {
                StringBuilder string1 = new StringBuilder();
                string1.AppendLine("Codigo: " + Codigo);
                string1.AppendLine("Nome: " + Nome);
                string1.AppendLine("Telefone: " + Telefone);

                return string1.ToString();
            }
        }

        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            Cliente cliente2 = cliente1;
            //Cliente cliente2 = new Cliente();

            cliente1.Codigo = 1;
            cliente1.Nome = "Pudim";
            cliente1.Telefone = "9898998";

            cliente2.Nome = "Café";

            Console.WriteLine(cliente1);
            Console.WriteLine(cliente2);

            if (cliente1.Equals(cliente2))
            {
                Console.WriteLine("cliente1 e cliente2 são os mesmos objetos");
            }
            else
            {
                Console.WriteLine("cliente1 e cliente2 são objetos diferentes");
            }

            Console.ReadKey();

        }
    }
}
