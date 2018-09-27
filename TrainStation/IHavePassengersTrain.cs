using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    interface IHavePassengersTrain
    {
        double CalculateIncomeMonthly(double ticketPrice, double ticketPriceOnTrain);
        double PunishedIncome(int passengersNumber, double chance);
    }
}
