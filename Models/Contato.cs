using System;
using System.Collections.Generic;
using System.Text;

namespace Dados_Smart.Controller
{
    class Contato
    {
        public int ID { get; set; }
        public DateTime Data_Inicio { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }
        public int Cliente_Grupo_ID { get; set; }
        public DateTime Data_Edicao { get; set; }
    }
}
