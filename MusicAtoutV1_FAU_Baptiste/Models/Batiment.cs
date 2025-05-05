using System;
using System.Collections.Generic;

namespace MusicAtoutV1_FAU_Baptiste.Models;

public partial class Batiment
{
    public int IdBati { get; set; }

    public string? NomBati { get; set; }

    public int? AnConstruction { get; set; }

    public string? RueBati { get; set; }

    public int? CpBati { get; set; }

    public string? TelBati { get; set; }

    public string? Responsable { get; set; }

    public int IdVille { get; set; }

    public virtual Ville IdVilleNavigation { get; set; } = null!;

    public virtual ICollection<Salle> Salles { get; set; } = new List<Salle>();
}
