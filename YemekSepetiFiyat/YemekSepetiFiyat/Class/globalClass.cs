using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NsExcel = Microsoft.Office.Interop.Excel;

namespace YemekSepetiFiyat.Class
{
    public static class globalClass
    {


        public static List<string> name { get; set; }

        public static List<string> description { get; set; }

        public static List<string> price { get; set; }

        public static List<string> date { get; set; }

        public static List<string> changeStu { get; set; }

        public static List<string> company { get; set; }

        public static string dataProperty { get; set; }

        public static string searchKeyword { get; set; }

      

    }

    

}
