using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Program
    {
        public class Conta
        {
            private string _cliente; // Encapsulamento
            private double _valor;

            public string getCliente()
            {
                return _cliente;
            }

            public void setCliente(string value)
            {
                _cliente = value;
            }

            public void Saque(double valor)
            {
                _valor = _valor - valor;
            }

            public void Deposito(double valor)
            {
                _valor = _valor + valor;
            }

            public double getValor()
            {
                return _valor;
            }
        }

        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            conta1.setCliente("Thainá");
            conta1.Deposito(1000.00);
            conta1.Saque(0.01);

            Console.WriteLine(conta1.getCliente());
            Console.WriteLine(conta1.getValor());
            Console.ReadLine();
        }
    }
}
