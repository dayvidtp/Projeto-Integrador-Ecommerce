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
    }
}
