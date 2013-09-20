using System;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace CarRental.Business.Entities
{
    [DataContract]
    public class Reservation : EntityBase, IIdentifiableEntity, IAccountOwnedEntity
    {
        private int reservationId;
        private int accountId;
        private int carId;
        private DateTime rentalDate;
        private DateTime returnDate;

        [DataMember]
        public int ReservationId
        {
            get { return reservationId; }
            set { reservationId = value; }
        }

        [DataMember]
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        [DataMember]
        public int CarId
        {
            get { return carId; }
            set { carId = value; }
        }

        [DataMember]
        public DateTime RentalDate
        {
            get { return rentalDate; }
            set { rentalDate = value; }
        }

        [DataMember]
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public int EntityId
        {
            get { return ReservationId; }
            set
            {
                ReservationId = value;
            }
        }

        public int OwnerAccountId {
            get { return AccountId; }
        }
    }
}