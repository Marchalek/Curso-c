using System.Globalization;
using System;

namespace Course {
    class Produto {
        public string Nome;
        public double preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return preco * Quantidade;
        }

        public void AdicionarProdutos(int quantiaMais) {
            Quantidade = Quantidade + quantiaMais;
            Console.WriteLine("Dados Atualizados: " + ToString());
        }

        public void RemoverProdutos(int quantiaMenos) {
            Quantidade = Quantidade - quantiaMenos;
            Console.WriteLine("Dados Atualizados: " + ToString());
        }

        override public string ToString() {
            return Nome
                + ", $"
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades,  Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
