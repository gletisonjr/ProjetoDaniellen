using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Historico_Vert.Data;
using Historico_Vert.Util;

namespace Historico_Vert.GUI.Raca
{
    public partial class PesquisaRaca : UserControl
    {
        private Form1 form;

        public PesquisaRaca()
        {
            InitializeComponent();
        }

        public PesquisaRaca(Form1 form) : this()
        {
            this.form = form;
            txtNomeEspecie.CarregarAutoComplete<Data.Especie>(a => a.nome);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbRaca.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtDescricao.ReadOnly =
            txtNome.ReadOnly =
            txtNomeEspecie1.ReadOnly = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtDescricao.ReadOnly =
            txtNome.ReadOnly =
            txtNomeEspecie1.ReadOnly = true;
            MessageBox.Show("Atualizado com Sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.DefineEvent("Inicio", new Object());
        }

        private void txtNomeEspecie_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNomeEspecie.Text))
                return;

            var especie = DataContext.Obter<Data.Especie>(o => o.nome == txtNomeEspecie.Text);

            if (especie == null)
            {
                MessageBox.Show("Não existe esta espécie!", "Espécie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtNomeRaca.CarregarAutoComplete<Data.Raca>(a => a.nome,  b => b.idEspecie == especie.id);
        }
    }
}
