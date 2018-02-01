using System;
using System.Collections.Generic;

namespace Sign
{
   public class Program
    {
         public Dictionary<int, string> hotsteps = new Dictionary<int, string>();
         public Dictionary<int, string> coldsteps = new Dictionary<int, string>();

        public void Initiate()
        {
            List<string> hot = new List<string>();
            hot.AddRange(new string[] { "sandals", "sun visor", "fail", "t-shirt", "fail", "shorts", "leaving house", "remove pjs" });
            List<string> cold = new List<string>();
            cold.AddRange(new string[] { "boots", "hat", "socks", "shirt", "jacket", "pants", "leaving house", "remove pjs" });

            var hotcount = 1;
            var coldcount = 1;

            foreach (var hotitem in hot)
            {
                hotsteps.Add(hotcount, hotitem);
                hotcount++;
            }
            foreach (var colditem in cold)
            {
                coldsteps.Add(coldcount, colditem);
                coldcount++;
            }

        }

        public void PrinthotResponse(int value,string weathertype)
        {
            if (weathertype=="HOT")
            {
                Console.WriteLine(hotsteps[value]);
                Console.WriteLine(',');
            }
            else if (weathertype=="COLD")
            {
                Console.WriteLine(coldsteps[value]);
                Console.WriteLine(',');
            }

        }
        public void Checkhot(string input)
        {
            Initiate();

            var item = input.Split(new char[] { ' ' });
            if (item.Length == 1)
            {
                Console.Write("Input form of string is wrong");

            }
            else if (item[0] == "HOT")
            {
                Dictionary<int, int> precheck = new Dictionary<int, int>();
                for (int i = 1; i < item.Length; i++)
                {
                    int inputvalue = 0;
                    try
                    {

                        inputvalue = Convert.ToInt32(item[i].TrimEnd(new char[] { ',' }));
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Input form of string is wrong");
                        break;
                    }
                    if (precheck.ContainsKey(inputvalue))
                    {
                        precheck[inputvalue]++;
                    }
                    else
                    {
                        precheck.Add(inputvalue, 1);
                    }
                    if (precheck[inputvalue] != 1)
                    {
                        Console.Write("Fail");
                        break;
                    }
                    else if (i == item.Length && precheck.Count < 5)
                    {
                        Console.Write("Fail");
                        break;
                    }
                    if (inputvalue != 8 && i == 1)
                    {   //Always the first input should be 8 Pajms should be removed
                        Console.Write("Fail");
                        break;
                    }
                    //else if (inputvalue!=6 && i==2)
                    //{
                    //    //
                    //    Console.Write("Fail");
                    //    break;
                    //}

                    else if (inputvalue != 1 && i == 5)
                    {
                        //Before leaving the house he/she should wear footwear
                        Console.Write("Fail");
                        break;
                    }
                    else if (inputvalue != 7 && i == 6)
                    {
                        //the last step should be   leaving the house
                        Console.Write("Fail");
                        break;
                    }
                    else if (inputvalue < 0 || inputvalue >9)
                    {//Range check
                        Console.Write("Fail");
                        break;
                    }
                    else if (inputvalue == 3 || inputvalue == 5)
                    { // hot cannot have conditions 3 and 5
                        Console.Write("Fail");
                        break;
                    }
                    else if (inputvalue == 6 && precheck.ContainsKey(1))
                    {
                        Console.Write("Fail");
                        break;
                    }
                    else if (inputvalue == 1 && !precheck.ContainsKey(6))
                    {
                        Console.Write("Fail");
                        break;

                    }
                    else if ((inputvalue == 2 || inputvalue == 5) && !precheck.ContainsKey(4))
                    {
                        Console.Write("Fail");
                        break;
                    }
                    else if (inputvalue == 4 && (precheck.ContainsKey(2) || precheck.ContainsKey(5)))
                    {
                        Console.Write("Fail");
                        break;
                    }
                    else
                    {
                        PrinthotResponse(inputvalue,item[0]);


                    }
                }
            }

            else if (item[0] == "COLD")
            {
                Dictionary<int, int> precoldcheck = new Dictionary<int, int>();
                for (int i = 1; i < item.Length; i++)
                {
                    int inputvalue = 0;
                    try
                    {

                        inputvalue = Convert.ToInt32(item[i].TrimEnd(new char[] { ',' }));
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Input form of string is wrong");
                        break;
                    }
                    if (precoldcheck.ContainsKey(inputvalue))
                    {
                        precoldcheck[inputvalue]++;
                    }
                    else
                    {
                        precoldcheck.Add(inputvalue, 1);
                    }
                    if (precoldcheck[inputvalue] != 1)
                    {
                        //check for duplicates
                        Console.Write("Fail");
                        break;
                    }
                    else if (i == item.Length && precoldcheck.Count < 9)
                    {   //Check all items covered the criteria
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
                    else if (inputvalue==3 && precoldcheck.ContainsKey(1))
                    {
                        Console.Write("Fail");
                        break;
                    }
                    else if (inputvalue == 6 && precoldcheck.ContainsKey(1))
                    {
                        Console.Write("Fail");
                        break;
                    }
                    else if (inputvalue == 4 && (precoldcheck.ContainsKey(2) || precoldcheck.ContainsKey(5)))
                    {
                        Console.Write("Fail");
                        break;
                    }
                    else
                    {
                        PrinthotResponse(inputvalue, item[0]);


                    }
                }
            }
            else
            {
                Console.WriteLine("Input form of string wrong. Make Sure you enter HOT or COLD in UPPERCASE");
            }
        }

        public static void Main(string[] args)
        {
            string response;
            response = Console.ReadLine();
            Program obj = new Program();
            obj.Checkhot(response);
            Console.ReadLine();
        }
    }
}