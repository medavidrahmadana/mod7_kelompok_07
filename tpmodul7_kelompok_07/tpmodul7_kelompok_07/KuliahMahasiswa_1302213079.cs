using System;
using System.IO;
using System.Text.Json;

class KuliahMahasiswa_1302213079
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public List<Course> courses { get; set; }

    public void ReadJSON(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        KuliahMahasiswa_1302213079 data = JsonSerializer.Deserialize<KuliahMahasiswa_1302213079>(jsonString);

        Console.WriteLine("====================================================================");
        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (Course course in data.courses)
        {
            Console.WriteLine("MK {0} {1} - {2}", i++, course.code, course.name);
        }
        Console.WriteLine("====================================================================");
    }
}