using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public int RealName { get; set; }
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
    }
}
