using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVMVApp
{
    public class FlightViewModel : INotifyPropertyChanged
    {
        private Flight flight;
        private TimeSpan time;

        public FlightViewModel(Flight flight)
        {
            this.flight = flight;
        }

        public string Name
        {
            get => flight.Name;
            set
            {
                if(flight.Name != value)
                {
                    flight.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ToCity
        {
            get => flight.ToCity;
            set
            {
                if (flight.ToCity != value)
                {
                    flight.ToCity = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime? Date
        {
            get => flight.Date;
            set
            {
                if (flight.Date != value)
                {
                    flight.Date = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Hours
        {
            get => flight.Hours;
            set
            {
                flight.Hours = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Flight.Time));
            }
        }

        public int Minutes
        {
            get => flight.Minutes;
            set
            {
                flight.Minutes = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Flight.Time));
            }
        }

        public TimeSpan? Time
        {
            get => flight.Time;
        }

        public string? Image
        {
            get => flight.Image;
            set
            {
                if (flight.Image != value)
                {
                    flight.Image = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
