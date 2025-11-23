using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models;

public partial class Accounting
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int TypeId { get; set; }

    public int Amount { get; set; }

    public string? Description { get; set; }

    public DateTime DateTime { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual AccountingType Type { get; set; } = null!;

    // Not Map

 //   [NotMapped]
  //  public string FullName { get => Customer.FullName; }
}
