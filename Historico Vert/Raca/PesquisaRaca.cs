using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.Raca
{
    public partial class PesquisaRaca : UserControl
    {
        public PesquisaRaca()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            grbRaca.Visible = true;
        }
    }
}
