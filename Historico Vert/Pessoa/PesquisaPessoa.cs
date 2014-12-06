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
    public partial class PesquisaPessoa : UserControl
    {
        public PesquisaPessoa()
        {
            InitializeComponent();
        }

        public void PesquisaMedico()
        {
           lblCRMV1.Visible =
           lblCRMV2.Visible = true;
           grbPesquisa.Text = "Pesquisa Médico";
           grbPessoa.Text = "Dados Médico";
           lblNomeDono1.Text = 
           lblNomeDono.Text = "Nome Médico";
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbPessoa.Visible = true;
        }
    }
}
