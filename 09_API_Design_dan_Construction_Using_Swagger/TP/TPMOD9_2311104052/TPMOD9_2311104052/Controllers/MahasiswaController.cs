using Microsoft.AspNetCore.Mvc;
using TPMOD9_2311104052.Models;

namespace TPMOD9_2311104052.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa { Nama = "izzaty zahara br barus", NIM = "2311104052" },
            new Mahasiswa { Nama = "Pradana Argo", NIM = "2311104050" },
            new Mahasiswa { Nama = "Rizaldy AUlia", NIM = "2311104051" },

        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Mahasiswa tidak ditemukan");
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public IActionResult Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok("Mahasiswa berhasil ditambahkan");
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Index tidak valid");
            daftarMahasiswa.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus");
        }
    }
}