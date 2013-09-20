using System;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace CarRental.Business.Entities
{
    [DataContract]
    public class Rental :EntityBase, IIdentifiableEntity, IAccountOwnedEntity
    {
        private int rentalId;
        private int accountId;
        private int carId;
        private DateTime dateRented;
        private DateTime dateDue;
        private DateTime? dateReturned;

        [DataMember]
        public int RentalId
        {
            get { return rentalId; }
            set { rentalId = value; }
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
        public DateTime DateRented
        {
            get { return dateRented; }
            set { dateRented = value; }
        }

        [DataMember]
        public DateTime DateDue
        {
            get { return dateDue; }
            set { dateDue = value; }
        }

        [DataMember]
        public DateTime? DateReturned
        {
            get { return dateReturned; }
            set { dateReturned = value; }
        }

        public int EntityId
        {
            get
            {
                return RentalId;
            }
            set { RentalId = value; }
        }

        int IAccountOwnedEntity.OwnerAccountId
        {
            get
            {
                return AccountId;
            }
        }
    }
}
