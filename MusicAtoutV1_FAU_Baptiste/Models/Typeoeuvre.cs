using System;
using System.Collections.Generic;

namespace MusicAtoutV1_FAU_Baptiste.Models;

public partial class Typeoeuvre
{
    public int IdType { get; set; }

    public string? LibelleType { get; set; }

    public virtual ICollection<Oeuvre> Oeuvres { get; set; } = new List<Oeuvre>();

    public virtual ICollection<Salle> Salles { get; set; } = new List<Salle>();
}
