using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    public class IC : Train, IHavePassengersTrain
    {
        public double TicketPrice { get { return TicketPrice; } set { TicketPrice = 1.5F; } }
        public double TicketPriceOnTrain { get { return TicketPriceOnTrain; } set { TicketPriceOnTrain = 3.5F; } }

        public IC(string trainSign, double monthlyCostOfTrain) : base(trainSign, monthlyCostOfTrain) { }

        public double CalculateIncomeMonthly(double ticketPrice, double ticketPriceOnTrain)
        {
            Random rnd = new Random();
            int passengersNumber = rnd.Next(115, 250);
            return ((passengersNumber * 0.75) * TicketPrice + ((passengersNumber * 0.25) * TicketPriceOnTrain));
        }

        public double PunishedIncome(int passengersNumber, double chance)
        {
            return passengersNumber * chance;
        }
    }
}
