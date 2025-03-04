using System;
using System.Collections.Generic;

namespace TPMODUL3_2311104052;
using System;
class KodePos
    {
        private Dictionary<string, string> dataKodePos = new Dictionary<string, string>
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40273"}
        };

        public void TampilkanSemuaKodePos()
        {
            foreach (var item in dataKodePos)
            {
                Console.WriteLine($"Kode Pos Kelurahan {item.Key}: {item.Value}");
            }
        }
    }
