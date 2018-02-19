using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign
{
    public  class PrintAnswers
    {
        public static void Printer(int value, string weathertype)
        {
            Creator createdict = new Creator();
            // If weather is HOT, print the items in HOT-Dictionary
            if (weathertype=="HOT" && value!=7)
            {
                var hotdict = createdict.HotInitiator();
                Console.Write("{0} {1}",hotdict[value],",");
            }
            else if(weathertype =="COLD" && value!=7)
            {
                // If weather is COLD, print the items in COLD-Dictionary
                var colddict = createdict.ColdInitiator();
                Console.Write("{0} {1}",colddict[value],",");
            }
            else if (value==7)
            {
                //ALwyas the last item will be 7. So "," will not be printed at last.
                Console.Write("leaving house");
            }

        }
    }
}
