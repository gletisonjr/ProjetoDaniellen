using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.Pessoa
{
    public partial class AddPessoa : UserControl
    {
        private Form1 form;
        public AddPessoa()
        {
            InitializeComponent();
        }

        public AddPessoa(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            if(btAcao.Text.Equals("Atualizar"))
                MessageBox.Show("Atualizado com Sucesso!","Atualização",MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cadastro efetuado com sucesso!","Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            form.DefineEvent("Inicio", new Object());
        }

        public void SetBtAcao_Text(String text)
        {
            btAcao.Text = text;
        }

        public void SetGrbPessoaName(String text)
        {
            grbPessoa.Text = text;
            lblCRMV.Visible = true;
            txtCRMV.Visible = true;
        }

    }
}
