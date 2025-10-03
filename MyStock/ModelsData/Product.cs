using System;
using System.Collections.Generic;

namespace MyStock.ModelsData;

public partial class Product
{
    public int Productid { get; set; }

    public string Productname { get; set; } = null!;

    public decimal Unitprice { get; set; }

    public int Unitsinstock { get; set; }
}
