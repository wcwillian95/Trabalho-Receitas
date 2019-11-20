using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceitasDAO;
using ReceitasEntidade;
using System.Windows.Forms;
using ProjetoReceitasDAvovo.Controller;
using ProjetoReceitasDAvovo.Entidades;

namespace ProjetoReceitasDAvovo.View
{
    public partial class frm_receitas : Form
    {
        int index = 0;
        DAOreceitas receitas = new DAOreceitas();
        ReceitasController ingredientes = new ReceitasController();
        public frm_receitas()
        {
            InitializeComponent();
        }
        private void frm_receitas_Load(object sender, EventArgs e)
        {
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            frm_menu f = new frm_menu();
            f.Show();
            f.Location = new Point(450, 250);
            this.Hide();
        }
        public void ResourcesImage()
        {
            if (index == 1)
                pictureBox1.Image = Properties.Resources.paoDeQueijo;
            if (index == 2)
                pictureBox1.Image = Properties.Resources.boloDeFuba;
            if (index == 3)
                pictureBox1.Image = Properties.Resources.canjicaDoce;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            index++;
            foreach (Receitas x in ingredientes.getReceitas(index))
            {
                label2.Text = x.receita.NomeDaReceita;
                richTextBox1.Text = $"{x.receita.ingredientes}";
                richTextBox2.Text = $"{x.receita.ModoDePreparo}";
                ResourcesImage();
            }
            if (index > 3)
            {
                index = 0;
                label2.Text = "Ingredientes";
                richTextBox1.Text = $"";
                richTextBox2.Text = $"";
                pictureBox1.Image = Properties.Resources.caderno_de_receitas_receitas;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_menu f = new frm_menu();
            f.Show();
            f.Location = new Point(450, 250);
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
