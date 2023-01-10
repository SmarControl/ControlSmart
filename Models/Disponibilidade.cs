using System;
using System.Collections.Generic;
using System.Text;

namespace Dados_Smart.Controller
{
    class Disponibilidade
    {
        public int ID { get; set; }
        public DateTime Data_Inicio { get; set; }
        public string Status_Disponivel { get; set; }
        public DateTime Data_Edicao { get; set; }
    }
}
