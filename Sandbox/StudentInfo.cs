using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class StudentInfo
    {
        private Dictionary<int, Student> students;

        public StudentInfo()
        {
            students = new Dictionary<int, Student>();
        }

        // Return the number of students in the group of students
        public int GetStudentCount()
        {
            return students.Count;
        }

        // Add a single student to the group of students
        public void AddStudent(int id, Student aStudent)
        {
            students.Add(id, aStudent);
        }

        // Given an id, return the student with that id.
        // If no student exists with the given id, return null
        public Student GetStudent(int id)
        {
            if (students.ContainsKey(id))
            {
                return students[id];

            }
            else
            {
                return null;
            }
        }

        // Given an id, return the score average for the student with that id.
        // If no student exists with the given id, return 0 (zero).
        public int GetAverageForStudent(int id)
        {
            if (students.ContainsKey(id))
            {
                
                return students[id].GetScoreAverage(); // returns the element on the list with the keyvalue [id] and then
                                                       // makes use of the method found under student.cs which calculates the 
                                                       // average score.
            }
            else
            {
                return 0;
            }
        }

        // Calculate the total test score average for ALL students
        // in the group of students.
        // TIP: Use the method GetAllStudentId and a loop...
        public int GetTotalAverage()  // SOLVE IT MOFO!
        {
            int sum = 0;
            List<int> listOfAllStudentID = GetAllStudentId();           // Make use of the GetallStudentId to make a list
                                                                        // this list is then run through foreach loop by 
            foreach (var item in listOfAllStudentID)                    // + GetAverageForStudent method (0+method) all the 
            {                                                           // averages put together makes the over all average.
                sum = sum + GetAverageForStudent(item);
            }

           return sum;
            
        }

        // Returns a list of all ids of the students in the group of students
        // (leave this method as it is)
        public List<int> GetAllStudentId()
        {
            // A little bit of black magic...
            return (new List<int>(students.Keys.ToArray()));
        }
    }
}
