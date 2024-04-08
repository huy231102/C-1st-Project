using System;
using System.Collections.Generic;

namespace Q2.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? Year { get; set; }

    public string? Description { get; set; }

    public int DirectorId { get; set; }

    public virtual Director Director { get; set; } = null!;

    public virtual ICollection<MovieStar> MovieStars { get; set; } = new List<MovieStar>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual ICollection<Genre> Genres { get; set; } = new List<Genre>();
}
