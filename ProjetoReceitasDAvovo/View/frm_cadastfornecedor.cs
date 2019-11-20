using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ent_PessoaFornecedor;
using Controller_Pessoa;


namespace ProjetoReceitasDAvovo.View    
{
    public partial class frm_fornecedores : Form
    {
        ControllerPessoa controler = new ControllerPessoa();
        public frm_fornecedores()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cdt_Click(object sender, EventArgs e)
        {
            controler.incluirFornecedor(CadastrarFornecedor());
            controler.salvar();
            this.Close();
            frm_forneced forne = new frm_forneced();
            forne.Show();
        }

        private void frm_fornecedores_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public PessoaFornecedor CadastrarFornecedor()
        {
            PessoaFornecedor pessoaFornecedor = new PessoaFornecedor();

            pessoaFornecedor._NomeEmpresa = cadastNome.Text;
            pessoaFornecedor._EnderecoEmpresa = cadastEndereco.Text;
            pessoaFornecedor._BairroEmpresa = cadastBairro.Text;
            pessoaFornecedor._EstadoEmpresa = cadastEstado.Text;
            pessoaFornecedor._CepEmpresa = cadastCep1.Text + "-" + cadastCep2.Text;

            if (pessoaFornecedor._NomeEmpresa == null || pessoaFornecedor._EnderecoEmpresa == null)
            {
                MessageBox.Show("Cadastro incorreto");
            }

            else
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
                this.Close();

            }

            return pessoaFornecedor;
        }

        private void frm_fornecedores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            cadastNome.Text = "";
            cadastEstado.Text = "";
            cadastEndereco.Text = "";
            cadastCep2.Text = "";
            cadastCep1.Text = "";
            cadastBairro.Text = "";
            textBox3.Text = "";
            textBox8.Text = "";
            textBox6.Text = "";
            textBox11.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox10.Text = "";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }
    }
}
