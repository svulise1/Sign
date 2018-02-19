using System;
using System.Threading;

namespace Sign
{
   public class Program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Response:");
            string response;
            response = Console.ReadLine();
            Splitter inputSplitter = new Splitter();
            inputSplitter.inputsplit(response);
            int userresponse;
            bool repeat = true;
            try
            {
                while (repeat)
                {
                    // Using Switch Cases, So that User can enter more than one response.
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Please press 1 to enter another response or press 2 to exit");
                    userresponse = Convert.ToInt32(Console.ReadLine());
                    switch (userresponse)
                    {
                        // User can enter another response.
                        case 1:
                            Console.WriteLine("Please Enter your Response:");
                            response = Console.ReadLine();
                            inputSplitter.inputsplit(response);
                            break;

                            //Console application will close in 10 seonds.

                        case 2:
                           
                            Console.WriteLine("Thanks a lot for trying my Application." +
                                "If there is anything I need to improve. Please let me know." +
                                " My emailId is Vulisetty@gmail.com.");
                            Console.WriteLine("Console will close in Ten Seconds");
                            Thread.Sleep(10000);
                            Environment.Exit(0);
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Your response is wrong");
                
            }
            //Program obj = new Program();
            //obj.Checkhot(response);
            Console.ReadLine();
        }
    }
}