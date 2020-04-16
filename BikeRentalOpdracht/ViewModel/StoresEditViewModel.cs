using BikeRentalOpdracht.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace BikeRentalOpdracht.ViewModel
{
    public class StoresEditViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }
        public Store SelectedStore { get; set; }
        public RelayCommand ChangeNameClick { get; set; }
        public RelayCommand ChangeStoreClick { get; set; }
        public RelayCommand DeleteClick { get; set; }


        public StoresEditViewModel(ObservableCollection<Store> stores)
        {
            Stores = stores; // set the property Stores (that is bound to the view) to be the collection we get passed from the other View
            ChangeNameClick = new RelayCommand(ChangeName);
            DeleteClick = new RelayCommand(DeleteStore);
            ChangeStoreClick = new RelayCommand(ChangeStore);
        }


        public void ChangeStore(object a)
        {
            if (SelectedStore != null)
            {
               
            }
            else
            {
                MessageBox.Show("Please select a Store first");
            }
        }


        public void ChangeName(object a)
        {
            
                MessageBox.Show("Please select a store first");
            
        }

        public void DeleteStore(object a)
        {
            if (SelectedStore != null)
            {
                Stores.Remove(SelectedStore);
            }
            else
            {
                MessageBox.Show("Please select a store first");
            }
        }
    }
}
