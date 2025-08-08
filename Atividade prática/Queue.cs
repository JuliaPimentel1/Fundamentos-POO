using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_prática
{
    internal class Queue
    {

        class Program
        {
            static void Main()
            {

                // 1. Criar a fila de atendimento
                Queue<string> fila = new Queue<string>();

                // Inserir 5 nomes de clientes na fila
                fila.Enqueue("Ana");
                fila.Enqueue("Bruno");
                fila.Enqueue("João");
                fila.Enqueue("Carla");
                fila.Enqueue("Daniel");

                // 2. Atender o primeiro cliente
                if (fila.Count > 0)
                {
                    string clienteAtendido = fila.Dequeue();
                    Console.WriteLine($"Cliente atendido: {clienteAtendido}");
                }

                // 3. Verificar se "João" ainda está na fila e mostrar sua posição
                string clienteProcurado = "João";
                if (fila.Contains(clienteProcurado))
                {
                    int posicao = 1;
                    foreach (string cliente in fila)
                    {
                        if (cliente == clienteProcurado)
                        {
                            Console.WriteLine($"\n{clienteProcurado} está na fila, posição: {posicao}");
                            break;
                        }
                        posicao++;
                    }
                }
                else
                {
                    Console.WriteLine($"\n{clienteProcurado} não está na fila.");
                }

                // 4. Remover outro cliente da fila
                if (fila.Count > 0)
                {
                    string proximoCliente = fila.Dequeue();
                    Console.WriteLine($"\nPróximo cliente atendido: {proximoCliente}");
                }

                // 5. Exibir todos os clientes restantes
                Console.WriteLine("\nClientes restantes na fila:");
                foreach (string cliente in fila)
                {
                    Console.WriteLine(cliente);
                }
            }
        }
    }
}
