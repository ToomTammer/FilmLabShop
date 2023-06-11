using System;
using System.Collections.Generic;

namespace FilmLabShop.Models.db;

public partial class TbCategory
{
    public int CateId { get; set; }

    public string? CateName { get; set; }

    public virtual ICollection<TbProduct> TbProducts { get; set; } = new List<TbProduct>();
}
