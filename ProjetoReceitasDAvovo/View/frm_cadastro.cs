using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ent_Pessoa;
using Controller_Pessoa;

namespace ProjetoReceitasDAvovo
{
   
    public partial class frm_cadastro : Form
    {
        ControllerPessoa addCadastro = new ControllerPessoa();
        
        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa._NomeUser = textBox1.Text;
            pessoa._Email = textBox2.Text;
            pessoa._Senha = textBox3.Text;
            string ConfirmarSenha = textBox4.Text;
            if (pessoa._Senha == ConfirmarSenha)
            {
               addCadastro.adicionar(pessoa);
                MessageBox.Show("Cadastrado com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro!!!");
            }

        }

        private void LinkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
