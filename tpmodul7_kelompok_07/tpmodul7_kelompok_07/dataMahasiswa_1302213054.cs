using System;
using System.IO;
using System.Text.Json;
using System;

public class dataMahasiswa_1302213054()
{
    public dataMahasiswa_1302213054()
    {
        public Nama nama {get; set;}
        public interface nim {get; set;}
        public string fakultas {get; set;}

        public class Nama
        {
            public string depan{get; set;}
            public string belakang{get; set;}
        }

        public static dataMahasiswa_1302213054 ReadJSON(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            dataMahasiswa_1302213054 mahasiswa = JsonSerializer.Deserialize<dataMahasiswa_1302213054>(jsonString);

            Console.WriteLine("Nama {0} {1} dengan nim {2} dari fakultas {3}",
                mahasiswa.nama.depan,mahasiswa.nama.belakang,mahasiswa.nim,mahasiswa.fakultas);
            return mahasiswa;
        }
    }
}