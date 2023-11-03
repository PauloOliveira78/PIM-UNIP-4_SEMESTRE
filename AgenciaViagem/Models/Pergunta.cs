using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViagem.Models
{
    public class Pergunta:Categoria
    {
        public int idPergunta { get; set; }
        public string pergunta { get; set; }

    }
}
