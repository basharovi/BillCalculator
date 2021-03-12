using System;

namespace MobileBillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var inputStartTime = Console.ReadLine();
                var inputEndTime = Console.ReadLine();

                var startTime = GetConvertedDateTime(inputStartTime, "Start");
                var endTime = GetConvertedDateTime(inputEndTime, "End");

                var billCalculationService = new BillCalculationService();
                var generatedBill = billCalculationService.CalculateBill(startTime, endTime);

                Console.WriteLine("{0} taka", generatedBill);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Someting went wrong!  {0}", ex.Message);
            }
        }

        private static DateTime GetConvertedDateTime(string inputTime, string prefix)
        {
            return Convert.ToDateTime(inputTime.Replace($"{prefix} time:", string.Empty));
        }
    }
}
