using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1
{
    class Program
    {
        //1 - Crie um projeto do tipo console aplication em C# com .Net Framework V4.7.2
        //2 - Crie uma aplicação para cadastro de usuário, que contenha os seguintes dados: Nome, Sobrenome, Idade, E-mail, Endereço
        //3 - Exiba os dados do usuário cadastrado ao final da execução do programa
        //4 - Os dados do usuário devem ser impressos em uma única linha.

        static void Main(string[] args)
        {
            //int idade = 0;
            Menu.MontaMenu();
            Console.ReadLine();
        }
    }
}