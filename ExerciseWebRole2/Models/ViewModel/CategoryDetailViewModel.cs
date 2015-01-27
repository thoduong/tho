using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExerciseWebRole2.Database;
namespace ExerciseWebRole2.Models.ViewModel
{
    public class CategoryDetailViewModel
    {
        public IEnumerable<Product> ListProductBelong { get; set; }
        public IEnumerable<Category> ListCategory { get; set; }
    }
}