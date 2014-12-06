using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.Vacina
{
    public partial class PesquisaVacina : UserControl
    {
        public PesquisaVacina()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbVacina.Visible = true;
        }
    }
}
