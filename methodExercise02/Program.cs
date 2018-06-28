using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise02
{
    class Program
    {
        public static int HoursWorked { get; set; }
        public static int HourlyRate { get; set; }
        

        static void Main(string[] args)
        {

            PayDay payDay = new PayDay();
            Console.WriteLine("How many hours did you work this week?\n Press Enter:");
            HoursWorked = Convert.ToInt32(Console.ReadLine());
            decimal hoursWorked = Convert.ToDecimal(HoursWorked);
            Console.WriteLine("What is your hourly rate?\n Press Enter:");
            HourlyRate = Convert.ToInt32(Console.ReadLine());
            decimal hourlyRate = Convert.ToDecimal(HourlyRate);
            // Calling the first method, ActualPaycheck
            decimal weeklyPay = payDay.ActualPaycheck(HourlyRate, HoursWorked);
            string i = weeklyPay.ToString("C0");
            Console.WriteLine("Your pay this week is: " + i + "\n Don't spend it all in one place.");
            Console.ReadLine();
           


            // Calling the second method, ActualPaycheck. Use a decimal amount here.
            Console.WriteLine("Enter the amount you made in week one. \n Press Enter:");
            decimal weekOne = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the amount you made in week two. \n Press Enter:");
            decimal weekTwo = Convert.ToDecimal(Console.ReadLine());
            decimal biWeekly = payDay.ActualPaycheck(weekOne, weekTwo);
            string total = biWeekly.ToString("C");
            Console.WriteLine("Your bi-weekly total is: " + total );
            Console.ReadLine();



            // Calling the third method, ActualPaycheck. Should automatically return weekOne minus weekTwo.
            Console.WriteLine("This will check what the difference is between Week One and Week Two paychecks.\n These are all pre-set amounts");
            string firstWeek = "560";
            Console.WriteLine("So, your first week paycheck was: " + firstWeek + "\n Not bad.");
            string secondWeek = "480";
            Console.WriteLine("And, your second week paycheck was: " + secondWeek + "\n It's getting there.");
            int result;
            payDay.ActualPaycheck(firstWeek, secondWeek, out result); //now you passed string values but got int result.
            //string difference = payDay.ActualPaycheck(firstWeek, secondWeek);
            Console.WriteLine("The difference is: " + result);

            Console.ReadLine();












        }

        
    }
}
