using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Historico_Vert.Configuracoes
{
    public partial class Configuracoes : UserControl
    {
        public Configuracoes()
        {
            InitializeComponent();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pctLogo.Load(fileDialog.FileName);
                pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
