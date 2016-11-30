using System;

namespace Propriedades
{
    class Program
    {
        public class MensalidadeNegativaException : Exception
        {
            public MensalidadeNegativaException(string message)
                :base(message)
            {

            }
        }

        public enum TipoAluno
        {
            Regular, Especial
        }

        public class Aluno
        {
            private int _matricula; // Fields
            private string _nome;
            private double _mensalidade;
            private TipoAluno _tipo;


            public int Matricula // Propriedades com Encapsulamento e exposição
            {
                get { return _matricula; }
                set { _matricula = value; }
            }

            public string Nome
            {
                get{ return _nome; }
                set{ _nome = value; }
            }

            public double Mensalidade
            {
                get{ return _mensalidade; }
                set{
                    if (value < 0)
                        throw new MensalidadeNegativaException("Mensalidade com valor negativo");
                    else
                        _mensalidade = value;
                }
            }

            internal TipoAluno Tipo
            {
                get{ return _tipo; }
                set{ _tipo = value; }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Aluno aluno1 = new Aluno();
                aluno1.Matricula = 1;
                aluno1.Nome = "Thainá";
                aluno1.Mensalidade = -1.00;
            }
            catch (MensalidadeNegativaException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }

            //Console.WriteLine(aluno1);
            Console.ReadLine();

        }
    }
}
