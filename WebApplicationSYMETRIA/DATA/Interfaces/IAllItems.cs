using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationSYMETRIA.DATA.Models;

namespace WebApplicationSYMETRIA.DATA.Interfaces
{
    public interface IAllItems
    {
        IEnumerable<Item> Items { get; }
        IEnumerable<Item> getFavItems { get; set; }
        Item getObjectItem(int itemID);
    }
}
