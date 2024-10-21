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

        public TimeSpan? Time
        {
            get => flight.Time;
            set
            {
                if (flight.Time != value)
                {
                    flight.Time = value;
                    OnPropertyChanged();
                }
            }
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
