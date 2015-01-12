using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
   public class Pessoa
    {
        public String nome { get; set; }
        public String email { get; set; }
        public String telefone { get; set; }
        public int id { get; set; }
        public Endereco endereco { get; set; }

        public Pessoa()
        {
            this.telefone = 
            this.email = 
            this.nome = "";
            this.id = -1;
            this.endereco = new Endereco();
        }

        public Pessoa(String nome, String telefone, String email,Endereco endereco)
        {
            this.telefone = telefone;
            this.email = email;
            this.nome = nome;
            this.id = -1;
            this.endereco = endereco;
        }

        public Pessoa(int id, String nome, String telefone, String email,Endereco endereco)
        {
            this.telefone = telefone;
            this.email = email;
            this.nome = nome;
            this.id = id;
            this.endereco = endereco;
        }

    }
}
