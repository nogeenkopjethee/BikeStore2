using BikeRentalOpdracht.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace BikeRentalOpdracht.ViewModel
{
    public class BikesEditViewModel
    {
        public ObservableCollection<Bikes> Bikes { get; set; }
        public Bikes SelectedBike { get; set; }
        public RelayCommand ChangeNameClick { get; set; }
        public RelayCommand DeleteClick { get; set; }
        public Store SelectedStore { get; set; }
        public BikesEditViewModel(ObservableCollection<Bikes> bikes)
        {
            Bikes = bikes; // set the property Bikes (that is bound to the view) to be the collection we get passed from the other View
            ChangeNameClick = new RelayCommand(ChangeName);
            DeleteClick = new RelayCommand(DeleteBike);
        }

        public void ChangeName(object a)
        {
                MessageBox.Show("Please select a student first"); 
        }

        public void DeleteBike(object a)
        {
            if (SelectedBike != null)
            {
                Bikes.Remove(SelectedBike);
            }
            else
            {
                MessageBox.Show("Please select a bike first");
            }
        }
    }
}
