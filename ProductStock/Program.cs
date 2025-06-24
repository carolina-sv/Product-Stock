using System;
using ProductStock;

class Program
{
    static void Main()
    {
        ProductStock.ProductStock estoque = new ProductStock.ProductStock();

        while (true)
        {
            Console.WriteLine("\n📦 Bem-vindo ao Sistema de Estoque!");
            Console.WriteLine("Escolha uma ação:");
            Console.WriteLine("1. Cadastrar produto");
            Console.WriteLine("2. Listar produtos");
            Console.WriteLine("3. Sair");
            Console.Write("Digite o número da ação: ");

            try
            {
                string entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1":
                        Console.Write("👉 Nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.Write("💰 Preço do produto (ex: 50.00): ");
                        string precoStr = Console.ReadLine();
                        double preco;
                        if (!double.TryParse(precoStr, out preco))
                        {
                            Console.WriteLine("❌ Preço inválido.");
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
                        throw new Exception("⚠️ Opção inválida. Escolha 1, 2 ou 3.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
