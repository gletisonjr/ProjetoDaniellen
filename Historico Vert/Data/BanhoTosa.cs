using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
    public class BanhoTosa
    {
        public int id { get; set; }
        public int idPaciente { get; set; }
        public bool tosa { get; set; }
        public bool banho { get; set; }
        public String data { get; set; }
        public String horario { get; set; }

        public BanhoTosa()
        {
            this.id =
            this.idPaciente = -1;
            this.tosa =
            this.banho = false;
            this.data =
            this.horario = "";
        }

        public BanhoTosa(int idPaciente, bool banho, bool tosa, String data, String horario)
        {
            this.id = -1;
            this.idPaciente = idPaciente;
            this.tosa = tosa;
            this.banho = banho;
            this.data = data;
            this.horario = horario;
        }

        public BanhoTosa(int id, int idPaciente, bool banho, bool tosa, String data, String horario)
        {
            this.id = id;
            this.idPaciente = idPaciente;
            this.tosa = tosa;
            this.banho = banho;
            this.data = data;
            this.horario = horario;
        }
    }
}
