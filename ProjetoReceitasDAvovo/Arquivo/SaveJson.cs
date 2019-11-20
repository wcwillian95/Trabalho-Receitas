using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Ent_PessoaFornecedor;


namespace ProjetoReceitasDAvovo.Arquivo
{
    class SaveJson
    {
        public Boolean SalvarCadastro(List<PessoaFornecedor> pessoaFornecedors)
        {
            string json = JsonConvert.SerializeObject(pessoaFornecedors, Formatting.Indented);
            File.WriteAllText(@"C:\Users\ricar\Desktop\Trabalho facul\2_semestre\Programacao\JsonFornecedor.txt", json);
            return true;
        }
    }
}
