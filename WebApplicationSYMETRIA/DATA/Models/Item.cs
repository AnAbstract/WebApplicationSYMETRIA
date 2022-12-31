using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSYMETRIA.DATA.Models
{
    public class Item
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; }

        public ulong price { set; get; }

        public bool isFavorite { set; get; }

        public bool realized { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
