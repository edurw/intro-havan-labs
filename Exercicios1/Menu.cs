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
        List<Data.Usuario> lista = new List<Data.Usuario>();
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
                    ModuloUsuario moduloUsuario = new ModuloUsuario();
                    moduloUsuario.Create();
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

        public void ExibirCabecalhoDadosCadastro()
        {
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("DADOS DO USUÁRIO CADASTRADO");
            Console.WriteLine("----------------------------------------------");

            foreach (Usuario u in lista)
            {
                Console.WriteLine("Nome: " + u.Nome + "\nSobrenome: " + u.Sobrenome + "\nIdade: " + u.Idade + "\ne-mail: " + u.Email.ToLower() + "\nEndereço: " + u.Endereco);
            }
        }

        /*public static void ExibirDadosUsuario()
        {
            int nome = Cadastro.Cadastro(nome);
            Console.WriteLine("Nome: " + nome + "   Sobrenome: " + sobrenome + "   Idade: " + idade + "   e-mail: " + email + "   Endereço: " + endereco);
        }*/

    }
}
