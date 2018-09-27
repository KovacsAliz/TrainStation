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
        public double MonthlyIncomeOfTrain { get; set; }
        public double MonthlyRevenueOfTrain { get; set; }
        private static int _idCounter = 1;

        public Train(string trainSign, double monthlyCostOfTrain)
        {
            SerialNumber = _idCounter.ToString() + trainSign;
            MonthlyCostOfTrain = monthlyCostOfTrain;
            _idCounter++;
        }

        public double CalculateMonthlyRevenue(double monthlyCostOftrain, double monthlyIncomeOfTrain)
        {
            return monthlyIncomeOfTrain - monthlyCostOftrain;
        }
    }
}
