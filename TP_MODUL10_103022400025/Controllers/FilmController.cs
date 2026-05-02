using Microsoft.AspNetCore.Mvc;
using TP_MODUL10_103022400025.Services;

namespace TP_MODUL10_103022400025.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        private readonly FilmService _filmService;

        // Inject service melalui konstruktor
        public FilmController(FilmService filmService)
        {
            _filmService = filmService;
        }

        // Ambil semua film
        [HttpGet(Name = "GetFilms")]
        public IEnumerable<Film> Get()
        {
            return _filmService.Films;
        }

        // Ambil film berdasarkan id
        [HttpGet("{id}")]
        public IActionResult GetFilmByID(int id)
        {
            // Cari film dengan id yang sesuai
            var film = _filmService.Films.FirstOrDefault(f => f.Id == id);
            if (film == null)
                return NotFound(new { message = "Film not found." });

            return Ok(film);
        }

        // Tambah film baru
        [HttpPost]
        public IActionResult AddFilm(Film film)
        {
            // Masukkan film baru ke dalam list
            _filmService.Films.Add(film);
            return Ok(new { message = "Film added successfully." });
        }

        // Hapus film berdasarkan id
        [HttpDelete("{id}")]
        public IActionResult DeleteFilm(int id)
        {
            // Cari film dengan id yang sesuai
            var film = _filmService.Films.FirstOrDefault(f => f.Id == id);
            // Jika film tidak ditemukan, kembalikan NotFound
            if (film == null)
                return NotFound();

            // Hapus film dari list
            _filmService.Films.Remove(film);
            return Ok(new { message = "Film deleted." });
        }
    }
}
