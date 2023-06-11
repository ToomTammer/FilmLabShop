using System;
using System.Collections.Generic;

namespace FilmLabShop.Models.db;

public partial class TbCustomer
{
    public int CusId { get; set; }

    public string CusName { get; set; } = null!;

    public string CusEmail { get; set; } = null!;

    public string CusPhone { get; set; } = null!;

    public string CusAddress { get; set; } = null!;

    public byte[] CusReceipt { get; set; } = null!;

    public virtual ICollection<TbBill> TbBills { get; set; } = new List<TbBill>();
}
