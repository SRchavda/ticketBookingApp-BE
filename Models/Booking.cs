using System;
using System.Collections.Generic;

namespace BookingApp.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? ShowId { get; set; }

    public int? UserId { get; set; }

    public DateTime BookingTime { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Show? Show { get; set; }

    public virtual User? User { get; set; }
}
