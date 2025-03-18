using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Pokemon
    {
     public String? Name {set;get;}
     public int Id { get; set; }

     public DateTime BirthDate { get; set; }

public ICollection<Review> Reviews { get; set; }
        
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}