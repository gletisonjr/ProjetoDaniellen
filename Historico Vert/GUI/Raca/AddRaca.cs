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
    public partial class AddRaca : UserControl
    {
        private Form1 form;

        public AddRaca()
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtEspecie.CarregarAutoComplete<Data.Especie>(a => a.nome);
        }

        public AddRaca(Form1 form)
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            this.form = form;
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            var especie = DataContext.Obter<Data.Especie>(o => o.nome == txtEspecie.Text);

            if (especie == null)
            {
                MessageBox.Show("Escolha uma espécie válida", "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var raca = new Data.Raca();
            raca.nome = txtNome.Text;
            raca.descricao = txtDescricao.Text;
            raca.idEspecie = especie.id;

            DataContext.Save(raca);

            MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.DefineEvent("Inicio", new Object());
        }
        
    }
}
