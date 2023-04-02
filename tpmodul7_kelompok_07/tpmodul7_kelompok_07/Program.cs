using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_1302213079 mahasiswa = DataMahasiswa_1302213079.ReadJSON("tp7_1_1302213079.json");
        KuliahMahasiswa_1302213079 kuliah = new KuliahMahasiswa_1302213079();
        kuliah.ReadJSON("tp7_2_1302213079.json");

    }
}
