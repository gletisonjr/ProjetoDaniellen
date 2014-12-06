using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

namespace Historico_Vert
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            tsmiPrincipal_Click(new object(), new EventArgs());
        }


        public void ClearForm()
        {
            foreach (var item in Controls)
            {
                var userControl = item as UserControl;

                if (userControl != null)
                {
                    userControl.Hide();
                    userControl.Dispose();
                }
            }
        }

        public void Show(UserControl control)
        {
            control.Location = new Point(15, 25);
            control.Show();
        }

        public void DefineEvent(String nome)
        {
            var o = new Object();
            var e = new EventArgs();
            if (nome.Equals("BanhoTosaNovo"))
                tsmiBanhoTosaNovo_Click(o, e);
            if (nome.Equals("BanhoTosaPesquisar"))
                tsmiBanhoTosaPesquisar_Click(o, e);
            if (nome.Equals("DonoNovo"))
                tsmiDonoNovo_Click(o, e);
            if (nome.Equals("DonoPesquisar"))
                tsmiDonoPesquisar_Click(o, e);
            if (nome.Equals("EspecieNovo"))
                tsmiEspecieNovo_Click(o, e);
            if (nome.Equals("EspeciePesquisar"))
                tsmiEspeciePesquisar_Click(o, e);
            if (nome.Equals("MedicoNovo"))
                tsmiMedicoNovo_Click(o, e);
            if (nome.Equals("MedicoPesquisar"))
                tsmiMedicoPesquisar_Click(o, e);
            if (nome.Equals("PacienteNovo"))
                    tsmiPacienteNovo_Click(o, e);
            if (nome.Equals("PacientePesquisar"))
                tsmiPacientePesquisar_Click(o, e);
            if (nome.Equals("ProntuarioNovo"))
                tsmiProntuarioNovo_Click(o, e);
            if (nome.Equals("ProntuarioPesquisar"))
                tsmiProntuarioPesquisar_Click(o, e);
            if (nome.Equals("RacaNovo"))
                tsmiRacaNovo_Click(o, e);
            if (nome.Equals("RacaPesquisar"))
                tsmiRacaPesquisar_Click(o, e);
            if (nome.Equals("VacinaNovo"))
                tsmiVacinaNovo_Click(o, e);
            if (nome.Equals("VacinaPesquisar"))
                tsmiVacinaPesquisar_Click(o, e);

        }


        public void tsmiProntuarioNovo_Click(object sender, EventArgs e)
        {
            ClearForm();
            var user = new AddProntuario();
            Controls.Add(user);
            Show(user);
        }

        private void tsmiProntuarioPesquisar_Click(object sender, EventArgs e)
        {
            ClearForm();
            var user = new PesquisaProntuario();
            Controls.Add(user);
            Show(user);
        }

        private void tsmiPacienteNovo_Click(object sender, EventArgs e)
        {
            ClearForm();
            var paciente = new AddPaciente();
            Controls.Add(paciente);
            Show(paciente);
        }

        private void tsmiPacientePesquisar_Click(object sender, EventArgs e)
        {
            ClearForm();
            var paciente = new PesquisaPaciente();
            Controls.Add(paciente);
            Show(paciente);

        }

        private void tsmiDonoNovo_Click(object sender, EventArgs e)
        {
            ClearForm();
            var pessoa = new AddPessoa();
            Controls.Add(pessoa);
            Show(pessoa);
        }

        private void tsmiDonoPesquisar_Click(object sender, EventArgs e)
        {
            ClearForm();
            var pessoa = new PesquisaPessoa();
            Controls.Add(pessoa);
            Show(pessoa);
        }

        private void tsmiEspecieNovo_Click(object sender, EventArgs e)
        {
            ClearForm();
            var especie = new AddEspecie();
            Controls.Add(especie);
            Show(especie);
        }

        private void tsmiEspeciePesquisar_Click(object sender, EventArgs e)
        {
            ClearForm();
            var especie = new PesquisaEspecie();
            Controls.Add(especie);
            Show(especie);
        }

        private void tsmiRacaNovo_Click(object sender, EventArgs e)
        {
            ClearForm();
            var raca = new AddRaca();
            Controls.Add(raca);
            Show(raca);
        }

        private void tsmiRacaPesquisar_Click(object sender, EventArgs e)
        {
            ClearForm();
            var raca = new PesquisaRaca();
            Controls.Add(raca);
            Show(raca);
        }

        private void tsmiMedicoNovo_Click(object sender, EventArgs e)
        {
            ClearForm();
            var vet = new AddPessoa();
            vet.SetGrbPessoaName("Médico Veterinário");
            Controls.Add(vet);
            Show(vet);
        }

        private void tsmiMedicoPesquisar_Click(object sender, EventArgs e)
        {
            ClearForm();
            var vet = new PesquisaPessoa();
            vet.PesquisaMedico();
            Controls.Add(vet);
            Show(vet);
        }

        private void tsmiVacinaNovo_Click(object sender, EventArgs e)
        {
            ClearForm();
            var vacina = new AddVacina();
            Controls.Add(vacina);
            Show(vacina);
        }

        private void tsmiVacinaPesquisar_Click(object sender, EventArgs e)
        {
            ClearForm();
            var vacina = new PesquisaVacina();
            Controls.Add(vacina);
            Show(vacina);
        }

        private void tsmiBanhoTosaNovo_Click(object sender, EventArgs e)
        {
            ClearForm();
            var banho = new AddBanhoTosa();
            Controls.Add(banho);
            Show(banho);
        }

        private void tsmiBanhoTosaPesquisar_Click(object sender, EventArgs e)
        {
            ClearForm();
            var banho = new PesquisaBanhoTosa();
            Controls.Add(banho);
            Show(banho);
        }

        private void tsmiPrincipal_Click(object sender, EventArgs e)
        {
            ClearForm();
            var principio = new Inicio(this);
            Controls.Add(principio);
            Show(principio);
        }

    }
}
