using System;
using System.Collections.Generic;

namespace BookingApp.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? BookingId { get; set; }

    public decimal PaymentAmount { get; set; }

    public DateTime PaymentDate { get; set; }

    public virtual Booking? Booking { get; set; }
}
