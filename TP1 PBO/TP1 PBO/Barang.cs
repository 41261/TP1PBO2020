using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_PBO
{
    class Barang
    {
        public string barang { get; set; }
        public int harga { get; set; }
        public string jenis { get; set; }

        public Barang(string barang, int harga, string jenis)
        {
            this.barang = barang;
            this.harga = harga;
            this.jenis = jenis;
        }

        public Barang() { }
    }
}
