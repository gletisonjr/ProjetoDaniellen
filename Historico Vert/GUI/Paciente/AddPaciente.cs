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
    public partial class AddPaciente : UserControl
    {
        private Form1 form;

        public AddPaciente()
        {
            InitializeComponent();
        }

        public AddPaciente(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtEspecie.Visible = false;
        }

        private void rdbOutra_CheckedChanged(object sender, EventArgs e)
        {
            txtEspecie.Visible = true; 
        }

        private void rdbGato_CheckedChanged(object sender, EventArgs e)
        {
            txtEspecie.Visible = false;
        }

        private void AddPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            if (btAcao.Text.Equals("Atualizar"))
                MessageBox.Show("Atualizado com Sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.DefineEvent("Inicio", new Object());
        }

        public void SetbtAcao_Text(String text)
        {
            btAcao.Text = text;
        }


    }
}
