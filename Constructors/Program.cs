using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }
    public class Cliente
    {
        public int Id;
        public string Nome;
        public Contato Contato;

        public Cliente() // Construtor
        {
            Id = 0;
            Nome = "sem nome";
            Contato = new Contato();
        }

        public Cliente (int id) // Overload
        {
            Id = id;
            Nome = "sem nome";
            Contato = new Contato();
        }

        public Cliente (int id, string nome) // Overload
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString()
        {
            return "ID: "+Id.ToString()+", Nome: "+Nome;
        }
    }

    public class ClienteVip: Cliente // Herança
    {
        public int Tempo;
        public ClienteVip(int id)
            :base(id) // Chamando construtor da classe base
        {
            Tempo = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nome = "Thainá";
            cliente1.Contato.Tipo = "Telefone";
            cliente1.Contato.Descricao = "9999-9999";

            Cliente cliente2 = new Cliente(2);
            Cliente cliente3 = new Cliente(3, "Fulano");
            ClienteVip cliente4 = new ClienteVip(4);

            Console.WriteLine(cliente4);
            Console.ReadLine();
        }
    }
}
