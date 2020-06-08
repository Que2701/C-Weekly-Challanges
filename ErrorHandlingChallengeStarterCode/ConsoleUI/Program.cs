using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            for (int i = 0; i <= 10; i++)
            {
                try
                {
                    var result = paymentProcessor.MakePayment($"Demo{ i }", i);

                    Console.WriteLine(result.TransactionAmount);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(DisplaySkippedMessage(i));
                }
                catch(FormatException formatException)
                {
                    var innerMessage = formatException.InnerException != null ? formatException.InnerException.Message : "";
                    Console.WriteLine(DisplaySkippedMessage(i, innerMessage));
                }
                catch(NullReferenceException)
                {
                    Console.WriteLine($"Null value for item {i}");
                }
                catch(ArithmeticException)
                {
                    Console.WriteLine(DisplaySkippedMessage(i));
                }
            }
            Console.ReadLine();
        }

        static string DisplaySkippedMessage(int i, string innerMessage = null)
        {
            return string.IsNullOrEmpty(innerMessage) && i != 8 ?  $"Payment skipped for payment with {i} items" : 
                $"Formatting issue {innerMessage}";
        }
    }
}
