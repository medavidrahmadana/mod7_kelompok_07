using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_07
{
    internal class DataMahasiswa_1302213034
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\Rheins\\Downloads\\mod7_kelompok_07\\tpmodul7_kelompok_07\\tpmodul7_kelompok_07\\tp7_1_1302213034.json");
            DataMahasiswa_1302213034 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302213034>(jsonString);

            Console.WriteLine("Nama {0} {1} dengan nim {2} dari fakultas {3}", mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim, mahasiswa.fakultas);

            
        }
    }
}
