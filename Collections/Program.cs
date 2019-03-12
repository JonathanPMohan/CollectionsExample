using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsWithBlackHair = new List<string> { "Nathan", "Austin", "Walker", "Marty" };
        
            var studentsByHairColor = new Dictionary<string, List<string>>
            {
                {"Black", studentsWithBlackHair }
            };

            studentsByHairColor.Add("Bald", new List<string> { "Martin" });

            //This throws an exception://
            //studentsByHairColor.Add("Bald", new List<string> { "Adam" });//

            var theBlackHairedStudents = studentsByHairColor["Black"];

            if (theBlackHairedStudents == studentsWithBlackHair)
            {
                Console.WriteLine("They are the same");
            }

            studentsByHairColor["Black"].Add("new person");
            
            foreach (var (hairColor, students) in studentsByHairColor)
            {
                Console.WriteLine($"The Following Students Have {hairColor} Hair Color");

                students.Add("new person");

                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }

                
            }

            Console.ReadLine();
        }
    }
}
