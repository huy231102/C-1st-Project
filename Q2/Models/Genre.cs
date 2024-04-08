﻿using System;
using System.Collections.Generic;

namespace Q2.Models;

public partial class Genre
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
