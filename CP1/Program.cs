using System;
using System.Collections.Generic;
using System.Text;

namespace CP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto prod1 = new Produto();
            Produto prod2 = new Produto();

            prod1.cadastrarProduto();
            prod2.cadastrarProduto();

            prod1.exibirResumo(); 
            prod2.exibirResumo();

            if (prod1.retornarCustoFinal() < prod2.retornarCustoFinal())
            {
                Console.WriteLine("O produto com o maior custo final é o: " + prod2.GetNome());
            } else if (prod2.retornarCustoFinal() < prod1.retornarCustoFinal())
            {
                Console.WriteLine("O produto com o maior custo final é o: " + prod1.GetNome());
            } else if (prod1.retornarCustoFinal() == prod2.retornarCustoFinal())
            {
                Console.WriteLine("Os produtos possuem o mesmo custo final!");
            }
        }
    }
}
