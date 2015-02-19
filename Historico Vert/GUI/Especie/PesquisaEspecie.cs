using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Historico_Vert.Data;

namespace Historico_Vert.GUI.Especie
{
    public partial class PesquisaEspecie : UserControl
    {
        private Form1 form;
        private Data.Especie especie { get; set; }

        public PesquisaEspecie()
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            especie = null;
            btnAtualizar.Visible = false;
        }

        public PesquisaEspecie(Form1 form) : this()
        {
            this.form = form;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            especie = DataContext.Obter<Data.Especie>(a => a.nome == txtNomeEspecie.Text);

            if (especie != null)
            {
                txtNome.Text = especie.nome;
                txtDescricao.Text = especie.descricao;
                grbEspecie.Visible = true;
            }
            else
                grbEspecie.Visible = false;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled =
            txtDescricao.ReadOnly =
            txtNome.ReadOnly =
            btnPesquisa.Enabled = false;
            txtNomeEspecie.ReadOnly =
            btnAtualizar.Visible = true; 
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
    
            especie.descricao = txtDescricao.Text;
            especie.nome = txtNome.Text;

            if (DataContext.Save(especie))
            {
                btnPesquisa.Enabled =
                txtDescricao.ReadOnly =
                txtNome.ReadOnly = true;
                txtNomeEspecie.ReadOnly =
                btnAtualizar.Visible = false;
                MessageBox.Show("Atualizado com Sucesso!", "Atualização de Espécie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.DefineEvent("Inicio", new Object());
            }
            else
                MessageBox.Show("Erro ao atualizar!\nPor favor verifique os dados!", "Atualização de Espécie", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtNomeEspecie_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeEspecie.Text))
            {
                txtNomeEspecie.AutoCompleteCustomSource.Clear();
                txtNomeEspecie.AutoCompleteCustomSource.AddRange(
                    DataContext.AutoCompleteLista<Data.Especie>(a => a.nome.Contains(txtNomeEspecie.Text), a => a.nome)
                        .ToArray());
            }

        }

    }
}
