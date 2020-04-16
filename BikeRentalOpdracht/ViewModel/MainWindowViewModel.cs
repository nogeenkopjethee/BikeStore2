using BikeRentalOpdracht.Model;
using System.Collections.ObjectModel;

namespace BikeRentalOpdracht.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }
        public Store SelectedStore { get; set; }
        public MainWindowViewModel()
        {
            Stores = new ObservableCollection<Store>
            {
                new Store
                {
                    Name = "Mac Bike",
                    Address = "De Ruijterkade 34",
                    City = "Amsterdam",
                     MaxCapacity = 30,
                   
                    Bikes = new ObservableCollection<Bikes>
                    {
                        new Bikes
                        {
                            Brand = "Batavus",
                              Gender = BikeGender.Herenfiets,
                            Size  = 89,
                            HourRate = 5,
                            DailyRate = 25
                        },
                        new Bikes
                        {
                            Brand = "B'twin",
                            Gender = BikeGender.Herenfiets,
                            Size  = 89,
                             HourRate = 10,
                            DailyRate = 35
                        },
                        new Bikes
                        {
                            Brand = "Gazzelle",
                            Gender = BikeGender.Damesfiets,
                            Size  = 50,
                             HourRate = 8,
                            DailyRate = 88

                        }
                    }
                },
                new Store
                {
                    Name = "FietsenAlmere",
                    Address = "Wim Kanplein 17",
                    City = "Almere",
                    MaxCapacity = 30,


                    Bikes = new ObservableCollection<Bikes>
                    {
                        new Bikes
                        {
                            Brand = "Gazzelle",
                            Gender = BikeGender.Damesfiets,
                            Size  = 50,
                            HourRate = 8,
                            DailyRate = 90
                        },
                        new Bikes
                        {
                            Brand = "Gazzelle",
                            Gender = BikeGender.Damesfiets,
                            Size  = 20,
                             HourRate = 4,
                            DailyRate = 44
                        },
                        new Bikes
                        {
                            Brand = "Batavus",
                              Gender = BikeGender.Herenfiets,
                              Size  = 50,
                             HourRate = 9,
                            DailyRate = 99
                        },
                        new Bikes
                        {
                            Brand = "Batavus",
                            Gender = BikeGender.Damesfiets,
                            Size  = 50,
                             HourRate = 8,
                            DailyRate = 88
                        }
                    }
                }
            };
        }
    }
}
