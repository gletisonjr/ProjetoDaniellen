using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
//using Historico_Vert.GUI.Prontuario;
//using Historico_Vert.GUI.Paciente;
using Historico_Vert.DAO;
//using Historico_Vert.GUI.Pessoa;
//using Historico_Vert.GUI.Especie;
//using Historico_Vert.GUI.Raca;
//using Historico_Vert.GUI.Vacina;
//using Historico_Vert.GUI.BanhoTosa;
using Historico_Vert.GUI.Especie;
using Historico_Vert.GUI.Principal;
using System.IO;


namespace Historico_Vert.GUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            var con = new Connection();
            
            //con.Connect();
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

        public void DefineEvent(String nome, Object o)
        {
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
            if (nome.Equals("Inicio"))
                tsmiPrincipal_Click(o, e);

        }


        public void tsmiProntuarioNovo_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var user = new AddProntuario(this);
            //Controls.Add(user);
            //Show(user);
        }

        private void tsmiProntuarioPesquisar_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var user = new PesquisaProntuario(this);
            //Controls.Add(user);
            //Show(user);
        }

        private void tsmiPacienteNovo_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var paciente = new AddPaciente(this);
            //if (sender.Equals("a"))
            //   paciente.SetbtAcao_Text("Atualizar");
            //Controls.Add(paciente);
            //Show(paciente);
        }

        private void tsmiPacientePesquisar_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var paciente = new PesquisaPaciente(this);
            //Controls.Add(paciente);
            //Show(paciente);

        }

        private void tsmiDonoNovo_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var pessoa = new AddPessoa(this);
            //if (sender is Data.Pessoa)
            //{
            //    pessoa.SetBtAcao_Text("Atualizar");
            //    pessoa.pessoa = (Data.Pessoa) sender;
            //    pessoa.ColocarDadosTela();
            //}
            //Controls.Add(pessoa);
            //Show(pessoa);
        }

        private void tsmiDonoPesquisar_Click(object sender, EventArgs e)
        {
        //    ClearForm();
        //    var pessoa = new PesquisaPessoa(this);
        //    if (sender is Data.Pessoa)
        //    {
        //        pessoa.ColocarDadosTela((Data.Pessoa)sender);
        //    }
        //    Controls.Add(pessoa);
        //    Show(pessoa);
        }

        private void tsmiEspecieNovo_Click(object sender, EventArgs e)
        {
            ClearForm();
            var especie = new AddEspecie(this);
            Controls.Add(especie);
            Show(especie);
        }

        private void tsmiEspeciePesquisar_Click(object sender, EventArgs e)
        {
            ClearForm();
            var especie = new PesquisaEspecie(this);
            Controls.Add(especie);
            Show(especie);
        }

        private void tsmiRacaNovo_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var raca = new AddRaca(this);
            //Controls.Add(raca);
            //Show(raca);
        }

        private void tsmiRacaPesquisar_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var raca = new PesquisaRaca(this);
            //Controls.Add(raca);
            //Show(raca);
        }

        private void tsmiMedicoNovo_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var vet = new AddPessoa(this);
            //vet.SetGrbPessoaName("Dados do Médico Veterinário");
            //if (sender is Data.Pessoa)
            //{
            //    vet.SetBtAcao_Text("Atualizar");
            //    vet.pessoa = (Data.Pessoa) sender;
            //}
            //Controls.Add(vet);
            //Show(vet);
        }

        private void tsmiMedicoPesquisar_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var vet = new PesquisaPessoa(this);
            //if (sender is Data.Pessoa)
            //{
            //    vet.ColocarDadosTela((Data.Pessoa)sender);
            //}
            //vet.PesquisaMedico();
            //Controls.Add(vet);
            //Show(vet);
        }

        private void tsmiVacinaNovo_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var vacina = new AddVacina(this);
            //Controls.Add(vacina);
            //Show(vacina);
        }

        private void tsmiVacinaPesquisar_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var vacina = new PesquisaVacina(this);
            //Controls.Add(vacina);
            //Show(vacina);
        }

        private void tsmiBanhoTosaNovo_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var banho = new AddBanhoTosa();
            //Controls.Add(banho);
            //Show(banho);
        }

        private void tsmiBanhoTosaPesquisar_Click(object sender, EventArgs e)
        {
            //ClearForm();
            //var banho = new PesquisaBanhoTosa(this);
            //Controls.Add(banho);
            //Show(banho);
        }

        private void tsmiPrincipal_Click(object sender, EventArgs e)
        {
            ClearForm();
            var principio = new Inicio(this);
            Controls.Add(principio);
            Show(principio);
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
            var configuracoes = new Configuracoes.Configuracoes();
            Controls.Add(configuracoes);
            Show(configuracoes);
        }

    }
}
