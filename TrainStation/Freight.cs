using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    public class Freight : Train
    {
        public Freight(string trainSign, double monthlyCostOfTrain) : base(trainSign, monthlyCostOfTrain)
        {
            MonthlyRevenueOfTrain = 500.00D;
        }

        public double AddedRevenue(int plusIncome)
        {
            double addedRevenue = 0.00D;
            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                int chance = rnd.Next(0, 100);
                if (chance <= 35) //chance of freaight goes abroad
                {
                    addedRevenue += 110.00D;
                }
            }
            return addedRevenue;
        }
    }
}
