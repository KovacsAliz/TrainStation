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
            for (int i = 0; i < 3; i++)
            {
                passengers.Add(new Passenger("P", 1000.00D));
                iCTrains.Add(new IC("IC", 1500.00D));
                freights.Add(new Freight("F", 1000.00D));
            }
        }

        public double CalculateTotalRevenue()
        {
            double totalRevenue = 0;
            foreach (var passenger in passengers)
            {
                totalRevenue += passenger.CalculateMonthlyIncomeByTrain(passenger.CalculateDailyIncomeByTrain(1.50D, 3.50D));
                totalRevenue += passenger.PunishedIncome();
            }

            foreach (var ic in iCTrains)
            {
                totalRevenue += ic.CalculateMonthlyIncomeByTrain(ic.CalculateDailyIncomeByTrain(2.00D, 4.00D));
                totalRevenue += ic.PunishedIncome();
            }

            foreach (var freight in freights)
            {
                totalRevenue += freight.MonthlyRevenueOfTrain;
            }
            return 12 * totalRevenue;
        }

        public void PrintResult()
        {
            Console.WriteLine("Total revenue for a year: " + CalculateTotalRevenue());

            foreach(var passenger in passengers)
            {
                Console.WriteLine(passenger.ToString());
                Console.WriteLine();
            }
            foreach (var ic in iCTrains)
            {
                Console.WriteLine(ic.ToString());
                Console.WriteLine();
            }
            foreach (var freight in freights)
            {
                Console.WriteLine(freight.ToString());
                Console.WriteLine();
            }
        }
    }
}
