using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
    public class Paciente
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idRaca { get; set; }
        public String nome { get; set; }
        public String cor { get; set; }
        public String dataNascimento { get; set; }
        public String dataEntrada { get; set; }

        public Paciente()
        {
            this.id =
            this.idCliente =
            this.idRaca = -1;
            this.nome =
            this.cor =
            this.dataEntrada =
            this.dataNascimento = "";
        }

        public Paciente(int idCliente, int idRaca, String nome, String cor, String dataNascimento, String dataEntrada)
        {
            this.id = -1;
            this.idCliente = idCliente;
            this.idRaca = idRaca;
            this.nome = nome;
            this.cor = cor;
            this.dataEntrada = dataEntrada;
            this.dataNascimento = dataNascimento;
        }

        public Paciente(int id,int idCliente, int idRaca, String nome, String cor, String dataNascimento, String dataEntrada)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.idRaca = idRaca;
            this.nome = nome;
            this.cor = cor;
            this.dataEntrada = dataEntrada;
            this.dataNascimento = dataNascimento;
        }

    }
}
