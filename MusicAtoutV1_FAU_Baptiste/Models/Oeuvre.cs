using System;
using System.Collections.Generic;

namespace MusicAtoutV1_FAU_Baptiste.Models;

public partial class Oeuvre
{
    public int IdOeuvre { get; set; }

    public int IdType { get; set; }

    public int IdCompositeur { get; set; }

    public string? TitreOeuvre { get; set; }

    public int? AnComposition { get; set; }

    public string? Texte { get; set; }

    public virtual Compositeur IdCompositeurNavigation { get; set; } = null!;

    public virtual Typeoeuvre IdTypeNavigation { get; set; } = null!;
}
