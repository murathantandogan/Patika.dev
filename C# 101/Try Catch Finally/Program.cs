using System;

namespace Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayı:" + sayi);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            //finally
            //{
            //    Console.WriteLine("İşlem Tamamlandı");
            //}


            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("test");

            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Veri tip uygun değil");
                Console.WriteLine(ex);
            }

            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla Tamamlandı");
            }



        }
    }
}
