using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoReceitasDAvovo.View
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_forneced janelafornecedorprincipal = new frm_forneced();
            janelafornecedorprincipal.Show();
            this.Hide();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_cupoms testePessoas = new frm_cupoms();
            testePessoas.Show();
            testePessoas.Location = new Point(450, 250);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_receitas receita = new frm_receitas();
            receita.Show();
            receita.Location = new Point(450, 250);
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
