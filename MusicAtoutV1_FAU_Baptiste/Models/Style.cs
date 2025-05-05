using System;
using System.Collections.Generic;

namespace MusicAtoutV1_FAU_Baptiste.Models;

public partial class Style
{
    public int IdStyle { get; set; }

    public string? LibStyle { get; set; }

    public int? DateDebut { get; set; }

    public int? DateFin { get; set; }

    public virtual ICollection<Compositeur> Compositeurs { get; set; } = new List<Compositeur>();
}
