using System;
using System.Collections.Generic;

namespace FilmLabShop.Models.db;

public partial class TbAdminstrator
{
    public int AdminId { get; set; }

    public string AdminName { get; set; } = null!;

    public string AdminPw { get; set; } = null!;
}
