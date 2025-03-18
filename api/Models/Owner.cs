using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? Country { get; set; }

        public ICollection<PokemonOwner > PokemonOwners { get; set; }

    }
}