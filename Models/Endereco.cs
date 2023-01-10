using System;
using System.Collections.Generic;
using System.Text;

namespace Dados_Smart.Controller
{
    class Endereco
    {
        public int ID { get; set; }
        public DateTime Data_Inicio { get; set; }
        public int CEP { get; set; }
        public string Endereço { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string UF { get; set; }
        public int Cliente_Grupo_ID { get; set; }
        public DateTime Data_Edicao { get; set; }
    }
}
