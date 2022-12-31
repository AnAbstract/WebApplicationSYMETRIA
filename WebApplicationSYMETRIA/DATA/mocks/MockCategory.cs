using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationSYMETRIA.DATA.Interfaces;
using WebApplicationSYMETRIA.DATA.Models;

namespace WebApplicationSYMETRIA.DATA.mocks
{
    public class MockCategory : IItemsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Concepts", description = "Basis for the projects to develop" },
                    new Category { categoryName = "Philosophy", description = "Articles in read" }

                };
            }
        }
    }
}
