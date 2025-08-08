using Aula_03;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("******************************************* Trabalhando com Listas");

        //Criando uma lista de strigs
        List<string> lista = new List<string>();
        lista.Add("Maça"); //Adiciona o item no final da lista
        lista.Add("Banana"); //Adiciona o item no final da lista
        lista.Add("Goiaba"); //Adiciona o item no final da lista
        lista.Add("Laranja"); //Adiciona o item no final da lista

        Console.WriteLine("\nImprimindo os valores de 'List' na tela");
        foreach (string item in lista) // Percorre toda a lista
        {
            Console.WriteLine(item); // Imprimir item por item da lista
        }


        Console.WriteLine("\n Imprimir um item na posição específica");
        Console.WriteLine($"Item na posição 2: {lista[2]}");

        // Adicionar um item em uma posição específica
        Console.WriteLine("\nAdicionar um item na posição específica");
        lista.Insert(1, "Tangerina");

        Console.WriteLine("\nImprimindo os valores do 'List' na tela");
        foreach (string item in lista) //Percorre toda a lista
        {
            Console.WriteLine(item); //Imprimir item por item da lista
        }

        //Alterando um item da lista
        Console.WriteLine("\nAlterar um item da lista específico");
        lista[4] = "Melancia";

        foreach (string item in lista) // Percorre toda a lista
        {
            Console.WriteLine(item); //Imprimir item por item da lista
        }

        //Remover item da lista
        Console.WriteLine("\nRemover um item da lista por posição");
        lista.RemoveAt(3);
        foreach (string item in lista) //Percorre toda a lista
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nRemover um item da lista buscando pelo conteúdo");
        lista.Remove("Banana");
        foreach (string item in lista) // Percorre toda a lista
        {
            Console.WriteLine(item); // Imprimir item por item da lista
        }

        Console.WriteLine("******************************************* Trabalhando com Listas de Objtos");

        //Criando uma lista de Alunos
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adiciona o item no final da lista
        listaAlunos.Add(new Aluno(101, "Ana"));
        listaAlunos.Add(new Aluno(102, "Bia"));
        listaAlunos.Add(new Aluno(103, "Carlos"));

        Console.WriteLine("\nImprimindo os valores do 'List' de Alunos na tela");
        foreach (Aluno aluno in listaAlunos) // Percorre 
        {
            //Imprimir item da lista
            Console.WriteLine($"Código: {aluno.Codigo}, Nome: {aluno.Nome}");
        }

    }
}