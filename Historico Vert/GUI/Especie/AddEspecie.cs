using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Historico_Vert.Data;
using System.IO;

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

        public AddEspecie(Form1 form) : this()
        {
            this.form = form;
        }

        private void Especie_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            var especie = DataContext.Obter<Data.Especie>(a => a.nome == txtNome.Text);
            if (especie == null)
            {
                especie = new Data.Especie();
                especie.nome = txtNome.Text;
                especie.descricao = txtDescricao.Text;
            }

            
            if (VerificaCampos())
            {
                if (DataContext.Save(especie))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro de Espécie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.DefineEvent("Inicio", new Object());
                }
                else
                    MessageBox.Show("Erro ao cadastrar!\nPor favor verifique os dados!", "Cadastro de Espécie", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        /* Verifica se há campos em branco ou com números e gera uma mensagem na tela caso houver algum.
         * retorna false se houver algum erro
         * retorna true se não houve erro
         * 
        */
        private Boolean VerificaCampos() 
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Espécie sem nome definido!\nEspécies sem nomes não podem ser cadastradas!", "Cadastro de Espécie - Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtNome.Text.Contains("0") ||
                txtNome.Text.Contains("1") ||
                txtNome.Text.Contains("2") ||
                txtNome.Text.Contains("3") ||
                txtNome.Text.Contains("4") ||
                txtNome.Text.Contains("5") ||
                txtNome.Text.Contains("6") ||
                txtNome.Text.Contains("7") ||
                txtNome.Text.Contains("8") ||
                txtNome.Text.Contains("9") )
            {
                MessageBox.Show("Espécies não possuem números em seus nomes!\nPor favor, se a espécie já existe pesquise-a e edite-a!", "Cadastro de Espécie - Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

    }
}
