using System;
using System.Collections.Generic;
using System.IO;
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

            using (StreamReader sr = new StreamReader("C:\\rearrange.txt"))
            {
                String line = sr.ReadToEnd();
               
                Console.ReadLine();
            }

            //string[] lines = File.ReadAllLines("C:\\rearrange.txt");
            //List<string> stringfyList = new List<string>();

            //foreach (var item in lines)
            //{
            //    stringfyList.Add(item.ToString());
            //}

            //foreach (var ritem in stringfyList)
            //{
            //    Console.WriteLine("the lines in string is {0}", ritem);
            //}

            //Console.WriteLine("Length: {0}", lines.Length);
            //Console.WriteLine("First: {0}", lines[2]);

            //int count = 0;
            //foreach (string line in lines)
            //{
            //    count++;
            //}

            //int c = 0;
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    c++;
            //}

            //Console.WriteLine("Count: {0}", count);
            //Console.WriteLine("C: {0}", c);
            //Console.ReadLine();
            //AddParserSrv.AddressParserSRV cs = new AddParserSrv.AddressParserSRV();

            //var m = cs.ParseAddressFromString("yakup emniyet mudurlugu  Ömür Tepe Caddesi Tarabya Mahallesi Bolat Sokak Yıldırım Apartmanı Kat 1 no 4 sarıyer / istanbul");


            //Console.WriteLine(string.Format("bolge : {0}", m.Bolge));
            //Console.WriteLine(string.Format("cadde : {0}", m.Cadde));
            //Console.WriteLine(string.Format("mahalle : {0}", m.Mahalle));
            //Console.WriteLine(string.Format("sokak : {0}", m.Sokak));
            //Console.WriteLine(string.Format("site: {0}", m.Site));
            //Console.WriteLine(string.Format("blok : {0} ", m.Blok));
            //Console.WriteLine(string.Format("apartman : {0}", m.Bina));
            //Console.WriteLine(string.Format("kat  : {0}", m.Kat));
            //Console.WriteLine(string.Format("daire : {0}", m.Daire));
            //Console.WriteLine(string.Format("numara : {0}", m.No));
            //Console.WriteLine(string.Format("ilçe : {0}", m.Ilce));
            //Console.WriteLine(string.Format("il : {0}", m.Il));

            //Console.ReadKey();


            //            String = "MyWord,AnotherWord,TheEnd"

            //String = Regex.Replace(String, "(?<=,)(?!\\s)", " ");

            //Value of the string is now . . . . .

            //String = "MyWord, AnotherWord, TheEnd"



        }
    }
}
