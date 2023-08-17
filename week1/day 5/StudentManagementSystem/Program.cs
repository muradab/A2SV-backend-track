using System;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var students = new StudentList<Student>();

        // Add some sample students
        students.Add(new Student("Alice", 18, 101, "A"));
        students.Add(new Student("Bob", 17, 102, "B"));

        // Serialize student data to JSON and save to a file
        string json = JsonConvert.SerializeObject(students.GetAll());
        File.WriteAllText("students.json", json);

        // Read JSON from file and deserialize
        string fileContent = File.ReadAllText("students.json");
        var deserializedStudents = JsonConvert.DeserializeObject<List<Student>>(fileContent);

        // Display all students
        Console.WriteLine("List of Students:");
        foreach (var student in deserializedStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, RollNumber: {student.RollNumber}, Grade: {student.Grade}");
        }

        // Search for a student by name
        string searchName = "Alice";
        var searchResult = deserializedStudents.FirstOrDefault(s => s.Name == searchName);
        if (searchResult != null)
        {
            Console.WriteLine($"Search result for '{searchName}': RollNumber {searchResult.RollNumber}");
        }
        else
        {
            Console.WriteLine($"Student '{searchName}' not found.");
        }
    }
}
