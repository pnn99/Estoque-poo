using System.Globalization;

namespace Estoque
{
    public class Produto
    {
        private string _nome;
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Price = preco;
            Amount = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double ValorTotalEmEstoque()
        {
            return Price * Amount;
        }
        public void AddProduto(int quantidade)
        {
            Amount += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Amount -= quantidade;
        }
        public override string ToString()
        {
            return _nome + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", " + Amount + " unidades, Total: $"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}