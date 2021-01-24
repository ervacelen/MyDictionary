using System;
using System.Collections.Generic;
using System.Text;

namespace My.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string, string> members = new MyDictionary<int, string, string>();
            members.Add(123, "Erva", "Engineer");
            members.Add(456, "Elif", "Dentist");
            members.Add(789, "Sena", "Teacher");
            members.Add(987, "Gizem", "Doctor");

            Console.WriteLine("total number of members: " + members.Length);

            Console.WriteLine("*** Members ID cards ***");
            foreach(var Id in members.Id)
            {
                Console.WriteLine(Id);
            }
            Console.WriteLine("***Members Name***");
            foreach(var name in members.Name)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("***Members Job***");
            foreach(var jobs in members.Job)
            {
                Console.WriteLine(jobs);
            }
        }
    }
}
