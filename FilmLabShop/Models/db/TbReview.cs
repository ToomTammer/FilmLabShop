using System;
using System.Collections.Generic;

namespace FilmLabShop.Models.db;

public partial class TbReview
{
    public int RevId { get; set; }

    public string UserName { get; set; } = null!;

    public string PdName { get; set; } = null!;

    public string RevTitle { get; set; } = null!;

    public string RevMessage { get; set; } = null!;

    public DateTime? RevDate { get; set; }

    public double? Rating { get; set; }
}
