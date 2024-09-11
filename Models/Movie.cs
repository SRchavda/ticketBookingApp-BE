using System;
using System.Collections.Generic;

namespace BookingApp.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    public string MovieTitle { get; set; } = null!;

    public int DurationMinutes { get; set; }

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();
}
