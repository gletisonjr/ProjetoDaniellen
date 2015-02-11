using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.GUI.Raca
{
    public partial class PesquisaRaca : UserControl
    {
        private Form1 form;

        public PesquisaRaca()
        {
            InitializeComponent();
        }

        public PesquisaRaca(Form1 form)
        {
            InitializeComponent();
            this.form = form;
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
    }
}
