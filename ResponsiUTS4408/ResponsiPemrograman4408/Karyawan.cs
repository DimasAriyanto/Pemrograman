using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4408
{
    internal class Karyawan
    {
        private int NIK { get; set; }
        private string Nama { get; set; }
        private float GajiBulanan { get; set; }

        public Karyawan(int nik, string nama, float gaji)
        {
            this.NIK = nik;
            this.Nama = nama;
            this.GajiBulanan = gaji;
        }

        public int getNik()
        {
            return NIK;
        }

        public string getNama()
        {
            return Nama;
        }

        public float getGajiBulanan()
        {
            if (GajiBulanan < 0)
            {
                GajiBulanan = 0;
            }

            return GajiBulanan;
        }

        public void NaikkanGaji(float persentase)
        {
            this.GajiBulanan = persentase / 100 * this.GajiBulanan + this.GajiBulanan;
        }

    }
}
