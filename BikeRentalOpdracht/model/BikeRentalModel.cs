using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BikeRentalOpdracht.Model
{

    public class BikeRentalModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public void Notify([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

