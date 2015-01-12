using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.Especie
{
    public partial class PesquisaEspecie : UserControl
    {
        private Form1 form;

        public PesquisaEspecie()
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
        }

        public PesquisaEspecie(Form1 form)
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            this.form = form;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbEspecie.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtDescricao.ReadOnly =
            txtNome.ReadOnly = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtDescricao.ReadOnly =
            txtNome.ReadOnly = true;
            MessageBox.Show("Atualizado com Sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.DefineEvent("Inicio", new Object());
        }

    }
}
