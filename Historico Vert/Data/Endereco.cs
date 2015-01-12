using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
    public class Endereco
    {
        public int id { get; set; }
        public String rua { get; set; }
        public String numero { get; set; }
        public String complemento { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public String cep { get; set; }

        public Endereco()
        {
            this.id = -1;
            this.rua =
            this.numero =
            this.complemento =
            this.bairro =
            this.cidade =
            this.estado =
            this.cep = "";
        }

        public Endereco(String rua, String bairro, String cidade, String estado, String cep)
        {
            this.id = -1;
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.numero =
            this.complemento = "";
        }

        public Endereco(int id,String rua, String numero, String complemento, String bairro, String cidade, String estado, String cep)
        {
            this.id = id;
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.numero = numero;
            this.complemento = complemento;
        }

    }
}
