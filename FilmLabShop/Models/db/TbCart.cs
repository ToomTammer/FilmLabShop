using System;
using System.Collections.Generic;

namespace FilmLabShop.Models.db;

public partial class TbCart
{
    public int CartId { get; set; }

    public byte[] CartImg { get; set; } = null!;

    public string CartName { get; set; } = null!;

    public double? CartPrice { get; set; }

    public int? CartQty { get; set; }

    public double? CartTotal { get; set; }
}
