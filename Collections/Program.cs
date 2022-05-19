using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array/arrayList
            int[] arr = new int[4];

            // initializing array
            arr[0] = 47;
            arr[1] = 77;
            arr[2] = 87;
            arr[3] = 97;

            // traversing array
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i]);
            }

            //Console.WriteLine(arr[5]);

            ArrayList al = new ArrayList();
            al.Add("Ajay");
            al.Add("Ankit");
            al.Add(10);
            al.Add(10.10);

            // Iterate list element using foreach loop
            foreach (var names in al)
            {
                Console.WriteLine(names);
            }

            Console.WriteLine(al[5]);

            #endregion

            #region HashTable/Disctonary
            // Creating a dictionary
            // using Dictionary<TKey, TValue> class
            Dictionary<string, string> My_dict =
                        new Dictionary<string, string>();

            // Adding key/value pairs in the Dictionary
            // Using Add() method
            My_dict.Add("a.01", "C");
            My_dict.Add("a.02", "C++");
            My_dict.Add("a.03", "C#");

            foreach (KeyValuePair<string, string> element in My_dict)
            {
                Console.WriteLine("Key:- {0} and Value:- {1}",
                                  element.Key, element.Value);
            }


            // Create a hashtable
            // Using Hashtable class
            Hashtable my_hashtable = new Hashtable();

            // Adding key/value pair in the hashtable
            // Using Add() method
            my_hashtable.Add("A1", "Welcome");
            my_hashtable.Add("A2", "to");
            my_hashtable.Add("A3", "GeeksforGeeks");

            foreach (DictionaryEntry element in my_hashtable)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ",
                                   element.Key, element.Value);
            }
            #endregion

            #region IQurable/IEnurable
            List<Student> studentList = new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Gender = "Male"},
                new Student(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student(){ID = 4, Name = "Pam", Gender = "Female"}
            };
            //Linq Query to Fetch all students with Gender Male
            IEnumerable<Student> QuerySyntax = from std in studentList
                                               where std.Gender == "Male"
                                               select std;
            //Iterate through the collection
            foreach (var student in QuerySyntax)
            {
                Console.WriteLine($"ID : {student.ID}  Name : {student.Name}");
            }

            //Linq Query to Fetch all students with Gender Male
            IQueryable<Student> MethodSyntax = studentList.AsQueryable()
                                .Where(std => std.Gender == "Male");

            //Iterate through the collection
            foreach (var student in MethodSyntax)
            {
                Console.WriteLine($"ID : {student.ID}  Name : {student.Name}");
            }


            #endregion
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
