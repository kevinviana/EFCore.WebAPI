using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descritption { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public List<HeroBattle> HeroBattles { get; set; }
    }
}
