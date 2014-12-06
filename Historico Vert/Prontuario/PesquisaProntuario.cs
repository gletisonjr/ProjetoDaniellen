using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert
{
    public partial class PesquisaProntuario : UserControl
    {
        public PesquisaProntuario()
        {
            InitializeComponent();
            txtProntuario.ScrollBars = ScrollBars.Vertical;
            txtProntuario.AcceptsReturn =
            txtProntuario.AcceptsTab =
            txtProntuario.WordWrap = true;
         }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //txtNomeDono.LostFocus += new EventHandler(txtNomeDono_LostFocus);
        }

        void txtNomeDono_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbPeriodo.Visible = true;
        }

        private void rbtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataFinal.Enabled = 
            dtpDataInicial.Enabled = false;
        }

        private void rbtnSelecionar_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataFinal.Enabled =
            dtpDataInicial.Enabled = true;

        }

        private void btnAgrupar_Click(object sender, EventArgs e)
        {
            grbProntuarios.Visible = true;
        }

        private void txtNomeDono_Leave(object sender, EventArgs e)
        {
            grbPaciente.Visible = true; //txtNomeDono.ToString();
        }

        private void txtNomeAnimal_Leave(object sender, EventArgs e)
        {
            grbPaciente.Visible = true; //txtNomeDono.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtProntuario.ReadOnly =
            txtResumo.ReadOnly = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            txtProntuario.ReadOnly =
            txtResumo.ReadOnly = true;
        }

        private void grbPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
