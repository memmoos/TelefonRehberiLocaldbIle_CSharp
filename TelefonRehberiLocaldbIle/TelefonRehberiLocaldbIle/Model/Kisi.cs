namespace TelefonRehberiLocaldbIle.Model
{
    internal class Kisi
    {
        int _id;
        string _ad;
        string _soyad;
        string _telefon;

        public int Id { get => _id; set => _id = value; }
        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }

        public Kisi(int id, string ad, string soyad, string telefon)
        {
            _id = id;
            _ad = ad;
            _soyad = soyad;
            _telefon = telefon;
        }

        public Kisi(string ad, string soyad, string telefon)
        {
            _ad = ad;
            _soyad = soyad;
            _telefon = telefon;
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad} ({Telefon})";
        }
    }
}
