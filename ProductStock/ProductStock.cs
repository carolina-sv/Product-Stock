

namespace ProductStock
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Disponibilidade { get; set; }
    }

    public class ProductStock
    {
        private List<Produto> produtos = new List<Produto>();

        public string CadastrarProduto(string nome, double preco, string disponibilidade)
        {
            if (string.IsNullOrWhiteSpace(nome) || preco < 0 || string.IsNullOrWhiteSpace(disponibilidade))
            {
                return "⚠️ Dados inválidos. Verifique os campos.";
            }

            produtos.Add(new Produto
            {
                Nome = nome.Trim(),
                Preco = preco,
                Disponibilidade = disponibilidade.Trim().ToLower()
            });

            return "✅ Produto cadastrado com sucesso!";
        }

        public string ListarProdutos()
        {
            if (produtos.Count == 0)
            {
                return "📭 Nenhum produto cadastrado.";
            }

            string resultado = "📋 Lista de Produtos:\n";

            foreach (var produto in produtos)
            {
                resultado += $"📦 Nome: {produto.Nome} | 💰 Preço: R${produto.Preco:F2} | ✅ Disponível: {produto.Disponibilidade}\n";
            }

            return resultado;
        }
    }
}
