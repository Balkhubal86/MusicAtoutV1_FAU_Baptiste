using System;
using System.Collections.Generic;

namespace MusicAtoutV1_FAU_Baptiste.Models;

public partial class Salle
{
    public int IdBati { get; set; }

    public int NumSalle { get; set; }

    public string? NomSalle { get; set; }

    public int? Capacite { get; set; }

    public int? Superficie { get; set; }

    public virtual Batiment IdBatiNavigation { get; set; } = null!;

    public virtual ICollection<Typeoeuvre> IdTypes { get; set; } = new List<Typeoeuvre>();
}
