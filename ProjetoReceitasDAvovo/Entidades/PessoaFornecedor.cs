using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent_PessoaFornecedor
{
    public class PessoaFornecedor
    {
        //public string _NomeEmpresa { get; set; }
        //public string _EnderecoEmpresa { get; set; }
        //public string _BairroEmpresa { get; set; }
        //public string _EstadoEmpresa { get; set; }
        //public string _CepEmpresa { get; set; }

        private string NomeEmpresa;
        private string EnderecoEmpresa;
        private string BairroEmpresa;
        private string EstadoEmpresa;
        private string CepEmpresa;

        public string _NomeEmpresa
        {
            get
            {
                return NomeEmpresa;
            }
            set
            {
                NomeEmpresa = value;
            }
        }
        public string _EnderecoEmpresa
        {
            get
            {
                return EnderecoEmpresa;
            }
            set
            {
                EnderecoEmpresa = value;
            }
        }
        public string _BairroEmpresa
        {
            get
            {
                return BairroEmpresa;
            }
            set
            {
                BairroEmpresa = value;
            }
        }
        public string _EstadoEmpresa
        {
            get
            {
                return EstadoEmpresa;
            }
            set
            {
                EstadoEmpresa = value;
            }
        }
        public string _CepEmpresa
        {
            get
            {
                return CepEmpresa;
            }
            set
            {
                CepEmpresa = value;
            }
        }

        public override string ToString()
        {
            return $"Nome Empresa {_NomeEmpresa}, Endereço Empresa {_EnderecoEmpresa}, Bairro Empresa {_BairroEmpresa}, Estado Empresa: {_EstadoEmpresa}, CEP: {_CepEmpresa}";
        }
    }

}
