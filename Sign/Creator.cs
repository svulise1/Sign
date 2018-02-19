using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign
{
    public class Creator
    {   
        //Creting two Dictionary one for Hot and one for Cold.
        public Dictionary<int, string> hotsteps = new Dictionary<int, string>();
        public Dictionary<int, string> coldsteps = new Dictionary<int, string>();
        List<string> steps = new List<string>();
        int count = 1;

        public Dictionary<int,string> HotInitiator()
        {
            // Adding items in Hot Dictionary
            steps.AddRange(new string[] { "sandals", "sun visor", "fail", "t-shirt", "fail", "shorts", "leaving house", "remove pjs" });
            foreach (var hotitem in steps)
            {
                hotsteps.Add(count, hotitem);
                count++;
            }
            // reutrn type is Dictionary<int, string>
            return hotsteps;
        }

        public Dictionary<int, string> ColdInitiator()
        {
            // Adding items in Cold Dictionary
            steps.AddRange(new string[] { "boots", "hat", "socks", "shirt", "jacket", "pants", "leaving house", "remove pjs" });
            foreach (var colditem in steps)
            {
                coldsteps.Add(count, colditem);
                count++;
            }
            // reutrn type is Dictionary<int, string>
            return coldsteps;
        }
        
    }

}
