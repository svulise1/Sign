using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign
{
    public class ColdCheck :ICheckSteps
    {

        // Class is implementing ICheckSteps Interface.
        // We need to defiine CheckSteps method
        public void CheckSteps(string [] userinput)
        {
            //We are using Dictionary to for evaluting the userinput.
            Dictionary<int, int> tracker = new Dictionary<int, int>();
            for (int i = 1; i < userinput.Length; i++)
            {
                // Created an iteger to take the user input always as a numer
                int inputvalue = 0;
                try
                { //// Sperating the userinput with ","
                    inputvalue = Convert.ToInt32(userinput[i].TrimEnd(new char[] { ',' }));
                }
                catch (Exception ex)
                {
                    //// If userinput has alphabets or anything other than numbers,my catch block will be excecuted.
                    Console.Write("Input form of string is wrong");
                    break;
                }
                if (tracker.ContainsKey(inputvalue))
                {
                    //If Dictionary aldreay has item. We will increment the count of the item.
                    tracker[inputvalue]++;
                }
                else
                {
                    //If item is not there in Dictionary, item will be added to dictioanry with Count 1
                    tracker.Add(inputvalue, 1);
                }
                if (tracker[inputvalue] != 1)
                {
                    //check for duplicates
                    Console.Write("Fail");
                    break;
                }
                else if (i == userinput.Length && tracker.Count < 9)
                {   //Check all userinputs covered the criteria
                    Console.Write("Fail");
                    break;
                }
                if (inputvalue != 8 && i == 1)
                {   //Always the first input should be 8 Pajms should be removed
                    Console.Write("Fail");
                    break;
                }
                else if (inputvalue != 1 && i == 7)
                {
                    //Before leaving the house he/she should wear footwear
                    Console.Write("Fail");
                    break;
                }
                else if (inputvalue != 7 && i == 8)
                {
                    //the last step should be   leaving the house
                    Console.Write("Fail");
                    break;
                }
                else if (inputvalue < 0 || inputvalue > 9)
                {//Range check
                    Console.Write("Fail");
                    break;
                }
                else if (inputvalue == 3 && tracker.ContainsKey(1))
                {
                    //Socks must be put on before shoes
                    Console.Write("Fail");
                    break;
                }
                else if (inputvalue == 6 && tracker.ContainsKey(1))
                {
                    //Pants must be put on before shoes
                    Console.Write("Fail");
                    break;
                }
                else if (inputvalue == 4 && (tracker.ContainsKey(2) || tracker.ContainsKey(5)))
                {
                    //shirt must be put on before the headwear or jacket
                    Console.Write("Fail");
                    break;
                }
                else
                {
                    // Printer Function is a Static Class. No need to Create Object
                    PrintAnswers.Printer(inputvalue, userinput[0]);
                }
            }
        }
        
    }
}
