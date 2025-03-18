using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class PokemonOwner
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }

        public Pokemon Pokemon { get; set; }
        public Owner Owner { get; set; }
    }
}