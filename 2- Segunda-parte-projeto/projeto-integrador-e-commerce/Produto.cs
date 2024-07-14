namespace projeto_integrador_e_commerce
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public double Peso { get; set; }
        public int Quantidade { get; set; }

        public Produto() {}

        public Produto(int id, string nome, string marca, double preco, double peso, int quantidade)
        {
            Id = id;
            Nome = nome;
            Marca = marca;
            Preco = preco;
            Peso = peso;
            Quantidade = quantidade;
        }

        public static void CadastrarProduto()
        {
            Console.Write("Informe o nome do produto: ");
            string nome = Console.ReadLine();
            Produto novoProduto = new Produto();
            novoProduto.Nome = nome;

            novoProduto.Id = 4;

            Console.Write("Informe a marca: ");
            string marca = Console.ReadLine();
            novoProduto.Marca = marca;

            Console.Write("Informe o preço: ");
            double preco = double.Parse(Console.ReadLine());

            novoProduto.Preco = preco;

            novoProduto.Peso = 2.8;

            Console.Write("Informe a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            novoProduto.Quantidade = quantidade;
            
            Console.WriteLine("");
            Console.WriteLine($"Nome do produto: {novoProduto.Nome}");
            Console.WriteLine($"Marca do produto: {novoProduto.Marca}");
            Console.WriteLine($"Preço do produto: {novoProduto.Preco}");
            Console.WriteLine($"Quantidade: {novoProduto.Quantidade}");     
        }
        
    }
}
