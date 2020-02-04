using System;
using System.Collections.Generic;
using System.Text;
using Task.Core.Domain.Base;

namespace Task.Core.Domain
{
    public class GuestReservation : Entity
    {
        public long GuestId { get; protected set; }
        public long ReservationId { get; protected set; }

        public virtual Guest Guest { get; protected set; }
        public virtual Reservation Reservation { get; protected set; }

        protected GuestReservation()
        {

        }

        public GuestReservation(long id, long guestId, long reservationId)
        {
            Id = id;
            GuestId = guestId;
            ReservationId = reservationId;
        }

        public GuestReservation(long guestId, long reservationId)
        {
            GuestId = guestId;
            ReservationId = reservationId;
        }
    }
}
