using System;
using System.Collections.Generic;

namespace BookingApp.Models;

public partial class CinemaHall
{
    public int HallId { get; set; }

    public string HallName { get; set; } = null!;

    public int? CinemaId { get; set; }

    public virtual Cinema? Cinema { get; set; }

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();
}
