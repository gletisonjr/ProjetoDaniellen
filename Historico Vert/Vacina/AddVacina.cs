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
    public partial class AddVacina : UserControl
    {
        private Form1 form;

        public AddVacina()
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
        }

        public AddVacina(Form1 form)
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            this.form = form;
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro de Vacinas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.DefineEvent("Inicio", new Object());
        }

    }
}
