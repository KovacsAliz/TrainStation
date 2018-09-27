using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    public abstract class Train
    {
        public string SerialNumber { get; set; }
        public string TrainSign { get; set; }
        public double MonthlyCostOfTrain { get; set; }
        public double MonthlyRevenueOfTrain { get; set; } // is it necessary?
        private static int _idCounter = 1;

        public Train(string trainSign, double monthlyCostOfTrain)
        {
            SerialNumber = _idCounter.ToString() + trainSign;
            MonthlyCostOfTrain = monthlyCostOfTrain;
            _idCounter++;
        }

        public abstract double CalculateMonthlyIncomeByTrain();

        public override string ToString()
        {
            return "Serial number: " + SerialNumber + ", " + 
                    "Monthly cost of this train: " + MonthlyCostOfTrain;
        }
    }
}
