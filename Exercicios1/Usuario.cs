using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1
{
    public class Usuario
    {
        public string nome = String.Empty;
        public string sobrenome = String.Empty;
        public int idade = 0;
        public string email = String.Empty;
        public string endereco = String.Empty;

        public void Cadastro()
        {
            Console.Write("Nome: ");
            this.nome = Data.Validacao.ValidaStringEmBranco();
            //Console.WriteLine(nome.Trim().Replace(" ", "").Length);
            Console.Write("Sobrenome: ");
            this.sobrenome = Data.Validacao.ValidaStringEmBranco();
            Console.Write("Idade: ");
            this.idade = Data.Validacao.ValidaInteiros();
            Console.Write("e-mail: ");
            this.email = Data.Validacao.ValidaStringEmBranco();
            Console.Write("Endereço: ");
            this.endereco = Data.Validacao.ValidaStringEmBranco();
            //Console.WriteLine("\n");

            Menu.ExibirCabecalhoDadosCadastro();

            Console.WriteLine("Nome: " + this.nome + "\nSobrenome: " + this.sobrenome + "\nIdade: " + this.idade + "\ne-mail: " + this.email.ToLower() + "\nEndereço: " + this.endereco);
        }

        public static void Escolha2()
        {

        }
    }
}
