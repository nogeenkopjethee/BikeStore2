using BikeRentalOpdracht.Model;
using System.Collections.ObjectModel;
using System.Windows;
using BikeRentalOpdracht.View;

namespace BikeRentalOpdracht.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }
        public Store SelectedStore { get; set; }


        /**
         * The following two RelayCommands are needed to set up the bindings from the window.
         */
        public RelayCommand OpenStoreEditClick { get; set; }
        public RelayCommand OpenBikesEditClick { get; set; }
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

            OpenStoreEditClick = new RelayCommand(StoresButtonClick);

            OpenBikesEditClick = new RelayCommand(BikesButtonClick);
        }

        private void StoresButtonClick(object obj)
        {
            StoresEditViewModel editVM = new StoresEditViewModel(Stores); // make a new StoresEditViewModel and pass it the list of courses from this ViewModel

            StoresEdit view = new StoresEdit(); // make a new View
            view.DataContext = editVM; // pass the new View the ViewModel
            view.Show(); // show the View

        }

        private void BikesButtonClick(object obj)
        {
            if (SelectedStore == null)
            {
                MessageBox.Show("Select a store first");
            }
            else
            {
                BikesEditViewModel editVM = new BikesEditViewModel(SelectedStore.Bikes); // make a new StoresEditViewModel and pass it the list of stores from this ViewModel

                BikesEdit view = new BikesEdit(); // make a new View
                view.DataContext = editVM; // pass the new View the ViewModel
                view.Show(); // show the View
            }
        }
    }
}
