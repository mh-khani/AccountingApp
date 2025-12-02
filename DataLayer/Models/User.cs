using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class User
{
    public int LoginId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
