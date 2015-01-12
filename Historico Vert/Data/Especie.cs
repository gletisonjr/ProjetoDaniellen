using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
    public class Especie
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String descricao { get; set; }

        public Especie()
        {
            this.id = -1;
            this.nome =
            this.descricao = "";
        }

        public Especie(String nome, String descricao)
        {
            this.id = -1;
            this.nome = nome;
            this.descricao = descricao;
        }

        public Especie(int id, String nome, String descricao)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
        }
    }
}
