namespace TP_MODUL10_103022400025
{
    public class Film
    {
        // Properti untuk menyimpan informasi film
        public int Id { get; set; }
        public string Judul { get; set; }
        public string Sutradara { get; set; }
        public string Tahun { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }

        // Konstruktor untuk menginisialisasi properti film
        public Film(int id, string judul, string sutradara, string tahun, string genre, string rating)
        {
            this.Id = id;
            this.Judul = judul;
            this.Sutradara = sutradara;
            this.Tahun = tahun;
            this.Genre = genre;
            this.Rating = rating;
        }

    }
}
