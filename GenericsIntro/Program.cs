using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string> myDictonary = new MyDictonary<string>();
            myDictonary.Add("yasemin");


            Mylist<string> isimler = new Mylist<string>();
            isimler.Add("Yasemin");

            foreach (var dictionary in myDictonary.Items)
            {
                Console.WriteLine(dictionary);
            }
        }
    }
}
