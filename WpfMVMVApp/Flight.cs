using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVMVApp
{
    public class Flight
    {
        private static int globalId = 0;
        private int hours;
        private int minutes;
        private TimeSpan time;
        public Flight()
        {
            Id = ++globalId;
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ToCity { get; set; } = null!;
        public DateTime? Date { get; set; }
        public int Hours 
        {
            get => hours;
            set
            {
                hours = value;
                time = new TimeSpan(hours, minutes, 0);
            }
        }
        public int Minutes
        {
            get => minutes;
            set
            {
                minutes = value;
                time = new TimeSpan(hours, minutes, 0);
            }
        }
        public TimeSpan? Time
        {
            get => time;
        }
        public string? Image { get; set; } 
    }
}
