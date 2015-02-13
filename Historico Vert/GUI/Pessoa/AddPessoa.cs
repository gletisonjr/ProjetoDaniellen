using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Historico_Vert.Data;

namespace Historico_Vert.GUI.Pessoa
{
    public partial class AddPessoa : UserControl
    {
        private Form1 form;
        public Data.Pessoa pessoa { get; set; }

        public AddPessoa()
        {
            InitializeComponent();
        }

        public AddPessoa(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            this.pessoa = new Data.Pessoa();
        }

        public AddPessoa(Form1 form,Data.Pessoa pessoa)
        {
            InitializeComponent();
            this.form = form;
            this.pessoa = pessoa;
            ColocarDadosTela();
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            AtualizaPessoa();
            if (btAcao.Text.Equals("Atualizar"))
            {
                MessageBox.Show("Atualizado com Sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (grbPessoa.Text.Equals("Dados do Médico Veterinário"))
                form.DefineEvent("MedicoPesquisar", pessoa);
            else
                form.DefineEvent("DonoPesquisar", pessoa);
            //form.DefineEvent("Inicio", pessoa);
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

        public void ColocarDadosTela()
        {
            if( this.pessoa is Medico)
            {
                Medico medico = (Medico)pessoa;
                this.txtCRMV.Text = medico.crmv.ToString();
            }
            this.txtNome.Text = this.pessoa.nome;
            this.txtBairro.Text = this.pessoa.endereco.bairro;
            this.txtCEP.Text = this.pessoa.endereco.cep;
            this.txtCidade.Text = this.pessoa.endereco.cidade;
            this.txtCompEndereco.Text = this.pessoa.endereco.complemento;
            this.txtEmail.Text = this.pessoa.email;
            this.txtEstado.Text = this.pessoa.endereco.estado;
            this.txtNumRua.Text = this.pessoa.endereco.numero;
            this.txtRua.Text = this.pessoa.endereco.rua;
            this.txtTelefone.Text = this.pessoa.telefone;

        }

        private void AtualizaPessoa()
        {
            Endereco endereco = new Endereco();
            endereco.rua = txtRua.Text;
            endereco.numero = txtNumRua.Text;
            endereco.complemento =  txtCompEndereco.Text;
            endereco.bairro = txtBairro.Text;
            endereco.cidade = txtCidade.Text;
            endereco.estado = txtEstado.Text;
            endereco.cep = txtCEP.Text;
            if (!btAcao.Text.Equals("Atualizar"))
            {
                if (grbPessoa.Text.Equals("Dados do Dono"))
                {
                    pessoa = new Data.Cliente();
                }
                else
                {
                    pessoa = new Data.Medico();
                    pessoa.crmv = Convert.ToInt32(txtCRMV.Text);
                }
            }
            else
            {
                endereco.id = pessoa.endereco.id;
                if (pessoa is Medico)
                {
                    pessoa.crmv = Convert.ToInt32(txtCRMV.Text);
                }
            }
            pessoa.endereco = endereco;
            pessoa.email = txtEmail.Text;
            pessoa.nome = txtNome.Text;
            pesssoa.telefone = txtTelefone.Text;

        }

    }
}
