using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffetLista1.Models.Buffet.Evento
{
    public class SituacaoEvento
    {
        public SituacaoEvento()
        {
        }

        public SituacaoEvento(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public int id { get; set; }
        public string descricao { get; set; }
    }
}
