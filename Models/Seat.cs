using System;
using System.Collections.Generic;

namespace BookingApp.Models;

public partial class Seat
{
    public int SeatId { get; set; }

    public string SeatNumber { get; set; } = null!;

    public int? HallId { get; set; }

    public virtual CinemaHall? Hall { get; set; }
}
