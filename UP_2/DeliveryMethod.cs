using System;
using System.Collections.Generic;

namespace UP_2;

public partial class DeliveryMethod
{
    public int Id { get; set; }

    public string Method { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
