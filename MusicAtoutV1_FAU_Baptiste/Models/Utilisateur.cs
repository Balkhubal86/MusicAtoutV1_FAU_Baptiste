using System;
using System.Collections.Generic;

namespace MusicAtoutV1_FAU_Baptiste.Models;

public partial class Utilisateur
{
    public string IdUtilisateur { get; set; } = null!;

    public string? Passwd { get; set; }

    public int? Droits { get; set; }

    public bool Actif { get; set; }

    public int? Nbessais { get; set; }
}
