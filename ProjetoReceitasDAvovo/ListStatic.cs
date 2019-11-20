using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent_Pessoa;
using Ent_PessoaFornecedor;
using Newtonsoft.Json;
using System.IO;

namespace ProjetoReceitasDAvovo
{
    class ListStatic
    {
        public static List<Pessoa> StaticCadastradas = new List<Pessoa>();

        public void inserir(Pessoa pessoa)
        {
            StaticCadastradas.Add(pessoa);
        }
    }
}
