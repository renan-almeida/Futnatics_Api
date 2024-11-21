using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futnatics.Models
{
    public class Time
    {
         public int Id {get; set; }
          public string Nome {get; set; }
         public string Sigla { get; set; }
    public DateTime FundadoEm { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }
    public string Estadio { get; set; }
     public string MaiorRival { get; set; }

     public string Mascote {get; set; }
      public string Logo { get; set; }
    }
}