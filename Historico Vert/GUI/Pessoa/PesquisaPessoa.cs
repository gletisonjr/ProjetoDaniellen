using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.GUI.Pessoa
{
    public partial class PesquisaPessoa : UserControl
    {
        private Form1 form;
        public Data.Pessoa pessoa { get; set; }

        public PesquisaPessoa()
        {
            InitializeComponent();
            pessoa = new Data.Pessoa();
        }

        public PesquisaPessoa(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            pessoa = new Data.Pessoa();
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
                form.DefineEvent("MedicoNovo", pessoa);
            else
                form.DefineEvent("DonoNovo", pessoa);
        }

        public void ColocarDadosTela(Data.Pessoa pessoa)
        {
            this.pessoa = pessoa;

            if (this.pessoa is Data.Medico)
            {
                Data.Medico medico = (Data.Medico)pessoa;
                this.lblCRMV2.Text = medico.crmv.ToString();
            }
            this.lblNomeDono2.Text = this.pessoa.nome;
            this.lblBairro2.Text = this.pessoa.endereco.bairro;
            this.lblCep2.Text = this.pessoa.endereco.cep;
            this.lblCidade2.Text = this.pessoa.endereco.cidade;
            this.lblComplemento2.Text = this.pessoa.endereco.complemento;
            this.lblEmail2.Text = this.pessoa.email;
            this.lblEstado2.Text = this.pessoa.endereco.estado;
            this.lblNumero2.Text = this.pessoa.endereco.numero;
            this.lblRua2.Text = this.pessoa.endereco.rua;
            this.lblTelefone2.Text = this.pessoa.telefone;

        }
    }
}
