using System.Globalization;

namespace POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            qtd = int.Parse(Console.ReadLine());

            Console.WriteLine();
            p.AdicionarProdutos(qtd);
            Console.WriteLine("Dados atualizado do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine("Dados atualizado do Produto: " + p);

        }
    }
}
