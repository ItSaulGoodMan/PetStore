using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        public string LogoURL { get; set; }
        public String Name { get; set; }
        public String Info { get; set; }

        //Relationships
        public List<Toy> Toys { get; set; }
    }
}
