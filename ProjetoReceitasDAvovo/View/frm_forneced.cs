using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoReceitasDAvovo.View;
using Ent_PessoaFornecedor;

namespace ProjetoReceitasDAvovo.View
{
    public partial class frm_forneced : Form
    {
        public frm_forneced()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_forneced_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_fornecedores f = new frm_fornecedores();
            f.Show();
        }

        private void frm_forneced_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Titu_Click(object sender, EventArgs e)
        {

        }

        private void Ender_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_menu f = new frm_menu();
            this.Close();
            f.Show();
            f.Location = new Point(450, 250);
        }
    }
}
