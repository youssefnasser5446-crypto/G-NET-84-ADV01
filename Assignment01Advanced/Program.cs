using Assignment01Advanced.Question03;
using Assignment01Advanced.Question04;

namespace Assignment01Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /*
             
             Q1: What is a generic class? Why use generics?

            ans => It is a class capable of work with different data type;
            we use generics to avoid runtime errors,
            ensuring that any data type issues are detected at compile time.

             */
            #endregion

            #region Question02

            ///*
            // Q2: Write a generic class Container<T> with Add and Get methods.
            //*/
            //Containers<int> co = new Containers<int>();
            //co.Add(1);
            //co.Add(2);
            //co.Add(3);
            //Console.WriteLine($"index 1 is : {co.Get(1)}");//2
            //Console.WriteLine(co);//2

            #endregion

            #region Question03

            /*
             Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
             */

            //Pair<int, string> p = new Pair<int, string>(1, "ahmed");
            //Console.WriteLine($" Key is : {p.Key}\n Value is : {p.Value}");

            #endregion

            #region Question04

            ///*
            // Q5: Write a generic method FindMax<T> that finds maximum value
            // */

            //int[] arr = { 5, 2, 8, 87, -15, 7 };
            //if (arr.Length == 0)
            //    throw new ArgumentException("Array cannot be empty");
            //Search se = new Search();
            //Console.WriteLine($"max num is : {se.FindMax(arr)}");

            #endregion

        }
    }
}
