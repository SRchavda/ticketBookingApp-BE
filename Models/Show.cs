using System;
using System.Collections.Generic;

namespace BookingApp.Models;

public partial class Show
{
    public int ShowId { get; set; }

    public DateTime ShowTime { get; set; }

    public int? HallId { get; set; }

    public int? MovieId { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual CinemaHall? Hall { get; set; }

    public virtual Movie? Movie { get; set; }
}
