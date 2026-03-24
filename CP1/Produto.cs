using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CP1
{
    internal class Produto
    {
        private String Nome;
        private double PrecoUnidade;
        private int Quantidade;
        private int Desconto;
        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string _nome)
        {
            if (_nome.Equals(""))
            {
                Nome = "NÃO INFORMADO";
            } else
            {
                Nome = _nome;
            }

        }

        public double GetPrecoUnidade()
        {
            return PrecoUnidade;
        }

        public void SetPrecoUnidade(double _preco)
        {
            if (_preco < 0)
            {
                PrecoUnidade = 0;
            } else
            {
                PrecoUnidade = _preco;
            }

        }

        public int GetQuantidade()
        {
            return Quantidade;
        }

        public void SetQuantidade(int _quantidade)
        {
            if (_quantidade < 0)
            {
                Quantidade = 0;
            } else
            {
                Quantidade = _quantidade;
            }
            
        }

        public int GetDesconto()
        {
            return Desconto;
        }

        public void SetDesconto(int _desconto)
        {
            if ((_desconto >= 0) && (_desconto <= 100))
            {
                Desconto = _desconto;
            } else
            {
                Desconto = 0;
            }
            
        }

        public Produto()
        {
        }

        public Produto(String _nome, double _preco, int _quantidade, int _desconto)
        {
            this.Nome = _nome;
            this.PrecoUnidade = _preco;
            this.Quantidade = _quantidade;
            this.Desconto = _desconto;
        }

        public double calcularTotal()
        {
            return (PrecoUnidade * Quantidade);
        }

        public double calcularFinalDesconto()
        {
            return calcularTotal() - (calcularTotal() * (this.Desconto / 100));
        }

        public void cadastrarProduto()
        {
            Console.WriteLine("Cadastro de Produtos ============================");
            Console.Write("Nome: ");
            SetNome(Console.ReadLine());

            Console.Write("Preço Unitário: ");
            SetPrecoUnidade(double.Parse(Console.ReadLine()));

            Console.Write("Quantidade: ");
            SetQuantidade(int.Parse(Console.ReadLine()));

            Console.Write("Desconto: ");
            SetDesconto(int.Parse(Console.ReadLine()));
        }

        public void aplicarDesconto()
        {
            if(calcularTotal() > 5000)
            {
                Console.WriteLine("Desconto Aplicado: " + this.Desconto + "%");
                Console.WriteLine("Custo Final: R$" + retornarCustoFinal());
            } else
            {
                Console.WriteLine("Sem Desconto Aplicado.");
                Console.WriteLine("Custo Final: R$" + retornarCustoFinal());
            }
        }

        public double retornarCustoFinal()
        {
            if (calcularTotal() > 5000)
            {
                return calcularFinalDesconto();
            }
            else
            {
                return calcularTotal();
            }
        }

        public void exibirResumo()
        {
            Console.WriteLine("Resumo ============================");
            Console.WriteLine("Produto: " + this.Nome);
            Console.WriteLine("Preço Unitário: R$" + this.PrecoUnidade);
            Console.WriteLine("Quantidade: " + this.Quantidade);
            Console.WriteLine("Custo Total: " + calcularTotal());
            aplicarDesconto();
        }
    }
}
