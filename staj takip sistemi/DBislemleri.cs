using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace staj_takip_sistemi
{
    public class DBislemleri
    {
        static string baglantiyolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stajsistemi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static DataSet YetkiCek()
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select * from Yetki";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonucds = new DataSet();
            baglanti.Open();
            adaptor.Fill(sonucds);
            baglanti.Close();

            return sonucds;

        }
        public static bool KadiKontrol(string Kadi)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select * from Kisi where KullaniciAdi=@pKad";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pKad", Kadi);
            DataSet sonucDs = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            baglanti.Open();
            adaptor.Fill(sonucDs);
            baglanti.Close();
            bool sonuc = false;
            if (sonucDs.Tables[0].Rows.Count > 0)
                sonuc = true;
            else
                sonuc = false;
            return sonuc;



        }
        public static void Ekle(string kulad,string ad,string soyad,string sifre,int yetid)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "insert into Kisi values(@pKadi,@padi,@pKsoyadi,@psifre,@pid,'2')";
            SqlCommand komut = new SqlCommand(sql,baglanti);
            komut.Parameters.AddWithValue("@pKadi",kulad);
            komut.Parameters.AddWithValue("@padi",ad);
            komut.Parameters.AddWithValue("@pKsoyadi",soyad);
            komut.Parameters.AddWithValue("@psifre",sifre);
            komut.Parameters.AddWithValue("@pid",yetid);
            komut.CommandText = sql;
            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public static void Ekle2(string kulad, string ad, string sifre, int yetid)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "insert into Kisi values(@pKadi,@padi,@pKsoyadi,@psifre,@pid)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pKadi", kulad);
            komut.Parameters.AddWithValue("@padi", ad);
            
            komut.Parameters.AddWithValue("@psifre", sifre);
            komut.Parameters.AddWithValue("@pid", yetid);
            komut.CommandText = sql;
            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public static DataSet Firmalar()
        {
           
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select Adi AS Firma,UserID AS FirmaNO from Kisi where YetkiID=2 ";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;           
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static void degistir(int firmaıd,int ogrıd)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "INSERT INTO Firmasec(DurumID,FirmaID,ogrID)Values('2',@psecim,@pogrıd)";
          //  string sql = "UPDATE Firmasec SET DurumID=2 SET FirmaID=@psecim SET ogrID=@pogrıd";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@psecim", firmaıd);
            komut.Parameters.AddWithValue("@pogrıd", ogrıd);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();



            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }
        public static DataSet istekler(int firma)
        {
           
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select Kisi.Adi,Kisi.Soyadi,Firmasec.SecimID from Firmasec INNER JOIN Kisi ON Kisi.UserID=Firmasec.ogrID where FirmaID=@pfirm";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pfirm", firma);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static void kabul(int istek)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "UPDATE Firmasec SET DurumID=3 WHERE SecimID=@psecim";
            //  string sql = "UPDATE Firmasec SET DurumID=2 SET FirmaID=@psecim SET ogrID=@pogrıd";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@psecim", istek);
            
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();



            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }
        public static void red(int istek)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "UPDATE Firmasec SET DurumID=4 WHERE SecimID=@psecim";
            //  string sql = "UPDATE Firmasec SET DurumID=2 SET FirmaID=@psecim SET ogrID=@pogrıd";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@psecim", istek);

            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();



            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }
        public static DataSet Kabuller(int id)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select Kisi.Adi AS FirmaAdı from Kisi INNER JOIN  Firmasec ON Firmasec.FirmaID=Kisi.UserID where Firmasec.DurumID=3 AND Firmasec.ogrID=@pid ";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pid", id);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static DataSet Kabuller2(int id)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select OnayDurumu AS DefterKabulEdildi from Onay where KisiID=@pid ";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pid", id);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static DataSet Kabuller3(int id)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select StajYeri from SForm where DurumID=3 AND OgrID=@pid ";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pid", id);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static void StajForm1(string Syer, string SBT, string BBT, string Adres, string Tel,string Gun,int id)
        {
            string a = "2";
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "insert into SForm values(@pid,@pYer,@pSBT,@pAdres,@ptel,@pgun,@pBBT,@psay)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pYer", Syer);
            komut.Parameters.AddWithValue("@pSbt", SBT);
            komut.Parameters.AddWithValue("@pBBT", BBT);
            komut.Parameters.AddWithValue("@padres", Adres);
            komut.Parameters.AddWithValue("@ptel", Tel);
            komut.Parameters.AddWithValue("@pgun", Gun);
            komut.Parameters.AddWithValue("@pid", id);
            komut.Parameters.AddWithValue("@psay", a);
            komut.CommandText = sql;
            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public static void StajForm(string gun ,string Not,int ID)
        {
      //      INSERT INTO Firmasec(DurumID, FirmaID, ogrID)Values('2', @psecim, @pogrıd)
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "insert into KDefter values(@pUID,@pgun,@pnot)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pnot", Not);
            komut.Parameters.AddWithValue("@pgun", gun);

            komut.Parameters.AddWithValue("@pUID", ID);
            komut.CommandText = sql;
            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public static DataSet Formcek()
        {
            
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select Kisi.Adi,SForm.OgrID,SForm.FormID from SForm INNER JOIN Kisi ON OgrID=UserID";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static DataSet Kisilericek()
        {

            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select Kisi.Adi,Kisi.Soyadi,KDefter.UserID from KDefter INNER JOIN Kisi ON Kisi.UserID=KDefter.UserID";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
       
        public static DataSet Deftercek(string id)
        {

            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select * from KDefter where UserID=@pid";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pid", id);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static DataSet KisiForm(string ID)
        {
            
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select * From SForm where OgrID=@pid";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pid", ID);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static DataSet FormOnay(string FormID)
        {
          
          //  UPDATE Firmasec SET DurumID = 4 WHERE SecimID = @psecim
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "UPDATE SForm SET DurumID =3 Where FormID=@pid";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pid", FormID);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static DataSet FormRed(string FormID)
        {

            //  UPDATE Firmasec SET DurumID = 4 WHERE SecimID = @psecim
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "UPDATE KurumDurum SET DurumID =4 Where FormID=@pid";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pid", FormID);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
        public static DataSet DefterOnay(string KİSİID)
        {
            //  insert into KDefter values(@pUID, @pgun, @pnot)
            //  UPDATE Firmasec SET DurumID = 4 WHERE SecimID = @psecim
            int a = 3;
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "insert into Onay values(@pid,@ponay)";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pid", KİSİID);
            komut.Parameters.AddWithValue("@ponay",a);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }

        public static DataSet DefterRed(string KİSİID)
        {

            //  UPDATE Firmasec SET DurumID = 4 WHERE SecimID = @psecim
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "UPDATE Onay SET OnayDurumu =4 Where KisiID=@pid";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pid", KİSİID);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            baglanti.Open();

            adaptor.Fill(sonuc);
            baglanti.Close();

            return sonuc;


        }
    }
}