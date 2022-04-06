using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahasiswa
{
    internal class Mahasiswa
    {
        public string nim { get; set; }
        public string name { get; set; }
        public Mahasiswa()
        {

        }

        public Mahasiswa(string nim, string name)
        {
            this.nim = nim;
            this.name = name;
        }
    }
}
