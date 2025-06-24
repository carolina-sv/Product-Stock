using System;
using ProductStock;

class Program
{
    static void Main()
    {
        ProductStock estoque = new ProductStock();

        while (true)
        {
            Console.WriteLine("📦 Bem-vindo ao Sistema de Estoque!");
            Console.WriteLine("Escolha uma ação:");
            Console.WriteLine("1. Cadastrar produto");
            Console.WriteLine("2. Listar produtos");
            Console.WriteLine("3. Sair");
            Console.Write("Digite o número da ação: ");

            string entrada = Console.ReadLine();

            switch (entrada)
            {
                case "1":
                    Console.Write("👉 Nome do produto: ");
                    string nome = Console.ReadLine();

                    Console.Write("💰 Preço do produto (ex: 50.00): ");
                    string precoStr = Console.ReadLine();

                    if (!double.TryParse(precoStr, out double preco))
                    {
                        Console.WriteLine("❌ Preço inválido. Por favor, digite um número válido.");
                        break;
                    }

                    Console.Write("✅ Produto disponível? (s/n): ");
                    string disponivel = Console.ReadLine();

                    string resultado = estoque.CadastrarProduto(nome, preco, disponivel);
                    Console.WriteLine(resultado);
                    break;

                case "2":
                    Console.WriteLine(estoque.ListarProdutos());
                    break;

                case "3":
                    Console.WriteLine("👋 Programa encerrado. Até mais!");
                    return;

                default:
                    Console.WriteLine("⚠️ Opção inválida. Selecione uma das tres opções");
                    break;
            }
        }
    }
}
