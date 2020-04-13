using BikeRentalOpdracht.View;
using BikeRentalOpdracht.ViewModel;
using System.Windows;







namespace BikeRentalOpdracht
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }
        private void StoresButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel vm = (MainWindowViewModel)DataContext; // retrieve the ViewModel that was set in the constructor

            StoresEditViewModel editVM = new StoresEditViewModel(vm.Stores); // make a new StoresEditViewModel and pass it the list of courses from this ViewModel

            StoresEdit view = new StoresEdit(); // make a new View
            view.DataContext = editVM; // pass the new View the ViewModel
            view.Show(); // show the View

        }

        private void BikesButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel vm = (MainWindowViewModel)DataContext; // retrieve the ViewModel that was set in the constructor

            if (vm.SelectedStore == null)
            {
                MessageBox.Show("Select a store first");
            }
            else
            {
                BikesEditViewModel editVM = new BikesEditViewModel(vm.SelectedStore.Bikes); // make a new StoresEditViewModel and pass it the list of stores from this ViewModel

               BikesEdit view = new BikesEdit(); // make a new View
                view.DataContext = editVM; // pass the new View the ViewModel
                view.Show(); // show the View
            }
        }
    }
}
