using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.Paciente
{
    public partial class PesquisaPaciente : UserControl
    {
        private Form1 form;


        public PesquisaPaciente()
        {
            InitializeComponent();
        }

        public PesquisaPaciente(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbPaciente.Visible = true;
        }

        private void grbPaciente_Enter(object sender, EventArgs e)
        {

        }

        private void grbPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            form.DefineEvent("PacienteNovo","a");
        }
    }
}
