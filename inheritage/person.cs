using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritage
{
    public class person
    {
        //properti
        public string Nama { get; set; }
        public int Umur { get; set; }

        //constructor
        public person(string nama, int umur)
        {
            this.Nama = nama;
            this.Umur = umur;
        }

        public person()
         {

         }

        //fungsi
        public void infoperson()
        {
            Console.WriteLine("Nama saya {0}, dan umur saya {1} tahun", this.Nama, this.Umur);
        }
    }

    //class turunan
    public class karyawan : person
    {
        //properti class turunan
        public string karyawanID { get; set; }
        public string subjek { get; set; }

        //constructor
        public karyawan(string karyawanID, string subjek)
        {
            this.subjek = subjek;
            this.karyawanID=karyawanID;
        }

        public karyawan()
        {

        }

        //override method
        public void infoperson(string subjek, string karyawanID)
        {
            this.subjek = subjek;
            this.karyawanID = karyawanID;
            Console.WriteLine("Saya sebagai {0} dengan ID karyawan {1}" , this.subjek, this.karyawanID);
        }
    }
}
