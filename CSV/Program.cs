using System;
using CsvHelper;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Formats.Asn1;

namespace CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\sport\Documents\ACS\Others\Students_ - Students_.csv"))

            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Data>().ToList();


                var queryOne = from z in records
                               where z.first_name == "John"
                               select z;


                foreach (var item in records)
                {
                    Console.WriteLine($"Hello my name is {item.first_name}," +
                        $"{item.last_name},{item.gender}. I study at {item.university}, and my GPA is {item.GPA}. Email me on {item.email}.");

                }
            }



        }

        class Data
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string university { get; set; }
            public string GPA { get; set; }


        }
    }
}