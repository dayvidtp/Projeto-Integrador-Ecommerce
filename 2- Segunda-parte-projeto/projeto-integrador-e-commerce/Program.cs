using System.Security.Cryptography.X509Certificates;

namespace projeto_integrador_e_commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(1, "Notebook", "Samsung", 3.500, 5, 10);
            Produto produto2 = new Produto(2, "Redmi Note 13", "Xiaomi", 1.300, 0.800, 15);
            Produto produto3 = new Produto(3, "Iphone 15", "Apple", 12.000, 1.2, 2);

            Console.Write("Olá usuário, você gostaria de:");
            Console.WriteLine(" ");    
            Console.WriteLine("1 - Casdastrar itens no estoque?");
            Console.WriteLine("2 - Calcular frete de um produto?");
            Console.WriteLine(" ");
            Console.WriteLine("Digite um número correspondente a pergunta para responder");
            int resposta = int.Parse(Console.ReadLine());
            
            if (resposta == 1) //Cadastrar itens no estoque
            {
                Produto.CadastrarProduto();
            }
            else if (resposta == 2) //Calcular frete
            {
                Console.WriteLine("Deu errado");
            }
        }
    }
}
