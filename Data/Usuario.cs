using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        private int _idade;
        public int Idade 
        {
            get
            {
                return this._idade;
            }
            set
            {
                if (value > 0)
                {
                    this._idade = value;
                }
                else
                {
                    throw new Exception("Valor inválido!");
                }
            } 
        }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Usuario(string nome, string sobrenome, int idade, string email, string endereco)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.Email = email;
            this.Endereco = endereco;
        }

        public Usuario()
        {

        }
    }
}
