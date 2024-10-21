using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVMVApp
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Flight selectedFlight;

        public ObservableCollection<Flight> Flights { get; set; }

        public Flight SelectedFlight
        {
            get => selectedFlight;
            set
            {
                if (selectedFlight != value)
                {
                    selectedFlight = value;
                    OnPropertyChanged();
                }
            }
        }

        public ApplicationViewModel()
        {
            Flights = new ObservableCollection<Flight>()
            {
                new Flight(){ Name = "AWE-124", 
                              ToCity = "Moscow", 
                              Date = DateTime.Now.AddDays(57), 
                              Time = TimeSpan.FromHours(11.5),
                              Image=""}
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
