﻿using System;
using System.Collections.Generic;

namespace EntityFrameworkIntro.DbFirst.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
