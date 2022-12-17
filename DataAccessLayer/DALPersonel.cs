using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer

{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * FROM TBLBILGI", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD,SOYAD,SEHIR,GOREV,MAAS) values (@p1,@p2,@p3,@p4,@p5);", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Sehir);
            komut2.Parameters.AddWithValue("@p4", p.Gorev);
            komut2.Parameters.AddWithValue("@p5", p.Maas);
            return komut2.ExecuteNonQuery();

        }

        public static bool PersonelSil(int s)
        {
            SqlCommand komut3 = new SqlCommand("DELETE FROM TBLBILGI WHERE ID=@P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", s);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool PersonelGuncelle(EntityPersonel g)
        {
            SqlCommand komut4 = new SqlCommand("Update TBLBILGI set AD=@P1,SOYAD=@P2,SEHIR=@P3,GOREV=@P4,MAAS=@P5 WHERE ID =@P6", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", g.Ad);
            komut4.Parameters.AddWithValue("@p2", g.Soyad);
            komut4.Parameters.AddWithValue("@p3", g.Sehir);
            komut4.Parameters.AddWithValue("@p4", g.Gorev);
            komut4.Parameters.AddWithValue("@p5", g.Maas);
            komut4.Parameters.AddWithValue("@p6", g.Id);

            return komut4.ExecuteNonQuery() > 0;

        }
    }
}
