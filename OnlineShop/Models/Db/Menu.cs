using System;
using System.Collections.Generic;

namespace OnlineShop.Models.Db;

public partial class Menu
{
    public int Id { get; set; }

    public string? MenueTitle { get; set; }

    public string? Link { get; set; }

    public string? Type { get; set; }
}
