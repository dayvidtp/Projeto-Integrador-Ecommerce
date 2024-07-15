using System.ComponentModel;
using System.Security.AccessControl;

namespace projeto_integrador_e_commerce
{
    public class Compra
    {
        public int Id { get; set; }
        public double Distancia { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }

        public Compra() {}

        public Compra(int id, double distancia, Cliente cliente)
        {
            Id = id;
            Distancia = distancia;
            Cliente = cliente;
        }

        public void EfetuarCompra(List<Produto> produtos)
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            int id = 5;
            Cliente novoClienteCompra = new Cliente(id, nome);

   

            Console.WriteLine($"Seja Bem vindo(a ) {nome}, escolha qual produto deseja comprar: ");

             int num1 = 1;


            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"{num1} {produto}");
                num1++;
    
            }
            Console.Write("Digite o numero: ");
            int resposta = int.Parse(Console.ReadLine());
            Console.WriteLine(resposta);
            Console.Write("Digite a quantidade: ");
            int quantidadeCompra = int.Parse(Console.ReadLine());

        }

        public void CalcularFrete()
        {

            
        }
    }
}
