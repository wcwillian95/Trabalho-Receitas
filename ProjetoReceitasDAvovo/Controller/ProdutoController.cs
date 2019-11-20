using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdutosDAO;
using System.Threading.Tasks;
using ProdutoEntidade;
using ProjetoReceitasDAvovo.Entidades;
using Ent_Cupons;

namespace ControllerProduto
{
    class ProdutoController
    {
        DAOproduto produtosDAO = new DAOproduto();

       public List<Produto> Produtos()
        {
            return produtosDAO.Lista();
        }
        public List<Item> Carrinho(int index)
        {
            return produtosDAO.listaCarrinho(index);
        }
        public PessoaCupons Cupom()
        {
            return produtosDAO.cupom();
        }
    }
}
