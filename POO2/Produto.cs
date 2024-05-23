using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace POO2
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        /* ToString serve para retornar os atributos da Classe em forma de String, basicamente um metodo criado para isso*/
        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade + " unidades, Total : R$" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
