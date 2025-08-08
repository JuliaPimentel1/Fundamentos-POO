using Aula_02;

Console.WriteLine("Hello, World!");


Pessoa pessoa1 = new Pessoa
{
    Nome = "João",
    CPF = 123456789,
    DataNascimento = new DateOnly(1990, 2, 7)
};

pessoa1.Apresentar();

Console.WriteLine("\n-----------------------------");

Console.WriteLine("Criando um objeto Aluno Herdado de Pessoa");
Aluno aluno1 = new Aluno();
aluno1.Nome = "Carlos";
aluno1.CPF = 123456789;
aluno1.DataNascimento = new DateOnly(2000, 1, 1);
aluno1.Curso = "Engenharia";
aluno1.Matricula = 2021001;

Console.WriteLine("\n-----------------------------");

//Instanciando um objeto da classe Professor
Professor professor1 = new Professor();
Professor.Nome = "Dr. Smith";
professor1.CPF = 123456789;
professor1.DataNascimento = new DateOnly(1980, 02, 1)
