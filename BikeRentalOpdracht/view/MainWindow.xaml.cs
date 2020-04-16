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
        
    }
}
