using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExerciseWebRole2.Database;
namespace ExerciseWebRole2.Models.ViewModel
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<Category> ListCategory { get; set; }
    }
}