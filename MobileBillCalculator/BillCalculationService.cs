using System;

namespace MobileBillCalculator
{
    public class BillCalculationService
    {
        public void CalculateBill(DateTime startTime, DateTime endTime)
        {
            decimal generatedBill = 0;
            var countableTime = startTime;

            while (countableTime <= endTime)
            {
                countableTime = countableTime.AddSeconds(Constants.Pulse);
                generatedBill += GetThePulseRate(countableTime);
            }
        }

        private int GetThePulseRate(DateTime theTime)
        {
            return theTime.IsPeekHour() ? 30 : 20;
        }

    }
}
