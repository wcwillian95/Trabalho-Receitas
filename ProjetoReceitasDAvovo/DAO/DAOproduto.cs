using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdutoEntidade;
using System.Threading.Tasks;
using ProjetoReceitasDAvovo.Entidades;
using Ent_Cupons;

namespace ProdutosDAO
{
    class DAOproduto
    {
        
        private List<Produto> produtos;
        private List<Item> Carrinho;
        public DAOproduto()
        {
            this.produtos = new List<Produto>()
            {
                new Produto
                {
                    nome = "Tomate",
                    preco = 0.50
                },
                 new Produto
                {
                    nome = "Leite",
                    preco = 0.99
                },
                  new Produto
                {
                    nome = "Farinha",
                    preco = 2.00
                },
                  new Produto
                {
                    nome = "Feijoada",
                    preco = 10
                },
            };
        }
        public List<Produto> Lista()
        {
            
            return this.produtos;
        }
        public Produto encontrar(string nome)
        {
            return this.produtos.Single(p => p.nome.Equals(nome));
        }
        private List<Item> NovoCarrinho(int Index)
        {
            List<Item> Carrinho = new List<Item>();

            Item itens = new Item();
           if(Index ==0)
            {
                Produto tomate = produtos.Find(x => x.nome.Equals("Tomate"));
                itens.produto = tomate;
                Carrinho.Add(itens);
            }
            if (Index == 1)
            {
                Produto leite = produtos.Find(x => x.nome.Equals("Leite"));
                itens.produto = leite;
                Carrinho.Add(itens);
            }
            if (Index == 2)
            {
                Produto farinha = produtos.Find(x => x.nome.Equals("Farinha"));
                itens.produto = farinha;
                Carrinho.Add(itens);
            }
            if (Index == 3)
            {
                Produto feijoada = produtos.Find(x => x.nome.Equals("Feijoada"));
                itens.produto = feijoada;
                Carrinho.Add(itens);
            }
            return Carrinho;
        }
        public List<Item> listaCarrinho(int index)
        {
            return Carrinho = NovoCarrinho(index);
        }
        public PessoaCupons cupom()
        {
            PessoaCupons novoCupom = new PessoaCupons();
            string cupom = novoCupom.cupom = "A-B-C";
            return novoCupom;
        }
        

        
    }
}
