using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BikeRentalOpdracht.Model
{
    public class Reservations : BikeRentalModel
    {
        public Bikes Bike { get; set; }
        public Customer Customer { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public Store PickupStore { get; set; }
        public Store Dropoffstore { get; set; }

    }
}
