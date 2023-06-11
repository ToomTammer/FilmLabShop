using System;
using System.Collections.Generic;

namespace FilmLabShop.Models.db;

public partial class TbProduct
{
    public int PdId { get; set; }

    public byte[]? PdImg { get; set; }

    public string? PdName { get; set; }

    public double? PdPrice { get; set; }

    public int? PdStock { get; set; }

    public string PdStatus { get; set; } = null!;

    public int? CateId { get; set; }

    public string PdDetail { get; set; } = null!;

    public string PdSubHead { get; set; } = null!;

    public int? PdDelete { get; set; }

    public virtual TbCategory? Cate { get; set; }

    public virtual ICollection<TbBill> TbBills { get; set; } = new List<TbBill>();
}
