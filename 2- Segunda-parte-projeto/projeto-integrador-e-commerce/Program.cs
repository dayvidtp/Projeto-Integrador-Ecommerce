using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
 
namespace projeto_integrador_e_commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Cliente cliente1 = new Cliente(1, "José Luis");
                Cliente cliente2 = new Cliente(2, "Fernando Souza");
                Cliente cliente3 = new Cliente(3, "Mario Oliveira");

                //Adicionando produtos ao estoque
                Produto produto1 = new Produto(1, "Fone de Ouvido", "JBL", 150.00, 30.00, 2);
                Produto produto2 = new Produto(2, "Teclado", "Positivo", 80.00, 300.00, 6);
                Produto produto3 = new Produto(3, "Mouse", "Asus", 50.00, 80.00, 4);

                //Adicionando compras à alguns clientes
                Compra compra1 = new Compra(1, 495.00, cliente3, produto1, 2);


                Compra compra2 = new Compra();
                compra2.Id = 2;
                compra2.Distancia = 558.00;
                compra2.Cliente = cliente2;
                compra2.Produto = produto2;
                compra2.Quantidade = 1;

                List<Produto> produtos = new List<Produto> { produto1, produto2, produto3 }; //Lista com os produtos

                Compra compra3 = new Compra(3, 780.00, cliente1, produto3, 3);


                Console.Write("Olá usuário, você gostaria de:");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Casdastrar itens no estoque?");
                Console.WriteLine("2 - Calcular frete de um produto?");
                Console.WriteLine("3 - Efetuar uma compra?");
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
                    Console.WriteLine("Qual compra deseja calcular? ");
                    Console.WriteLine(compra1.Id + ": Fone de Ouvido");


                    Console.WriteLine();
                    Console.WriteLine(compra2.Id + ": Teclado");


                    Console.WriteLine();
                    Console.WriteLine(compra3.Id + ": Mouse");


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
                        compra1.CalcularFrete();
                    }
                    else if (compraEscolhida == 2)
                    {
                        compra2.CalcularFrete();
                    }
                    else if (compraEscolhida == 3)
                    {
                        compra3.CalcularFrete();
                    }
                }
                else if(resposta == 3) //Efetuar compra
                {
                    compra1.EfetuarCompra(produtos);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Voce digitou um carctere não esperado! nome do erro: " + ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Voce digitou um número muito grande " + ex.Message);
            }
         }
    }
}