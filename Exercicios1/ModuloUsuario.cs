using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Exercicios1
{
    class ModuloUsuario
    {
        UsuarioRepository repository = new UsuarioRepository();
        public void Create()
        {
            string resposta = "";
            do
            {
                Console.Write("Nome: ");
                string nome = Validacao.ValidaStringEmBranco();
                Console.Write("Sobrenome: ");
                string sobrenome = Validacao.ValidaStringEmBranco();
                Console.Write("Idade: ");
                int idade = Validacao.ValidaInteiros();
                Console.Write("e-mail: ");
                string email = Validacao.ValidaStringEmBranco();
                Console.Write("Endereço: ");
                string endereco = Validacao.ValidaStringEmBranco();

                Usuario model = new Usuario(nome, sobrenome, idade, email, endereco);
                repository.Create(model);
                Console.WriteLine("Deseja cadastrar mais um? (y/n)");
                resposta = Console.ReadLine();

                Console.WriteLine($"Usuario {model.Nome} cadastrado com sucesso!");

                //Menu.ExibirCabecalhoDadosCadastro();

            } while (resposta == "y");

        }
    }
}
