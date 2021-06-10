using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public class DataCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
           new List<Category>
           {
                new Category{CategoryID=1, CategoryName="Events", Description="Events that we offer to embrace by our music"},
                new Category{CategoryID=2, CategoryName="Artist Management", Description= "Welcome crew members! , We hope you enjoy our hospitality during the fly towards success"}
                
           };
    }
}
