using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    interface IHavePassengersTrain
    {
        double CalculateDailyIncomeByTrain(double ticketPrice, double ticketPriceOnTrain);
    }
}
