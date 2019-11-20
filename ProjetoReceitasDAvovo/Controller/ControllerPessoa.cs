using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Ent_Pessoa;
using Ent_PessoaFornecedor;
using ProjetoReceitasDAvovo.View;
using ProjetoReceitasDAvovo;
using Ent_Cupons;
using ProjetoReceitasDAvovo.Arquivo;


namespace Controller_Pessoa
{
    class ControllerPessoa
    {
        private DAOpessoa pessoaDAO = new DAOpessoa();

        public ControllerPessoa () { }
        
        public Boolean adicionar(Pessoa pessoa)
        {
            pessoaDAO.inserir(pessoa);
            if (ListStatic.StaticCadastradas.Count != 0)
                return true;
                return false;
        }

        public void incluirFornecedor(PessoaFornecedor pessoaFornecedor)
        {
            pessoaDAO.inserirFornecedor(pessoaFornecedor);
        }

        public Boolean logar(string login, string senha)
        {
            Boolean flag = false;
            Boolean teste = pessoaDAO.fazerLogin(login, senha);
            foreach (Pessoa user in ListStatic.StaticCadastradas)
            {
                if (user._NomeUser.Equals(login) && user._Senha.Equals(senha))
                    flag = true;
            }
            if (flag == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public PessoaCupons descontoCup(resultado)
        //{
        //    pessoaDAO.cuponsDesconto(valortotal, cupons);
        //    return cupons;
        //}

        public void salvar()
        {
            new SaveJson().SalvarCadastro(pessoaDAO.getAllListaFornecedor());

        }
    }
}
