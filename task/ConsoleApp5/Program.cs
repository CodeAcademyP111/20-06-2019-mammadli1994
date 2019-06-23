using System;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)

        {
            #region reverse
            //string b = "sirvan kisidi";
            //Console.WriteLine(letter(b));
            #endregion

            #region ededi ortani tapmaq
            //int[] a = { 10, 15, 5, 20 };
            //    double result = Sum(a);
            //    Console.WriteLine(Sum(a));
            #endregion
            #region space /*sozlerde bosluqu yazmaq*/
            //string[] b = { "cox praktika etsen alinacaq coox calis sen" };
            //Console.WriteLine(Spc(b));
            #endregion

            #region void funksiya yazilmalidi /*bir simvoldan necedenedi*/
            //string str = "yazilmalidir";
            //int count = 1;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j] && i!=j)
            //        {
            //            count++;

            //        }

            //    }
            //    Console.WriteLine((str[i] + "bu simvoldan " + count + " ededdir"));
            //    count = 1;
            //}
            #endregion

        }

        #region ededi ortani tapmaq
        //static double Sum(int[] arr)
        //{
        //    double result = 0;
        //    int count = 0;
        //    for (var  i = 0; i < arr.Length; i++)
        //    {
        //        count++;
        //        result += arr[i];
        //    }
        //    if (count == arr.Length)
        //    {
        //     result /= count;
        //    }
        //    return result;
        //    {

        //    }
        //}
        #endregion

        #region space /*sozlerde bosluqu yazmaq*/
        //static string Spc(string[] str)
        //{
        //    string result = " ";
        //    int count = 0;
        //    foreach (string name in str)

        //    {
        //        if (name == str[0])
        //        {
        //            count = name.Split(' ').Length - 1;
        //        }
        //        else
        //        {
        //            count = name.Split(' ').Length;

        //        }

        //    }
        //    return "bosluq: " + count;
        //}
        #endregion

        #region reverse  /* cevirmek tersine sozleri*/
        //static string letter(string str)
        //{
        //    char[] chars = str.ToCharArray();
        //    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        //    {
        //        chars[i] = str[j];
        //        chars[j] = str[i];

        //    }
        //    return new string(chars);

        //}
        #endregion


    }
}
