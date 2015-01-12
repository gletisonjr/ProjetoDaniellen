using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
    public class Medico : Pessoa
    {

        public int idMedico { get; set; }
        public int crmv { get; set; }

        public Medico()
        {
            this.nome =
            this.telefone =
            this.email = "";
            this.id =
            this.idMedico =
            this.crmv = -1;
            this.endereco = new Endereco();
        }

        public Medico(String nome,String email, String telefone, int crmv, Endereco endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.id = 
            this.idMedico = -1;
            this.crmv = crmv;
            this.endereco = endereco;
        }

        public Medico(int idPessoa, String nome, String email, String telefone, int crmv, Endereco endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.id = idPessoa;
            this.idMedico = -1;
            this.crmv = crmv;
            this.endereco = endereco;
        }

        public Medico(int id, int idCliente, String nome, String email, String telefone, int crmv, Endereco endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.id = id;
            this.idMedico = idCliente;
            this.crmv = crmv;
            this.endereco = endereco;
        }

    }
}
