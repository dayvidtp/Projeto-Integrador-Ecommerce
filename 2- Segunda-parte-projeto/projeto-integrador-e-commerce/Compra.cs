namespace projeto_integrador_e_commerce
{
    public class Compra
    {
        public int Id { get; set; }
        public double Distancia { get; set; }
        public Cliente Cliente { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }

        public Compra() { }

        public Compra(int id, double distancia, Cliente cliente, Produto produto, int quantidade)
        {
            Id = id;
            Distancia = distancia;
            Cliente = cliente;
            Produto = produto;
            Quantidade = quantidade;
        }

        // Método para calcular o frete
        public void CalcularFrete()
        {
            double frete = Distancia * (0.1 * Produto.Peso) / (Produto.Preco * 0.1) * Quantidade;
            Console.WriteLine("O frete foi de: " + frete);
        }

        // Método para efetuar a compra
        public void EfetuarCompra(List<Produto> produtos)
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            int id = 5;
            Cliente novoClienteCompra = new Cliente(id, nome);

            Console.WriteLine($"Seja bem vindo(a), {nome}. Escolha qual produto deseja comprar:");

            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {produtos[i].Nome}");
            }

            Console.Write("Digite o número correspondente ao produto: ");
            int resposta = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int quantidadeCompra = int.Parse(Console.ReadLine());

            if (resposta > 0 && resposta <= produtos.Count)
            {
                Produto produtoEscolhido = produtos[resposta - 1];

                if (produtoEscolhido.Quantidade >= quantidadeCompra)
                {
                    produtoEscolhido.Quantidade -= quantidadeCompra;
                    Console.WriteLine($"Você comprou {quantidadeCompra} unidade(s) de {produtoEscolhido.Nome}.");
                    Console.WriteLine($"Estoque atual do produto {produtoEscolhido.Nome}: {produtoEscolhido.Quantidade}");
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente no estoque.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}
