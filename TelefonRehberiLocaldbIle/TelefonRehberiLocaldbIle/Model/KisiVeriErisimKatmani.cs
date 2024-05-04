using System.Collections.Generic;
using System.Data.SqlClient;

namespace TelefonRehberiLocaldbIle.Model
{
    internal class KisiVeriErisimKatmani
    {
        string _baglantiCumlesi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Rehber.mdf;Integrated Security=True";
              
        public List<Kisi> TumKisileriGetir()
        {
            using (SqlConnection baglanti = new SqlConnection(_baglantiCumlesi))
            {
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand("SELECT * FROM liste", baglanti))
                {
                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        List<Kisi> kisiler = new List<Kisi>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string ad = reader.GetString(1);
                            string soyad = reader.GetString(2);
                            string telefon = reader.GetString(3);

                            kisiler.Add(new Kisi(id, ad, soyad, telefon));
                        }

                        return kisiler;
                    }
                }
            }
        }

        public void KisiEkle(Kisi kisi)
        {
            using (SqlConnection baglanti = new SqlConnection(_baglantiCumlesi))
            {
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand("INSERT INTO liste (Ad, Soyad, Telefon) VALUES (@ad, @soyad, @telefon)", baglanti))
                {
                    komut.Parameters.AddWithValue("@ad", kisi.Ad);
                    komut.Parameters.AddWithValue("@soyad", kisi.Soyad);
                    komut.Parameters.AddWithValue("@telefon", kisi.Telefon);

                    komut.ExecuteNonQuery();
                }
            }
        }

        public void KisiGuncelle(Kisi kisi)
        {
            using (SqlConnection baglanti = new SqlConnection(_baglantiCumlesi))
            {
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand("UPDATE liste SET Ad = @ad, Soyad = @soyad, Telefon = @telefon WHERE Id = @id", baglanti))
                {
                    komut.Parameters.AddWithValue("@id", kisi.Id);
                    komut.Parameters.AddWithValue("@ad", kisi.Ad);
                    komut.Parameters.AddWithValue("@soyad", kisi.Soyad);
                    komut.Parameters.AddWithValue("@telefon", kisi.Telefon);

                    komut.ExecuteNonQuery();
                }
            }
        }

        public void KisiSil(int id)
        {
            using (SqlConnection baglanti = new SqlConnection(_baglantiCumlesi))
            {
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand("DELETE FROM liste WHERE Id = @id", baglanti))
                {
                    komut.Parameters.AddWithValue("@id", id);

                    komut.ExecuteNonQuery();
                }
            }
        }
    }
}
