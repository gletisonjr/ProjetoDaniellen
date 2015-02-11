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
    public partial class AddEspecie : UserControl
    {
        private Form1 form;

        public AddEspecie()
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
        }

        public AddEspecie(Form1 form)
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            this.form = form;
        }

        private void Especie_Load(object sender, EventArgs e)
        {

        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            var especie = new Data.Especie();

            especie.nome = txtNome.Text;
            especie.descricao = txtDescricao.Text;

            DataContext.Save(especie);

            MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro de Espécie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.DefineEvent("Inicio", new Object());
        }

    }
}
