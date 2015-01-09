using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.BanhoTosa
{
    public partial class AddBanhoTosa : UserControl
    {
        public AddBanhoTosa()
        {
            InitializeComponent();
        }

        private void rbtnOutro_CheckedChanged(object sender, EventArgs e)
        {
            dtpData.Enabled = true;
        }

        private void rbtnHoje_CheckedChanged(object sender, EventArgs e)
        {
            dtpData.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hora marcada com Sucesso!", "Marcação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
