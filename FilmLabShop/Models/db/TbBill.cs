using System;
using System.Collections.Generic;

namespace FilmLabShop.Models.db;

public partial class TbBill
{
    public int BillId { get; set; }

    public int? CusId { get; set; }

    public int? PdId { get; set; }

    public DateTime? BillDate { get; set; }

    public string PdName { get; set; } = null!;

    public int? BillQty { get; set; }

    public double? BillTotal { get; set; }

    public virtual TbCustomer? Cus { get; set; }

    public virtual TbProduct? Pd { get; set; }
}
