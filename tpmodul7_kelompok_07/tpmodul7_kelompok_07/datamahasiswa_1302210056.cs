using System;
using System.IO;
using System.Text.Json;
using System;

public class datamahasiswa_1302210056
{
	public datamahasiswa_1302210056()
	{

        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public static datamahasiswa_1302210056 ReadJSON(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            datamahasiswa_1302210056 mahasiswa = JsonSerializer.Deserialize<datamahasiswa_1302210056>(jsonString);

            Console.WriteLine("Nama {0} {1} dengan nim {2} dari fakultas {3}",
                mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim, mahasiswa.fakultas);

            return mahasiswa;
        }
    }
}
