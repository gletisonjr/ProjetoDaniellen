using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
    public class Prontuario
    {
        public int id { get; set; }
        public int idPaciente { get; set; }
        public int idMedico { get; set; }
        public String texto { get; set; }
        public String expressaoChave { get; set; }
        public String data { get; set; }

        public Prontuario()
        {
            this.id =
            this.idMedico =
            this.idPaciente = -1;
            this.texto =
            this.expressaoChave =
            this.data = "";
        }

        public Prontuario(int idMedico, int idPaciente, String texto, String expressaoChave, String data)
        {
            this.id = -1;
            this.idMedico = idMedico;
            this.idPaciente = idPaciente;
            this.texto = texto;
            this.expressaoChave = expressaoChave;
            this.data = data;
        }

        public Prontuario(int id,int idMedico, int idPaciente, String texto, String expressaoChave, String data)
        {
            this.id = id;
            this.idMedico = idMedico;
            this.idPaciente = idPaciente;
            this.texto = texto;
            this.expressaoChave = expressaoChave;
            this.data = data;
        }

    }
}
