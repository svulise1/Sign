using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign
{
    public class Splitter
    {
        public void inputsplit(string response)
        {
            //Spliting the userresponse by a white space and storing all the items in array.
            var userinput = response.Split(new char[] { ' ' });
            if (userinput.Length == 1)
            {
                Console.Write("Input form of string is wrong");
            }
            else if (userinput[0] == "HOT")
            {
                // If the first word of Userresponse is Hot,HotStpes will be evaluated
                HotCheck hotchecker = new HotCheck();
                hotchecker.CheckSteps(userinput);
            }
            else if (userinput[0] == "COLD")
            {
                // If the first word of Userresponse is Cold,ColdStpes will be evaluated
                ColdCheck coldchecker = new ColdCheck();
                coldchecker.CheckSteps(userinput);
            }
            else
            {
                //User has entered wrong response. He/She did not enter either HOT or COLD.
                Console.WriteLine("Input form of string wrong. Make Sure you enter HOT or COLD in UPPERCASE");
            }
        }
    }
}