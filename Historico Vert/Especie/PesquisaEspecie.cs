using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.Especie
{
    public partial class PesquisaEspecie : UserControl
    {
        public PesquisaEspecie()
        {
            InitializeComponent();
            txtDescricao.ScrollBars = ScrollBars.Vertical;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbEspecie.Visible = true;
        }

    }
}
