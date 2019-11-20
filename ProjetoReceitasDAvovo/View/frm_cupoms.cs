using ControllerProduto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProdutoEntidade;
using ProjetoReceitasDAvovo.Entidades;
namespace ProjetoReceitasDAvovo.View
{
    public partial class frm_cupoms : Form
    {
        double total = 0;
        ProdutoController produtos = new ProdutoController();
        public frm_cupoms()
        {
            InitializeComponent();
        }


        //public void CuponsDesconto()
        //{

        //    if (cupom == cupons._Desconto5)
        //    {
        //        MessageBox.Show("Você obteve R$ 5,00 de desconto");
        //    }

        //    if (cupom == cupons._Desconto10)
        //    {
        //        MessageBox.Show("Você obteve R$ 10,00 de desconto");
        //    }

        //    if (cupom == cupons._Desconto20)
        //    {
        //        MessageBox.Show("Você obteve R$ 20,00 de desconto");
        //    }

        //    if (cupom == cupons._Desconto30)
        //    {
        //        MessageBox.Show("Você obteve R$ 30,00 de desconto");
        //    }

        //    if (cupom == cupons._Desconto50)
        //    {
        //        MessageBox.Show("Você obteve R$ 50,00 de desconto");
        //    }

        //    else
        //    {
        //        MessageBox.Show("Cupom incorreto \n Você não obteve desconto");
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = valorRecebido.Text;
            if(valor == produtos.Cupom().cupom)
            {
              total = total*0.95;
                button1.Enabled = false;
                MessageBox.Show("Você obteve 5% de desconto");
            }
            else
            {
                MessageBox.Show("Cupom Invalido");
            }
            teste.Text = (total.ToString());
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            valorRecebido.Text = ("");
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            int index = comboBox1.SelectedIndex;
            foreach (Item x in produtos.Carrinho(index))
            {
                total += x.produto.preco;
            }
            teste.Text = (total.ToString());
        }

        private void frm_cupoms_Load(object sender, EventArgs e)
        {
             foreach (Produto x in produtos.Produtos())
            {
                comboBox1.Items.Add(x.nome + "    R$ "+ x.preco);
            }
            teste.Text = (total.ToString());

        }

        private void teste_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
