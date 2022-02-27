using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Category_Toy
    {
        public int ToyId { get; set; }
        public Toy Toy { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }



    }
}
