﻿namespace TemplateMethodPattern.Core;

public class InvoiceLine
{
    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}