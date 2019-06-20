using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ref,out
            //char x = 'a';
            //char y = x;
            //y = 'f';
            //Console.WriteLine(x);

            //int[] a = { 5, 6, 7 };
            //int[] b = a;
            //Console.WriteLine(a[0]);

            //int n = 5;
            //ChangeRef(n);
            //Console.WriteLine(n);

            //int[] a = { 5, 6, 7 };
            //ChangeRef(a);
            //Console.WriteLine(a[2]);

            //int n = 5;
            //ChangeRef(out n);
            //Console.WriteLine(n);
            #endregion

            #region Console App
            //Console.WriteLine("Zehmet olmasa eded daxil edin: ");
            //string mustChangeToInt = Console.ReadLine();
            //int result;

            //bool res=int.TryParse(mustChangeToInt, out result);

            //while (!res)
            //{
            //    Console.WriteLine("Duzgun reqem daxil edin:");
            //    mustChangeToInt = Console.ReadLine();
            //    res = int.TryParse(mustChangeToInt, out result);
            //}
            //Console.WriteLine(result);
            #endregion

            string[] names = { "Aynur", "Firuze", "Shehla", "Shirvan" };
            StringBuilder LastResult = makeString(names);
            Console.WriteLine(LastResult);
            
        }

        static StringBuilder makeString(string[] str)
        {
            StringBuilder result = new StringBuilder();
            foreach (string name in str)
            {
                if (name == str[0])
                {
                    result.Append(name);
                }
                else
                {
                    result.Append(",");
                    result.Append(name);
                }
                //Console.WriteLine(name);
            }
            return result;
        }


        //static string makeString(string[] str)
        //{
        //    string result = "";
        //    foreach (string name in str)
        //    {
        //        if (name==str[0])
        //        {
        //            result += name;
        //        }
        //        else
        //        {
        //            result += ",";
        //            result += name;
        //        }
        //        //Console.WriteLine(name);
        //    }
        //    return result;
        //}

        #region ref,out send Method
        //static void ChangeRef(out int number)
        //{
        //    number = 6;
        //    Console.WriteLine(number);
        //}

        //static void ChangeRef(int[] number)
        //{
        //    number[2] = 6;
        //    Console.WriteLine(number[2]);
        //}
        #endregion

    }
}
