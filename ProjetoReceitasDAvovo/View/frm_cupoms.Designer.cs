namespace ProjetoReceitasDAvovo.View
{
    partial class frm_cupoms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.limpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.valorRecebido = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teste = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE O CODIGO DO SEU CUPOM";
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(168, 136);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(75, 23);
            this.limpar.TabIndex = 1;
            this.limpar.Text = "LIMPAR";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(265, 136);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 3;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // valorRecebido
            // 
            this.valorRecebido.Location = new System.Drawing.Point(236, 45);
            this.valorRecebido.Name = "valorRecebido";
            this.valorRecebido.Size = new System.Drawing.Size(126, 20);
            this.valorRecebido.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(481, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // teste
            // 
            this.teste.Location = new System.Drawing.Point(677, 45);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(100, 20);
            this.teste.TabIndex = 6;
            this.teste.TextChanged += new System.EventHandler(this.teste_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produtos disponiveis:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // frm_cupoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teste);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.valorRecebido);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.label1);
            this.Name = "frm_cupoms";
            this.Text = "frm_cupoms";
            this.Load += new System.EventHandler(this.frm_cupoms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox valorRecebido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox teste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}