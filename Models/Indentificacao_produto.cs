using System;
using System.Collections.Generic;
using System.Text;

namespace Dados_Smart.Controller
{
    class Indentificacao_produto
    {
        public int ID { get; set; }
        public DateTime Data_Inicio { get; set; }
        public string Identificacao { get; set; }
        public int Cliente_Grupo_ID { get; set; }
        public int Produto_ID { get; set; }
        public DateTime Data_Edicao { get; set; }

    }
}
