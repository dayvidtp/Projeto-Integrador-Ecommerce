namespace projeto_integrador_e_commerce
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public double Peso { get; set; }
        public int Quantidade { get; set; }


        public Produto(int idProduto, string nomeProduto, string marca, double preco, double peso, int quantidade)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Marca = marca;
            Preco = preco;
            Peso = peso;
            Quantidade = quantidade;
        }
        public static void CadastrarProduto()
        {
            Console.Write("Informe o nome do produto: ");
            string nome = Console.ReadLine();
            Produto produto4 = new Produto();
            produto4.NomeProduto = nome;

            produto4.IdProduto = 4;

            Console.Write("Informe a marca: ");
            string marca = Console.ReadLine();
            produto4.Marca = marca;

            Console.Write("Informe o preço: ");
            double preco = double.Parse(Console.ReadLine());

            produto4.Preco = preco;

            produto4.Peso = 2.8;

            Console.Write("Informe a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto4.Quantidade = quantidade;
            
            Console.WriteLine("");
            Console.WriteLine($"Nome do produto: {produto4.NomeProduto}");
            Console.WriteLine($"Marca do produto: {produto4.Marca}");
            Console.WriteLine($"Preço do produto: {produto4.Preco}");
            Console.WriteLine($"Quantidade: {produto4.Quantidade}");     
        }
        }
    }
}
