using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Historico_Vert.Pessoa;
using Historico_Vert.Prontuario;
using Historico_Vert.Paciente;
using Historico_Vert.Especie;
using Historico_Vert.Raca;
using Historico_Vert.Vacina;
using Historico_Vert.BanhoTosa;
using Historico_Vert.Principal;


namespace Historico_Vert.Principal
{
    public partial class Inicio : UserControl
    {
        private Form1 forma;

        public Inicio()
        {
            InitializeComponent();
        }

        public Inicio(Form1 forma)
        {
            InitializeComponent();
            this.forma = forma;
        }

        private void btnProntuarioNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("ProntuarioNovo");
        }

        private void btnProntuarioPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("ProntuarioPesquisar");
        }

        private void btnBanhoTosaNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("BanhoTosaNovo");
        }

        private void btnBanhoTosaPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("BanhoTosaPesquisar"); 
        }

        private void btnEspecieNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("EspecieNovo");
        }

        private void btnEspeciePesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("EspeciePesquisar");
        }

        private void btnDonoNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("DonoNovo");
        }
        
        private void btnDonoPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("DonoPesquisar");
        }

        private void btnPacienteNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("PacienteNovo");
        }

        private void btnPacientePesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("PacientePesquisar");
        }

        private void btnRacaNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("RacaNovo");
        }

        private void btnRacaPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("RacaPesquisar");
        }

        private void btnVacinaNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("VacinaNovo");
        }

        private void btnVacinaPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("VacinaPesquisar");
        }

        private void btnMedicoNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("MedicoNovo");
        }

        private void btnMedicoPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("MedicoPesquisar");
        }

    }
}
