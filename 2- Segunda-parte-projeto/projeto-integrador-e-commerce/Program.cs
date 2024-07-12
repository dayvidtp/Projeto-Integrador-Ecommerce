namespace projeto_integrador_e_commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá usuário, você gostaria de:");
            Console.WriteLine(" ");    
            Console.WriteLine("1 - Casdastrar itens no estoque?");
            Console.WriteLine("2 - Calcular frete de um produto?");
            Console.WriteLine(" ");
            Console.WriteLine("Digite um número correspondente a pergunta para responder");
            int resposta = int.Parse(Console.ReadLine());
            
            if (resposta == 1) //Cadastrar itens no estoque
            {
                Console.Write("Informe o nome do produto: ");
                string nome = Console.ReadLine();
                Produto produto1 = new Produto();
                produto1.NomeProduto = nome;
                produto1.IdProduto = produto1.IdProduto + 1;

                Compra compra1 = new Compra();

                Console.Write("Informe a marca: ");
                string marca = Console.ReadLine();
                produto1.Marca = marca;

                Console.Write("Informe o preço: ");
                double preco = double.Parse(Console.ReadLine());
                produto1.Preco = preco;

                produto1.Peso = 2.8;

                produto1.Quantidade = produto1.Quantidade + 1;

                Console.WriteLine("");
                Console.WriteLine($"Nome do produto: {produto1.NomeProduto}");
                Console.WriteLine($"Marca do produto: {produto1.Marca}");
                Console.WriteLine($"Preço do produto: {produto1.Preco}");
                Console.WriteLine($"Quantidade: {produto1.Quantidade}");

                int i = 0;
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Quer cadastrar mais produtos? 1 Para sim | 2 para Não: ");
                    int queroMais = int.Parse(Console.ReadLine());
                    
                    if (queroMais == 1)
                    {
                        Console.WriteLine();
                        Console.Write($"Digite o nome do {i + 2} produto: ");
                        nome = Console.ReadLine();
                        Produto produto2 = new Produto();
                        produto2.NomeProduto = nome;

                        Console.WriteLine();
                        Console.Write("Digite a marca: ");
                        marca = Console.ReadLine();
                        produto2.Marca = marca;

                        Console.WriteLine();
                        Console.Write("Digite o preço: ");
                        preco = double.Parse(Console.ReadLine());
                        produto2.Preco = preco;

                        produto2.Peso = 2.8;

                        produto2.Quantidade = produto2.Quantidade + 1;

                        Console.WriteLine("");
                        Console.WriteLine($"Nome do produto: {produto2.NomeProduto}");
                        Console.WriteLine($"Marca do produto: {produto2.Marca}");
                        Console.WriteLine($"Preço do produto: {produto2.Preco}");
                        Console.WriteLine($"Quantidade: {produto2.Quantidade}");
                    }
                    else
                    {
                        Console.WriteLine("Deu erro");
                        break;
                    }
                i++;
                }
            }
            else if (resposta == 2) //Calcular frete
            {
                Console.WriteLine("Deu errado");
            }
        }
    }
}
