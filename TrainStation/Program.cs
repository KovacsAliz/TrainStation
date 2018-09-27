using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station();
            station.CreateStation();
            station.PrintResult();
            Console.ReadKey();
        }
    }
}
