using System;
using System.IO;
using System.Text.Json;

class DataMahasiswa_1302213079
{
    public Nama nama { get; set; }
    public int nim { get; set; }
    public string fakultas { get; set; }

    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public static DataMahasiswa_1302213079 ReadJSON(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        DataMahasiswa_1302213079 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302213079>(jsonString);

        Console.WriteLine("Nama {0} {1} dengan nim {2} dari fakultas {3}",
            mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim, mahasiswa.fakultas);

        return mahasiswa;
    }
}
