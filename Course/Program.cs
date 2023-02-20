using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine("Nome:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            p.preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade em estoque");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
        }
    }
}