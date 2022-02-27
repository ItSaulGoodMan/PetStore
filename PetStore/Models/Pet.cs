using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        public string PetPictureURL { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }

        //Relationships 
        public List<Toy> Toys { get; set; }
    }
}
