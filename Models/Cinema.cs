using System;
using System.Collections.Generic;

namespace BookingApp.Models;

public partial class Cinema
{
    public int CinemaId { get; set; }

    public string CinemaName { get; set; } = null!;

    public int? CityId { get; set; }

    public virtual ICollection<CinemaHall> CinemaHalls { get; set; } = new List<CinemaHall>();

    public virtual City? City { get; set; }
}
