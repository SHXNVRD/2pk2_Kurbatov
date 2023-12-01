using System;
using System.Collections.Generic;

namespace UP_2;

public partial class Job
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Employe> Employes { get; set; } = new List<Employe>();
}
