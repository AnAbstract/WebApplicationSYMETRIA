using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationSYMETRIA.DATA.Interfaces;
using WebApplicationSYMETRIA.DATA.Models;

namespace WebApplicationSYMETRIA.DATA.mocks
{
    public class MockItems : IAllItems
    {

        private readonly IItemsCategory _itemsCategory = new MockCategory();

        public IEnumerable<Item> Items
        {
            get
            {
                return new List<Item>
                {
                    new Item {
                        name = "Layer01",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/SA.jpg",
                        price = 500000,
                        isFavorite = true,
                        realized = false,
                        Category = _itemsCategory.AllCategories.First()
                    },

                    new Item {
                        name = "We Are All Connected",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/ITMO.jpg",
                        price = 0,
                        isFavorite = true,
                        realized = false,
                        Category = _itemsCategory.AllCategories.First()
                    },

                    new Item {
                        name = "Final Project",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/FinPr.jpg",
                        price = 0,
                        isFavorite = true,
                        realized = false,
                        Category = _itemsCategory.AllCategories.First()
                    },

                    new Item {
                        name = "David Chalmers",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Chalm.jpg",
                        price = 0,
                        isFavorite = true,
                        realized = false,
                        Category = _itemsCategory.AllCategories.Last()
                    },

                    new Item {
                        name = "Borusik",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Bor.jpg",
                        price = 0,
                        isFavorite = true,
                        realized = false,
                        Category = _itemsCategory.AllCategories.Last()
                    },

                    new Item {
                        name = "Andron",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Andr.jpg",
                        price = 0,
                        isFavorite = true,
                        realized = false,
                        Category = _itemsCategory.AllCategories.Last()
                    }

                };
            }
        }
        public IEnumerable<Item> getFavItems { get; set; }

        public Item getObjectItem(int itemID)
        {
            throw new NotImplementedException();
        }
    }
}
