using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    //Exemplo de classe Pessoa
    public class Pessoa
    {
        public string Nome { get; set; }
        public int? CPF { get; set; }
        public DateOnly DataNascimento { get; set; }

        //Metodos da classe Pessoa
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {DataNascimento} anos e meu CPF é {CPF} e eu nasci em {DataNascimento} ");
        }
        public Pessoa() { }
        public Pessoa(string nome, int cpf, DateOnly dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }
    }
}
