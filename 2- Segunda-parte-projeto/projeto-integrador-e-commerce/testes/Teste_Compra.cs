using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace projeto_integrador_e_commerce.testes
{
    public class Teste_Compra
    {


        [Fact]

        public void Teste_Frete()
        {

            Cliente cliente1 = new Cliente(1, "Antônio José");
            Produto produto1 = new Produto(1, "geladeira", "Philco", 1550.00, 50.00, 1);
            Compra compra1 = new Compra();
                compra1.Id = 1;
                compra1.Distancia = 1000.00;
                compra1.Cliente = cliente1;
                compra1.Produto = produto1;
                compra1.Quantidade = 1;
                


            double frete = compra1.Distancia * (0.1 * produto1.Peso) / (produto1.Preco * 0.1) * compra1.Quantidade;

            Assert.Equal(32.2580645161290322580,frete);
        }
    }
}
