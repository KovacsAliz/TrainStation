﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    public class Freight : Train
    {
        public Freight(string trainSign, double monthlyCostOfTrain) : base(trainSign, monthlyCostOfTrain) { }


        public override double CalculateMonthlyIncomeByTrain()
        {
            return 550.00D;
        }

        public double AddedRevenuePerMonth(int plusIncome)
        {
            double addedRevenue = 0.00D;
            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                int chance = rnd.Next(0, 100);
                if (chance <= 35) //chance of freight goes abroad
                {
                    addedRevenue += plusIncome;
                }
            }
            return addedRevenue;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
