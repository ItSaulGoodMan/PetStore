using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Toy
    {   
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Info { get; set; }
        public Double Price { get; set; }
        public string ImageURL { get; set; }

        //Relationships
        public List<Category_Toy> Categories_Toys { get; set; }

        //Pet
        public int PetId { get; set; }
        [ForeignKey("PetId")]
        public Pet Pet { get; set; }

        //Brand
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
    }
}
