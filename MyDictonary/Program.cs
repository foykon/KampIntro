using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, int> myDictonary = new MyDictonary<int, int>();
            myDictonary.Add(1, 1);
            Console.WriteLine(myDictonary.Count);
            myDictonary.Add(2, 2);
            Console.WriteLine(myDictonary.Count);
            myDictonary.Add(3, 3);
            Console.WriteLine(myDictonary.Count);
            myDictonary.Add(6, 6);
            Console.WriteLine(myDictonary.Count);
            myDictonary.Add(5, 5);
            Console.WriteLine(myDictonary.Count);

            myDictonary.Show(myDictonary);







        }
    }
}
