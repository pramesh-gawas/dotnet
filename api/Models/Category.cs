using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}