
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Criar a lista de tarefas
        List<string> tarefas = new List<string>
        {
            "Ligar para o cliente",
            "Revisar o contrato",
            "Enviar e-mails",
            "Organizar documentos",
            "Planejar reunião"
        };

        // 2. Inserir nova tarefa na segunda posição (índice 1)
        tarefas.Insert(1, "Atualizar sistema");

        // 3. Alterar a quarta tarefa (índice 3)
        tarefas[3] = "Fazer backup dos dados";

        // 4. Pesquisar se "Enviar relatorio" está na lista
        string tarefaBusca = "Enviar relatorio";
        bool existe = tarefas.Contains(tarefaBusca);
        Console.WriteLine($"\nA tarefa \"{tarefaBusca}\" {(existe ? "está" : "não está")} na lista.");

        // 5. Remover uma tarefa pelo nome
        string tarefaRemover = "Enviar e-mails";
        bool removido = tarefas.Remove(tarefaRemover);
        if (removido)
        {
            Console.WriteLine($"\nTarefa \"{tarefaRemover}\" removida com sucesso.");
        }
        else
        {
            Console.WriteLine($"\nTarefa \"{tarefaRemover}\" não foi encontrada.");
        }

        // 6. Exibir todas as tarefas restantes com índice
        Console.WriteLine("\nTarefas restantes:");
        for (int i = 0; i < tarefas.Count; i++)
        {
            Console.WriteLine($"{i}: {tarefas[i]}");
        }


    }
}
