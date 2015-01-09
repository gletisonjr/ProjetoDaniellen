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
        private Form1 form;

        public PesquisaPessoa()
        {
            InitializeComponent();
        }

        public PesquisaPessoa(Form1 form)
        {
            InitializeComponent();
            this.form = form;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grbPesquisa.Text.Equals("Pesquisa Médico"))
                form.DefineEvent("MedicoNovo", "a");
            else
                form.DefineEvent("DonoNovo", "a");
        }
    }
}
