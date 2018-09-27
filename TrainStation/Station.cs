using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    public class Station
    {
        public List<Passenger> passengers = new List<Passenger>(5);
        public List<IC> iCTrains = new List<IC>(5);
        public List<Freight> freights = new List<Freight>(5);

        public float TotalRevenue { get; set; }

        public void CreateStation()
        {
            //TODO
        }

        public float CalulateTotalRevenue(float monthlyRevenue)
        {
            TotalRevenue = 12 * monthlyRevenue;
            return TotalRevenue;
        }
    }
}
