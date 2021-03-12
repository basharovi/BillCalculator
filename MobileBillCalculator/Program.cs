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

                var startTime = GetConvertedDateTime(inputStartTime);
                var endTime = GetConvertedDateTime(inputEndTime);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Someting went wrong!  {0}", ex.Message);
            }
        }

        private static DateTime GetConvertedDateTime(string inputTime)
        {
            return Convert.ToDateTime(inputTime.Split(":")[1]);
        }
    }
}
