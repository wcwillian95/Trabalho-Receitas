using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller_Pessoa;
using Dao;
using ProjetoReceitasDAvovo.View;



namespace ProjetoReceitasDAvovo
{
   
    public partial class frm_login : Form
    {
        ControllerPessoa pessoaControll = new ControllerPessoa();
        public frm_login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Boolean retorno = pessoaControll.logar(ID_LOGIN.Text, Password.Text);
            if (retorno == true)
            {
                MessageBox.Show("Logado com sucesso!!!"); //consertar retorno

                frm_menu janelamenu = new frm_menu();
                janelamenu.Show();
                janelamenu.Location = new Point(450, 250);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Falha ao logar");
            }





        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            this.Location = new Point(600, 250);
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_cadastro f = new frm_cadastro();
            f.Show();
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
