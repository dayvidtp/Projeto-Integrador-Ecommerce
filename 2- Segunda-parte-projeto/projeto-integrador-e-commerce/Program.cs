using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace projeto_integrador_e_commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adicionando clientes
            Cliente cliente1 = new Cliente(1, "José Luis");
            Cliente cliente2 = new Cliente(2, "Fernando Souza");
            Cliente cliente3 = new Cliente(3, "Mario Oliveira");

            //Adicionando produtos ao estoque
            Produto produto1 = new Produto(1, "Fone de Ouvido", "JBL", 150.00, 30.00, 2);
            Produto produto2 = new Produto(2, "Teclado", "Positivo", 80.00, 300.00, 6);
            Produto produto3 = new Produto(3, "Mouse", "Asus", 50.00, 80.00, 4);

            //Adicionando compras à alguns clientes
            Compra compra1 = new Compra(1, 495.00, cliente3);
            compra1.Produtos.Add(produto1);
            produto1.Quantidade--;

            Compra compra2 = new Compra();
            compra2.Id = 2;
            compra2.Distancia = 558.00;
            compra2.Cliente = cliente2;
            compra2.Produtos.Add(produto2);
            produto2.Quantidade--;

            
            Compra compra3 = new Compra(3, 780.00, cliente1);
            compra3.Produtos.Add(produto3);
            produto3.Quantidade--;

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
                //Compra.CalcularFrete();
                Console.WriteLine();
                Console.Write("Qual compra deseja calcular? ");
                Console.WriteLine(compra1.Id + ": ");
                Console.WriteLine(compra1.Produtos[0].Nome);

                Console.WriteLine();
                Console.WriteLine(compra2.Id + ": ");
                Console.WriteLine(compra2.Produtos[0].Nome);

                Console.WriteLine();
                Console.WriteLine(compra3.Id + ": ");
                Console.WriteLine(compra3.Produtos[0].Nome);

                Console.WriteLine();
                int compraEscolhida = int.Parse(Console.ReadLine());
                if (compraEscolhida == 1)
                {
                    /*F = D * (0.1 * p) / (P * 0.1) * Q
                    F: Frete (R$)
                    D: Distância (km)
                    p: Peso (kg)
                    P: Preço (R$)
                    Q: Quantidade*/
                    double frete = compra1.Distancia * (0.1 * produto1.Peso) / (produto1.Preco * 0.1) * 1;
                }
                List<Produto> Produtos = new List<Produto>{produto1};
            }
        }
    }
}
