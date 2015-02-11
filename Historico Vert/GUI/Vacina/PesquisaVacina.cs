using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.GUI.Vacina
{
    public partial class PesquisaVacina : UserControl
    {
        private Form1 form;

        public PesquisaVacina()
        {
            InitializeComponent();
        }

        public PesquisaVacina(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbVacina.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly =
            txtDescricao.ReadOnly = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly =
            txtDescricao.ReadOnly = true;
            MessageBox.Show("Atualizado com Sucesso!","Atualização",MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.DefineEvent("Inicio",new Object());
        }
    }
}
