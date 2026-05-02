using Microsoft.AspNetCore.Mvc;

namespace TP_MODUL10_103022400025.Services
{
    public class FilmService
    {
        // List untuk menyimpan data film
        public List<Film> Films { get; } = new List<Film>();

        // Konstruktor untuk mengisi data awal film
        public FilmService()
        {
            // Tambahkan beberapa film ke dalam list sebagai data awal
            Films.Add(new Film(1, "Inception", "Christopher Nolan", "2010", "Sci-Fi", "9.0"));
            Films.Add(new Film(2, "Interstellar", "Christopher Nolan", "2014", "Sci-Fi", "8.7"));
            Films.Add(new Film(3, "Parasite", "Bong Joon-ho", "2019", "Thriller", "8.6"));
        }
    }
}
