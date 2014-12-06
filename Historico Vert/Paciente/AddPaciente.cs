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
        public AddPaciente()
        {
            InitializeComponent();
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

    }
}
