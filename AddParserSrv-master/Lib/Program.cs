using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using testApp;
using Utilities;
namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(statics.error);

            AddParserSrv.AddressParserSRV cs = new AddParserSrv.AddressParserSRV();

            var m = cs.ParseAddressFromString("Ömür Tepe Caddesi Tarabya Mahallesi Bolat Sokak Yıldırım Apartmanı Kat 1 no 4 sarıyer / istanbul");


            Console.WriteLine(string.Format("bolge : {0}", m.Bolge));
            Console.WriteLine(string.Format("cadde : {0}", m.Cadde));
            Console.WriteLine(string.Format("mahalle : {0}", m.Mahalle));
            Console.WriteLine(string.Format("sokak : {0}", m.Sokak));
            Console.WriteLine(string.Format("site: {0}", m.Site));
            Console.WriteLine(string.Format("blok : {0} ", m.Blok));
            Console.WriteLine(string.Format("apartman : {0}", m.Bina));
            Console.WriteLine(string.Format("kat  : {0}", m.Kat));
            Console.WriteLine(string.Format("daire : {0}", m.Daire));
            Console.WriteLine(string.Format("numara : {0}", m.No));
            Console.WriteLine(string.Format("ilçe : {0}", m.Ilce));
            Console.WriteLine(string.Format("il : {0}", m.Il));
            Console.ReadKey();


            //            String = "MyWord,AnotherWord,TheEnd"

            //String = Regex.Replace(String, "(?<=,)(?!\\s)", " ");

            //Value of the string is now . . . . .

            //String = "MyWord, AnotherWord, TheEnd"



        }
    }
}
