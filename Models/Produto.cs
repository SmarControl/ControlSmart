using System;
using System.Collections.Generic;
using System.Text;

namespace Dados_Smart.Controller
{
    class Produto
    {
        public int ID { get; set; }
        public DateTime Data_Inicio { get; set; }
        public string Fabricante { get; set; }
        public string Modelo_Produto { get; set; }
        public string Nome_Produto { get; set; }
        public int Disponibilidade_ID { get; set; }
        public DateTime Data_Edicao { get; set; }
    }
}
