using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string FullName { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string Image { get; set; } = null!;

    public virtual ICollection<Accounting> Accountings { get; set; } = new List<Accounting>();
}
