using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace YemekSepetiFiyat.Class
{
    class officeHelper
    {

        public void excel(List<string> pName, List<string> pDesc, List<string> pPrice, List<string> companyName, List<string> Date, List<string> changedPrice)
        {
            try
            {
                Excel._Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                #region workshop
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                pName.Distinct().ToList();
                pName.RemoveAll(String.IsNullOrEmpty);
                pDesc.Distinct().ToList();
                pDesc.RemoveAll(String.IsNullOrEmpty);
                pPrice.Distinct().ToList();
                pPrice.RemoveAll(String.IsNullOrEmpty);
                companyName.Distinct().ToList();
                companyName.RemoveAll(String.IsNullOrEmpty);
                Date.Distinct().ToList();
                Date.RemoveAll(String.IsNullOrEmpty);
                #endregion


                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //xlWorkSheet.Cells[1, 1] = "http://csharp.net-informations.com";

                for (int i = 0; i < pName.Count; i++)
                {
                    xlApp.Cells[i + 1, 1] = pName[i];
                }
                for (int i = 0; i < companyName.Count; i++)
                {
                    xlApp.Cells[i + 1, 2] = companyName[i];
                }
                for (int i = 0; i < pPrice.Count; i++)
                {
                    xlApp.Cells[i + 1, 3] = pPrice[i];
                }
                for (int i = 0; i < pDesc.Count; i++)
                {
                    xlApp.Cells[i + 1, 4] = pDesc[i];
                }
                for (int i = 0; i < Date.Count; i++)
                {
                    xlApp.Cells[i + 1, 5] = Date[i];
                }
                for (int i = 0; i < changedPrice.Count; i++)
                {
                    xlApp.Cells[i + 1, 6] = changedPrice[i];
                }
                var path1 = "C:\\" + "ys_fiyat_ciktisi_" + ".xls";

                xlWorkBook.SaveAs(path1, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                xlWorkBook.Close(true, misValue, misValue);

                xlApp.Quit();


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


    }
}
