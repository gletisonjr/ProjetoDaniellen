using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.BanhoTosa
{
    public partial class PesquisaBanhoTosa : UserControl
    {
        private Form1 form;

        public PesquisaBanhoTosa()
        {
            InitializeComponent();
        }

        public PesquisaBanhoTosa(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbPeriodo.Visible = true;

        }

        private void btnAgrupar_Click(object sender, EventArgs e)
        {
            grbBanhoTosa.Visible = true;
        }

        private void txtNomeDono_Leave(object sender, EventArgs e)
        {
            grbPaciente.Visible = true;
        }

        private void txtNomeAnimal_Leave(object sender, EventArgs e)
        {
            grbPaciente.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            form.DefineEvent("BanhoTosaNovo", "a");
        }

    }
}
