using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Historico_Vert.GUI.Pessoa;
//using Historico_Vert.GUI.Prontuario;
//using Historico_Vert.GUI.Paciente;
using Historico_Vert.GUI.Especie;
//using Historico_Vert.GUI.Raca;
//using Historico_Vert.GUI.Vacina;
//using Historico_Vert.GUI.BanhoTosa;
using Historico_Vert.GUI.Principal;


namespace Historico_Vert.GUI.Principal
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
            forma.DefineEvent("ProntuarioNovo", new Object());
        }

        private void btnProntuarioPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("ProntuarioPesquisar", new Object());
        }

        private void btnBanhoTosaNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("BanhoTosaNovo", new Object());
        }

        private void btnBanhoTosaPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("BanhoTosaPesquisar", new Object()); 
        }

        private void btnEspecieNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("EspecieNovo", new Object());
        }

        private void btnEspeciePesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("EspeciePesquisar", new Object());
        }

        private void btnDonoNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("DonoNovo", new Object());
        }
        
        private void btnDonoPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("DonoPesquisar", new Object());
        }

        private void btnPacienteNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("PacienteNovo", new Object());
        }

        private void btnPacientePesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("PacientePesquisar", new Object());
        }

        private void btnRacaNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("RacaNovo", new Object());
        }

        private void btnRacaPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("RacaPesquisar", new Object());
        }

        private void btnVacinaNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("VacinaNovo", new Object());
        }

        private void btnVacinaPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("VacinaPesquisar", new Object());
        }

        private void btnMedicoNovo_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("MedicoNovo", new Object());
        }

        private void btnMedicoPesquisar_Click(object sender, EventArgs e)
        {
            forma.DefineEvent("MedicoPesquisar", new Object());
        }

    }
}
