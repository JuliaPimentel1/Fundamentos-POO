using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    // Classe Professor que herda da classe Pessoa
    public class Professor : Pessoa
    {
        public string Especialidade { get; set; }
        public int Registro { get; set; }
        public double Salario { get; set; }

        //Sobrecarga do metodo Apresentar da classe Pessoa
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Sou especialista em {Especialidade}, meu registro é {Registro} e meu salário é {Salario:C}.");
        }
    }
}
