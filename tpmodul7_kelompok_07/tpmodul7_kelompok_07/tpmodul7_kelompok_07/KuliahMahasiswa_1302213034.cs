using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_07
{
    internal class KuliahMahasiswa_1302213034
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }
        public List<Course> courses { get; set; }
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\Rheins\\Downloads\\mod7_kelompok_07\\tpmodul7_kelompok_07\\tpmodul7_kelompok_07\\tp7_2_1302213034.json");
            KuliahMahasiswa_1302213034 data = JsonSerializer.Deserialize<KuliahMahasiswa_1302213034>(jsonString);

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
}
