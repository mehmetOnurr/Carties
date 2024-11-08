using System;

namespace Contracts;

public class AuctionFinished
{
    public bool ItemSold { get; set; }
    public String AuctionId { get; set; }
    public String Winner { get; set; }
    public String Seller { get; set; }
    public int? Amount { get; set; }
}
