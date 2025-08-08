using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_prática
{
    internal class Stack
    {
        class Program
        {
            static void Main()
            {
                // Criar a pilha de histórico de páginas visitadas
                Stack<string> historico = new Stack<string>();

                // Adicionar 5 URLs no histórico
                historico.Push("https://google.com");
                historico.Push("https://youtube.com");
                historico.Push("https://senai.br");
                historico.Push("https://github.com");
                historico.Push("https://dotnet.microsoft.com");

                // Remover (voltar) a última página visitada
                if (historico.Count > 0)
                {
                    string ultimaPagina = historico.Pop();
                    Console.WriteLine($"Voltando da página: {ultimaPagina}");
                }

                // Verificar se "https:\\senai.br" está no histórico
                string paginaBuscada = "https://senai.br";
                if (historico.Contains(paginaBuscada))
                {
                    Console.WriteLine($"\nA página \"{paginaBuscada}\" está no histórico.");
                }
                else
                {
                    Console.WriteLine($"\nA página \"{paginaBuscada}\" NÃO está no histórico.");
                }

                // Remover outra página (voltar mais uma)
                if (historico.Count > 0)
                {
                    string paginaRemovida = historico.Pop();
                    Console.WriteLine($"\nVoltando da página: {paginaRemovida}");
                }

                // Mostrar todas as páginas restantes no histórico
                Console.WriteLine("\nPáginas restantes no histórico:");
                foreach (string pagina in historico)
                {
                    Console.WriteLine(pagina);
                }
            }
        }

    }
}

