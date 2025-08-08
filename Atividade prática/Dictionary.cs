using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_prática
{
    internal class Dictionary
    {

        class Programa
        {
            static void Main()
            {
                // 1. Criar o Dictionary chamado agenda
                Dictionary<string, string> agenda = new Dictionary<string, string>();

                // 2. Inserir pelo menos 5 contatos
                agenda["João"] = "99999-1111";
                agenda["Maria"] = "98888-2222";
                agenda["Carlos"] = "97777-3333";
                agenda["Ana"] = "96666-4444";
                agenda["Fernanda"] = "95555-5555";

                // 3. Alterar o telefone de um contato específico
                agenda["Carlos"] = "90000-0000"; // novo número

                // 4. Pesquisar se "Maria" está na agenda
                string reusltadoBusca;
                string nomeBusca = "Maria";
                if (agenda.TryGetValue(nomeBusca, out reusltadoBusca))
                {
                    Console.WriteLine($"\nContato encontrado: {nomeBusca} - Telefone: {agenda[nomeBusca]}");
                }
                else
                {
                    Console.WriteLine($"\n{nomeBusca} não está na agenda.");
                }

                // 5. Remover um contato pelo nome
                string nomeRemover = "Fernanda";
                if (agenda.Remove(nomeRemover))
                {
                    Console.WriteLine($"\nContato {nomeRemover} removido com sucesso.");
                }
                else
                {
                    Console.WriteLine($"\nContato {nomeRemover} não encontrado.");
                }

                // 6. Exibir todos os contatos restantes
                Console.WriteLine("\nContatos restantes na agenda:");
                foreach (var contato in agenda)
                {
                    Console.WriteLine($"{contato.Key}: {contato.Value}");
                }
            }
        }

    }
}
