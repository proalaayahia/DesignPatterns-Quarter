﻿namespace TemplateMethodPattern.Core;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal UnitPrice { get; set; }
}