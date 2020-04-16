using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BikeRentalOpdracht.Model
{
    public class Bikes : INotifyPropertyChanged
    {
        private string _brand;
        private int _size;
        private BikeGender _gender;
        private BikeType _type;
        private bool _rented;
        private double _hourRate;
        private double _dailyRate;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public string Brand { get => _brand; set { _brand = value; Notify("Brand"); } }
        public double HourRate { get => _hourRate; set { _hourRate = value; Notify("Hour Rate"); } }
        public double DailyRate { get => _dailyRate; set { _dailyRate = value; Notify("Daily Rate"); } }
        public BikeGender Gender { get => _gender; set { _gender = value; Notify("Gender"); } }
        public int Size { get => _size; set { _size = value; Notify("Size"); } }
        public BikeType Type { get => _type; set { _type = value; Notify("Type"); } }
        public bool Rented { get => _rented; set { _rented = value; Notify("Rented"); } }
       
      

        public void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum BikeType
    {
        CityBike,
        MountainBike,
        Hybrid
    }
    public enum BikeGender
    {
        Herenfiets,
        Damesfiets
      
    }
  
}
