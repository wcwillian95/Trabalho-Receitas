using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceitasDAO;
using ReceitasEntidade;
using ProjetoReceitasDAvovo.Entidades;


namespace ProjetoReceitasDAvovo.Controller
{
    class ReceitasController
    {
        DAOreceitas receitas = new DAOreceitas();
        public List<Ingredientes> Receitas()
        {
            return receitas.Lista();
        }
        public List<Receitas> getReceitas(int index)
        {
            return receitas.listaReceita(index);
        }
    }
}
