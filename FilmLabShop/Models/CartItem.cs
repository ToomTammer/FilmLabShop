using FilmLabShop.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLabShop.Models
{
    public class CartItem
    {
        public int CartId { get; set; }
        public byte[] CartImg { get; set; }
        public string CartName { get; set; }
        public double? CartPrice { get; set; }
        public int? CartQty { get; set; }
        public int? CartDelete { get; set; }
        public double? CartTotal { get; set; }
        public int? CartStock { get; set; }

        public TbProduct TbProduct { get; set; }
        public TbCustomer tbCustomer { get; set; }

    }
}