using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestü2
{
    internal class Program
    {
        #region yasHesaplamaGirdiler
        //public static readonly int yil  = 2022;
        //public static readonly int yil = DateTime.Now.Year; 
        #endregion
        static void Main(string[] args)
        {
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region consoleColor
            //Console.BackgroundColor = ConsoleColor.DarkCyan;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.Clear();
            //Console.WriteLine("Adinizi giriniz");
            //Console.ReadKey();
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region basilanTus
            //char karakter;
            //Console.WriteLine("Bir karakter giriniz");
            //karakter = (char)Console.Read();
            //Console.WriteLine("Basilan tus " + karakter);
            //Console.ReadKey();
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region basilanTusImproved
            //Console.WriteLine("Bir tusa basiniz");
            //ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            //Console.Clear();
            //Console.WriteLine(KeyInfo.Key.ToString() + " Tusuna bastiniz");
            //Console.ReadLine();
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region basicConditions
            //string ad, soyad;
            //Console.WriteLine("Adinizi giriniz");
            //ad = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Soyadinizi giriniz");
            //soyad = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Ekrana yazdirma icin F2 cikmak icin ESC tusuna basiniz");
            //ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            //if (KeyInfo.Key == ConsoleKey.Escape)
            //{
            //    System.Environment.Exit(0);
            //}
            //else if (KeyInfo.Key == ConsoleKey.F2)
            //{
            //    Console.Write(ad +" "+ soyad);
            //    Console.ReadKey();
            //}
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region consoleEdit
            //Console.SetWindowSize(30, 15);
            //Console.Clear();
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            //Console.WriteLine("C Sharp");
            //Console.ReadLine();
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region conditions2
            //Console.WriteLine("Cikmak istediginize emin misiniz [E/H] ?");
            //string cevap = Console.ReadLine();
            //if (cevap == "E")
            //{
            //    System.Environment.Exit(0);
            //}
            //else
            //    Console.WriteLine("devam");
            //Console.ReadLine();  
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region cemberAlanCevreHesabi
            //const double PI = 3.142857143;
            //double alan, cevre, yr;
            //string yaricap = " ";

            //Console.Write("lutfen yaricapi giriniz = ");
            //yaricap = Console.ReadLine();
            //Console.Clear();



            //while (yaricap != "0")
            //{
            //    Console.Write("\nlutfen yaricapi giriniz = ");
            //    yaricap = Console.ReadLine();

            //    if (!Double.TryParse(yaricap, out yr))
            //    {
            //        Console.WriteLine("UYARI");
            //    }


            //    else if (Double.TryParse(yaricap, out yr))
            //    {
            //        yr = Convert.ToDouble(yaricap);
            //        Console.Clear();
            //        alan = PI * (Math.Pow(yr, 2));
            //        cevre = 2 * PI * yr;

            //        Console.WriteLine("Cemberin cevresi = " + cevre + " cm");
            //        Console.WriteLine("Cemberin alani = " + alan + " cm");
            //    }

            //}
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region yasHesaplama
            //Console.WriteLine("Dogum yilinizi giriniz : ");
            //int dogum_yili = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Yasiniz = " + (yil - dogum_yili));
            //Console.ReadKey(); 
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region object
            //object rakam = 10;
            //    Console.WriteLine(rakam.GetType());
            //    Console.ReadKey();
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region dynamic
            //dynamic rakam = 10;
            //Console.WriteLine(rakam.GetType());
            //   Console.ReadKey();
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region Object/Int32
            //object rakam = 10;
            //    rakam = (int)rakam + 10;
            //    Console.WriteLine(rakam);
            //    Console.ReadKey();  
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region dynamic/double
            //dynamic rakam = 10;
            //    rakam = (double)rakam + 10;
            //    Console.WriteLine(rakam);
            //    Console.ReadKey();
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region Local/Global
            //int a = 10;
            //{
            //    int b = 20;                               // b degiskeni bir kod blogu
            //    Console.WriteLine(a+b);                   icinde tanimlandigi icin sadece o kod blogu
            //}                                             icinde  gecerlidir.    
            //    Console.ReadLine();
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            #region default
            //Console.WriteLine(default(int));
            //Console.WriteLine(default(bool));
            //Console.ReadLine();
            #endregion
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        



        }
    }
}
