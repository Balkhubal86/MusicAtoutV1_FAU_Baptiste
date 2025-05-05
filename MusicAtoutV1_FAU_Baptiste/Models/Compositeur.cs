using System;
using System.Collections.Generic;

namespace MusicAtoutV1_FAU_Baptiste.Models;

public partial class Compositeur
{
    public int IdCompositeur { get; set; }

    public int IdNation { get; set; }

    public int IdStyle { get; set; }

    public string? NomCompositeur { get; set; }

    public string? PrenomCompositeur { get; set; }

    public int? AnNais { get; set; }

    public int? AnMort { get; set; }

    public string? Remarque { get; set; }

    public virtual Nationalite IdNationNavigation { get; set; } = null!;

    public virtual Style IdStyleNavigation { get; set; } = null!;

    public virtual ICollection<Oeuvre> Oeuvres { get; set; } = new List<Oeuvre>();
}
