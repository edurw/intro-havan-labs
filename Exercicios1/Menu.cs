using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Exercicios1
{
    class Menu
    {
        public static void MontaMenu()
        {
            Cabecalho();
            //Cabeçalho, opções, rodapé, escolha
            Opcoes();
            Rodape();
            Escolha();
        }
        
        private static void Cabecalho()
        {
            Console.WriteLine(@"///////////////// HAVAN LABS \\\\\\\\\\\\\\\\\"+"\n");
            Console.WriteLine("-------------- PAINEL DE OPÇÕES --------------");
        }

        private static void Opcoes()
        {
            Console.WriteLine("\t0 - Sair\n\t1 - Cadastro de Usuário\n\t2 - Cadastro de Produto");
        }

        private static void Rodape()
        {
            Console.WriteLine("----------------------------------------------");
            Console.Write("Escolha da opção: ");
        }

        private static void Escolha()
        {
            int opcao = 0;
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 0:
                    break;
                case 1:
                    string resposta = "";
                    List<Usuario> usuarios = new List<Usuario>();
                    do
                    {
                        Usuario user = new Usuario();
                        user.Cadastro();
                        Console.WriteLine("Deseja cadastrar mais um? (y/n)");
                        resposta = Console.ReadLine();
                        usuarios.Add(user);
                        Console.WriteLine($"Usuario {user.nome} cadastrado com sucesso!");
                    } while (resposta == "y");
                    break;
                case 2:
                    Console.WriteLine("Em desenvolvimento");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    //Console.Clear();
                    break;
            }
            //return Validacao.ValidaInteiros();
        }

        public static void ExibirCabecalhoDadosCadastro()
        {
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("DADOS DO USUÁRIO CADASTRADO");
            Console.WriteLine("----------------------------------------------");
        }

        /*public static void ExibirDadosUsuario()
        {
            int nome = Cadastro.Cadastro(nome);
            Console.WriteLine("Nome: " + nome + "   Sobrenome: " + sobrenome + "   Idade: " + idade + "   e-mail: " + email + "   Endereço: " + endereco);
        }*/

    }
}
