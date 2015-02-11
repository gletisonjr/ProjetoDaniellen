using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.GUI.Prontuario
{
    public partial class AddProntuario : UserControl
    {
        private Form1 form;

        public AddProntuario()
        {
            InitializeComponent();
            txtProntuario.ScrollBars = ScrollBars.Vertical;
            txtProntuario.AcceptsReturn =
            txtProntuario.AcceptsTab =
            txtProntuario.WordWrap = true;
        }

        public AddProntuario(Form1 form)
        {
            InitializeComponent();
            txtProntuario.ScrollBars = ScrollBars.Vertical;
            txtProntuario.AcceptsReturn =
            txtProntuario.AcceptsTab =
            txtProntuario.WordWrap = true;
            this.form = form;

        }

        private void rbtnHoje_CheckedChanged(object sender, EventArgs e)
        {
            dtpData.Enabled = false;
        }

        private void rbtnOutro_CheckedChanged(object sender, EventArgs e)
        {
            dtpData.Enabled = true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbProntuario.Visible = true;
        }

        private void txtNomeDono_Leave(object sender, EventArgs e)
        {
            grbPaciente.Visible = true;
        }

        private void txtNomeAnimal_Leave(object sender, EventArgs e)
        {
            grbPaciente.Visible = true;
        }

        private void AddProntuario_Load(object sender, EventArgs e)
        {

        }

        private void grbProntuario_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prontuario adicionado com sucesso!","Cadastro de Prontuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.DefineEvent("Inicio", new Object());
        }

    }
}
