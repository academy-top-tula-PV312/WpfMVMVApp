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

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new RelayCommand(
                    _ =>
                    {
                        Flight flight = new Flight();
                        Flights.Add(flight);
                        SelectedFlight = flight;
                    }));
            }
        }

        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ?? (
                    deleteCommand = new RelayCommand(
                        obj =>
                        {
                            Flight flight = obj as Flight;
                            if (flight != null)
                                Flights.Remove(flight);
                        },
                        _ => Flights.Count > 0
                        ));
            }
        }

        public ApplicationViewModel()
        {
            Flights = new ObservableCollection<Flight>()
            {
                new Flight(){ Name = "AWE-124", 
                              ToCity = "Moscow", 
                              Date = DateTime.Now.AddDays(57), 
                              Hours = 10,
                              Minutes = 30,
                              Image="air01.jpg"},
                new Flight(){ Name = "TUR-002",
                              ToCity = "Kazan",
                              Date = DateTime.Now.AddDays(43),
                              Hours = 20,
                              Minutes = 15,
                              Image="air02.jpg"},
                new Flight(){ Name = "LKG-25",
                              ToCity = "St.Peterburg",
                              Date = DateTime.Now.AddDays(51),
                              Hours = 12,
                              Minutes = 00,
                              Image="air03.jpg"}
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
