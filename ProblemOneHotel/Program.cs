namespace ProblemOneHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var night = int.Parse(Console.ReadLine());
            var studioPrice = 0.00;
            var doublePrice = 0.00;
            var suitePrice = 0.00;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    if (night > 7)
                    {
                        studioPrice *= 0.95;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    if(night > 14)
                    {
                        doublePrice *= 0.9;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if(night < 14)
                    {
                        suitePrice *= 0.85;
                    }
                    break;
            }
            var totalStudioPrice = studioPrice * night;
            var totalDoublePrice = doublePrice * night;
            var totalSuitePrice =  suitePrice * night;
            if ((month == "September" || month == "October") && night >7) 
            {
                totalStudioPrice -= suitePrice;
            }
            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Studio: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Studio: {totalSuitePrice:F2} lv.");
        }
    
                
    }
}