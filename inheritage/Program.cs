using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            person1.Nama = "Adel";
            person1.Umur = 17;
            person1.infoperson();

            //inheritage
            karyawan karyawan1 = new karyawan();
            karyawan1.Nama = "Zee";
            karyawan1.Umur = 18;
            karyawan1.infoperson();
            karyawan1.infoperson("Dosen", "12345");
            Console.ReadKey();
        }
    }
}
