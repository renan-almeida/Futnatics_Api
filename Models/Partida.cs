using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futnatics.Models
{
    public class Partida
    {
        public int Id {get; set; }
        public DateTime Data { get; set; }
        public string Estadio { get; set; }
        public string TimeCasa { get; set; }
        public string  TimeFora  { get; set; }
        
    }
}