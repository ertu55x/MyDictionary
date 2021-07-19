using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();

            students.Add(5534, "Ertuğrul");
            students.Add(9054, "Ertuğ");
            students.Add(6041, "Ertan");

            foreach (var student in students.Keys)
            {
                Console.WriteLine(student);
            }
           
           
        }
    }
   
}
