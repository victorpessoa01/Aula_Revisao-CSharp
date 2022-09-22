using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Texto();
            TiposDeDados();
            EntradaDeDados();
            lacoIf();
            lacoWhile();
            lacoFor();
        }

        static void Texto()
        {
            int nume1, nume2 = 5;

            Console.WriteLine("TaBuada do 5");

            Console.WriteLine("Digite um numero");
            nume1 = int.Parse(Console.ReadLine());
            
            int resultado = nume1 * nume2;

        }
        static void TiposDeDados()
        {
            bool Verdade = true, Errado = false;
            int num = 4;
            double nota = 5.6;
            float celses = 35f;
            const char letra = 'V';
            string nome = "Victor Pessoa";

            Console.WriteLine(num + " " + nota + " " + celses + " " + letra + " " + nome);
        }
        static void EntradaDeDados()
        {
            int numero;
            double real;
            string caract;

            Console.WriteLine("Digite seu nome");
            caract = Console.ReadLine();
            
            Console.WriteLine("insira um numero INTEIRO");
            numero = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("insira um numero REAL");
            real = double.Parse(Console.ReadLine());

        }
        static void lacoIf()
        {
            int numero = 1, numero2 = 14;

        }
        static void lacoWhile()
        {

        }
        static void lacoFor()
        {

        }
    }
}