using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
    public class Vacina
    {
        public int id { get; set; }
        public int duracao { get; set; }
        public String nome { get; set; }
        public String tempo { get; set; }
        public String descricao { get; set; }

        public Vacina()
        {
            this.id =
            this.duracao = -1;
            this.nome =
            this.tempo =
            this.descricao = "";
        }

        public Vacina(String nome, String descricao, String tempo, int duracao)
        {
            this.id = -1;
            this.duracao = duracao;
            this.nome = nome;
            this.tempo = tempo;
            this.descricao = descricao;
        }

        public Vacina(int id, String nome, String descricao, String tempo, int duracao)
        {
            this.id = id;
            this.duracao = duracao;
            this.nome = nome;
            this.tempo = tempo;
            this.descricao = descricao;
        }

    }
}
