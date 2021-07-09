using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Crie um projeto do tipo console aplication em C# com .Net Framework V4.7.2
            //2 - Crie uma aplicação para cadastro de usuário, que contenha os seguintes dados: Nome, Sobrenome, Idade, E-mail, Endereço
            //3 - Exiba os dados do usuário cadastrado ao final da execução do programa
            //4 - Os dados do usuário devem ser impressos em uma única linha.

            int idade = 0;

            Console.WriteLine("===============================================");
            Console.WriteLine("CADASTRO DE USUÁRIO");
            Console.WriteLine("===============================================");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();
            do
            {
                Console.Write("Idade: ");
                try
                {
                    idade = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("CARACTERE INVÁLIDO!");
                }
            } while (idade == 0);
            Console.Write("e-mail: ");
            string email = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Nome: " + nome + "   Sobrenome: " + sobrenome + "   Idade: " + idade + "   e-mail: " + email + "   Endereço: " + endereco);
        }
    }
}