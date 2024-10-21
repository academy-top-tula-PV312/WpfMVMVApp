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
        public Flight()
        {
            Id = ++globalId;
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ToCity { get; set; } = null!;
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string? Image { get; set; } 
    }
}
