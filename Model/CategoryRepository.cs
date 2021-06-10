using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDBContext _appDBContext;

        public CategoryRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;

        }

        public IEnumerable<Category>  AllCategories
        {
            get
            {
                return _appDBContext.Categories;
            }
        }
            


    }
}
