using System;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalAfterDiscount = TotalAmountAfterTheDiscountCalculateAsync(1500);
            DisplayingTheMassage();

            totalAfterDiscount.Wait();
            Console.ReadLine();
        }

        private static void DisplayingTheMassage()
        {
            Console.WriteLine("The calculation has started");
        }

        static async Task<double> TotalAmountAfterTheDiscountCalculateAsync(int enteredSum)
        {
            Console.WriteLine("Started CPU Bound asynchronous task on a background thread");
            var result = await Task.Run(() => enteredSum - enteredSum*0.3);
            Console.WriteLine($"Total of ${enteredSum} after discount of 30% is ${result} ");
            return result;
        }
    }
}
