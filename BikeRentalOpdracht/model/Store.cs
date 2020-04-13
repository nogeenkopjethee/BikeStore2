using System;
using System.Collections.ObjectModel;

namespace BikeRentalOpdracht.Model
{
    public class Store: BikeRentalModel
    {
        #region Attributes
        
        private string _name;
        private int _maxCapacity;
        #endregion
        public string Name { get => _name; set { _name = value; Notify("Name"); } } 
        public string Address { get; set; }
        public string City { get; set; }
        public int MaxCapacity { get => _maxCapacity; set { _maxCapacity = value; Notify("SpaceLeft");  } }
        public int SpaceLeft { get => MaxCapacity - Bikes.Count; }
        public ObservableCollection<Bikes> Bikes { get; set; }

        public Store()
        {
            Bikes = new ObservableCollection<Bikes>(); 
        }

       
    }
}
