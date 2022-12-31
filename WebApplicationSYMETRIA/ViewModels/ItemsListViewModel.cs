using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationSYMETRIA.DATA.Models;

namespace WebApplicationSYMETRIA.ViewModels
{
    public class ItemsListViewModel
    {
        public IEnumerable<Item> getAllItems { get; set;}

        public string currCategory { get; set; }
    }
}
