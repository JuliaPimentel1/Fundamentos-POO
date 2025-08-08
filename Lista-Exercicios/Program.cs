using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio04
{
    public class Carro
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            //this.Velocidade = this.Velocidade + 1;
            this.Velocidade++;
        }

        public void Desacelerar()
        {
            if (this.Velocidade > 0)
            {
                this.Velocidade--;
            }
        }

        public Carro(string marca, string modelo, int velocidade)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Velocidade = velocidade;
        }

    }
    ﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio05
    {
        public class Funcionario : Pessoa
        {
            public Funcionario(string nome, int idade, string? cargo) : base(nome, idade)
            {
                this.Cargo = cargo;
            }

            public string? Cargo { get; set; }
        }
    }
    sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio05
    {
        public class Pessoa
        {
            public string? Nome { get; set; }
            public int Idade { get; set; }

            public Pessoa(string nome, int idade)
            {
                this.Nome = nome;
                this.Idade = idade;
            }
            public void Envelhecer(int anos)  // Método para envelhecer com parametro de anos
            {
                if (anos > 0) // Verifica se o número de anos é positivo
                {
                    this.Idade += anos; // Incrementa a idade da pessoa
                }
                Console.WriteLine($"{this.Nome} agora tem {this.Idade} anos."); // Exibe a nova idade da pessoa
            }
        }
    }
    using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace Lista_Exercicios.Exercicio06 { public class Animal { public string? Especie { get; set; } public void EmitirSom() { Console.WriteLine($"O animal da espécie {Especie} está emitindo um som."); } } }


