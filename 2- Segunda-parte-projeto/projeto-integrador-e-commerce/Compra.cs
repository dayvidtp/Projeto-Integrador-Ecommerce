namespace projeto_integrador_e_commerce
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public double Distancia { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
