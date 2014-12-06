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
        public AddPessoa()
        {
            InitializeComponent();
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro efetuado com sucesso","Cadastro efetuado!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        public void SetGrbPessoaName(String text)
        {
            grbPessoa.Text = text;
            lblCRMV.Visible = true;
            txtCRMV.Visible = true;
        }

    }
}
