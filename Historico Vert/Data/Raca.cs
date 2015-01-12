using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
     public class Raca : Especie
    {
        public int idEspecie { get; set; }

        public Raca()
        {
            this.id =
            this.idEspecie = -1;
            this.nome =
            this.descricao = "";
        }

        public Raca(int idEspecie, String nome, String descricao)
        {
            this.id = -1;
            this.idEspecie = idEspecie;
            this.nome = nome;
            this.descricao = descricao;
        }

        public Raca(int id, int idEspecie, String nome, String descricao)
        {
            this.id = id;
            this.idEspecie = idEspecie;
            this.nome = nome;
            this.descricao = descricao;
        }
    }
}
