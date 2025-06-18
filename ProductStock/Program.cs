using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> produtos = new List<string>(); // ✅ Lista para armazenar vários produtos

        while (true)
        {
            Console.WriteLine("Bem vindo! Escolha uma ação:");
            Console.WriteLine("\n 1. Cadastrar produto \n 2. Listar produtos \n 3. Sair");
            string escolherAcao = Console.ReadLine();

            if (escolherAcao == "3")
            {
                Console.WriteLine("Deixando o estoque...Programa encerrado ⚠️");
                break;
            }

            if (escolherAcao == "1")
            {
                Console.WriteLine("👉 Qual o nome do produto que deseja cadastrar?");
                string nomeProduto = Console.ReadLine();
                produtos.Add(nomeProduto);
                Console.WriteLine("✅ Produto cadastrado com sucesso!");
            }
            else if (escolherAcao == "2")
            {
                Console.WriteLine("📋 Produtos cadastrados:");
                if (produtos.Count == 0)
                {
                    Console.WriteLine("📭 Nenhum produto cadastrado.");
                }
                else
                {
                    foreach (string p in produtos)
                    {
                        Console.WriteLine($"📦 {p}");
                    }
                }
            }
            else
            {
                Console.WriteLine("⚠️ Opção inválida!");
            }
        }
    }
}
