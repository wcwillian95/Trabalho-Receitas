using Ent_Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ent_PessoaFornecedor;
using ProjetoReceitasDAvovo;
using ProjetoReceitasDAvovo.View;
using Ent_Cupons;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjetoReceitasDAvovo.Arquivo;

namespace Dao
{
    class DAOpessoa
    {
       List<Pessoa> cadastradas = new List<Pessoa>();
       List<PessoaFornecedor> StaticFornecedores = new List<PessoaFornecedor>();


        public void inserir(Pessoa pessoa)
        {
            ListStatic.StaticCadastradas.Add(pessoa);
        }

        public void inserirFornecedor(PessoaFornecedor pessoafornecedores)
        {
            StaticFornecedores.Add(pessoafornecedores);
        }

        public Boolean fazerLogin(string login, string senha)
        {
            int contCadastradas = ListStatic.StaticCadastradas.Count();
            if (contCadastradas == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Pessoa> getAllListaCadastro()
        {
            return cadastradas;
        }

        public List<PessoaFornecedor> getAllListaFornecedor()
        {
            return StaticFornecedores;
        }

        //public Boolean daoJSON()
        //{
        //    string json = JsonConvert.SerializeObject((StaticFornecedores, Formatting.Indented));
        //    File.WriteAllText(@"C:\Users\2019100619\Desktop\Programacao\Json.txt", json);
        //    return true;
        //}
    }
}
