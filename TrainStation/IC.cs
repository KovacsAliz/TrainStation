using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    public class IC : Train, IHavePassengersTrain
    {
        public double TicketPrice { get; set; }
        public double TicketPriceOnTrain { get; set; }

        public IC(string trainSign, double monthlyCostOfTrain, double ticketPrice, double ticketPriceOnTrain) : base(trainSign, monthlyCostOfTrain)
        {
            TicketPrice = ticketPrice;
            TicketPriceOnTrain = ticketPriceOnTrain;
        }

        public double CalculateDailyIncomeByTrain(double ticketPrice, double ticketPriceOnTrain)
        {
            Random rnd = new Random();
            int passengersNumber = rnd.Next(115, 250);
            return ((passengersNumber * 0.75) * TicketPrice + ((passengersNumber * 0.25) * TicketPriceOnTrain));
        }

        public double PunishedIncome()
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 100);
            if (chance <= 8)
            {
                int passengersNum = rnd.Next(115, 250);
                return passengersNum * 6;
            }
            else
                return 0;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + "Ticket price: " + TicketPrice + ", " + "Ticket price on the train: " + TicketPriceOnTrain;
        }
    }
}
