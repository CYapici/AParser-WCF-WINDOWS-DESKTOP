using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using YemekSepetiFiyat.Class;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

using System.Reflection;
using System.IO;
using System.Web.UI;
using System.Net.NetworkInformation;
using System.Net;
using System.Configuration;
using System.Drawing.Drawing2D;

namespace YemekSepetiFiyat
{

    public partial class Form1 : Form
    {

        private Thread thread1 = null;
        private Thread thread2 = null;
        private Thread thread3 = null; private Thread thread4 = null;
        #region vars
        List<object> productsToDB = new List<object>();
        string recentUrl = "";
        bool searchInHistoryFlag = false;
        bool changeAddress = false;
        bool clickedABrand = false;
        string urlToSearch = "";
        DateTime dTTable = DateTime.Now;
        static string configurlS = ConfigurationManager.AppSettings.Get("urllist");
        bool DBCONNECTION = false;
        string tempReslt = "sabit";
        string[] urlListOfCompanies;
        string tempString;
        DateTime _start, _end;
        List<string> arrayHtmlToSearch = new List<string>();
        List<string> rushDownload = new List<string>();
        List<string> _pname = new List<string>();
        List<string> _pdesc = new List<string>();
        List<string> _pdate = new List<string>();
        List<string> _pcompanyname = new List<string>();
        List<string> _pchange = new List<string>();
        List<string> _pprice = new List<string>();
        IEnumerable<DataMModelLayer> dbmodel1;
        List<DataMModelLayer> mycompareData;
        bool firstTie = false;
        List<string> urlListDownloads = new List<string>();
        bool finishedDownloadingUrl = false;

        #endregion

        public Form1()
        {

            InitializeComponent();
            Shown += Form1_Shown;

        }

        public void showMessageForStartUp()
        {

            while (true)
            {
                string result = MyMessageBox.ShowBox("Bağlantılar Kontrol Ediliyor ...", "Lütfen bekleyiniz");
            }


        }
        public void pleaseWaitMessage()
        {

            while (true)
            {
                string result = MyMessageBox.ShowBox("Lütfen Bekleyiniz ...", "-");
            }


        }
        public void showMessage()
        {

            while (true)
            {
                string result = MyMessageBox.ShowBox("Veritabanına Bağlanılıyor Lütfen Bekleyiniz ...", "-");
            }


        }

        public void GenerateTheurlList()
        {
            using (BusinessLayer cs = new BusinessLayer())
            {
                try
                {


                    mycompareData = cs.getByNameOrDate("", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1, 0, 0, 0), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1, 23, 55, 55), true).ToList();


                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }


            thread2.Abort();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if ((thread2.ThreadState & ThreadState.Running) == ThreadState.Running)
            //    thread2.Abort();

            //thread2 = null;

            //if ((thread1.ThreadState & ThreadState.Running) == ThreadState.Running)
            //    thread1.Abort();

            //thread1 = null;
        }

        private void rushCheck()
        {
            urlListDownloads.Clear();

            int i = 0;
            foreach (var item in urlListOfCompanies)
            {

                changeAddress = false;
                string s;
                try
                {
                    using (WebClient _theClient = new WebClient())
                    {
                        s = _theClient.DownloadString(item) + "";
                    }



                }
                catch (Exception)
                {

                    s = "";
                }


                var splittedproducts = s.Split(new string[] { "<div class=\"rmd_product\"" }, StringSplitOptions.RemoveEmptyEntries);

                if (splittedproducts.Length <= 1)
                {
                    changeAddress = true;
                    tempString = item;
                    rushDownload.Add(s);
                    urlListDownloads.Add(s);
                }

                else
                {
                    urlListDownloads.Add(s);
                    rushDownload.Add(s);
                }


                if (changeAddress)
                {
                    string tempS = findCOmpanyFromAddress(tempString, true);

                    urlListOfCompanies[i] = tempS; string ro1 = "";
                    using (WebClient _theClient = new WebClient())
                    {
                        ro1 = _theClient.DownloadString(tempS) + "";
                    }
                    urlListDownloads.Add(ro1);
                    rushDownload.Add(ro1);

                    changeAddress = false;

                }
                i++;

            }


        }

        private bool addressCheck()
        {
            urlListDownloads.Clear();

            int i = 0;
            foreach (var item in urlListOfCompanies)
            {

                changeAddress = false;
                string s;
                try
                {
                    using (WebClient _theClient = new WebClient())
                    {
                        s = _theClient.DownloadString(item) + "";
                    }



                }
                catch (Exception)
                {

                    s = "";
                }


                var splittedproducts = s.Split(new string[] { "<div class=\"rmd_product\"" }, StringSplitOptions.RemoveEmptyEntries);

                if (splittedproducts.Length <= 1)
                {
                    changeAddress = true;
                    tempString = item;
                    rushDownload.Add(s);
                    urlListDownloads.Add(s);
                }

                else
                {
                    urlListDownloads.Add(s);
                    rushDownload.Add(s);
                }


                if (changeAddress)
                {
                    string tempS = findCOmpanyFromAddress(tempString, true);

                    urlListOfCompanies[i] = tempS; string ro1 = "";
                    using (WebClient _theClient = new WebClient())
                    {
                        ro1 = _theClient.DownloadString(tempS) + "";
                    }
                    urlListDownloads.Add(ro1);
                    rushDownload.Add(ro1);
                    changeAddress = false;

                }
                i++;

            }

            return true;
        }

        private string findCOmpanyFromAddress(string url, bool returnCompanyUrl)
        {
            if (returnCompanyUrl)
            {
                if (url.Contains("Burger-King"))
                {
                    return "http://istanbul.yemeksepeti.com/TR/Restoran/Burger-King_-Bahariye/216fa3fd-0b40-4f0b-8748-2de9ce7c80ff/TR_ISTANBUL/m.ys";
                }
                if (url.Contains("Kentucky-Fried-Chicken"))
                {
                    return "http://istanbul.yemeksepeti.com/TR/Restoran/Kentucky-Fried-Chicken_-Sahrayicedid/ba786c2e-7a5e-4a53-af97-286a55f7f306/TR_ISTANBUL/m.ys";
                }
                if (url.Contains("McDonalds"))
                {
                    return "http://istanbul.yemeksepeti.com/TR/Restoran/McDonalds_-Okmeydani/a51e7fca-8274-4b42-a430-43429f8e0b8b/TR_ISTANBUL/m.ys";
                }
                if (url.Contains("Popeyes"))
                {
                    return "http://istanbul.yemeksepeti.com/TR/Restoran/Popeyes_-Bostanci-(Paragon)/19a5b562-e09d-40b9-bf32-b967f7081a6b/TR_ISTANBUL/m.ys";
                }
                if (url.Contains("Pizza-Hut"))
                {
                    return "http://istanbul.yemeksepeti.com/TR/Restoran/Pizza-Hut_-Atasehir/6aa76160-a86d-4aa6-8e44-0b415c755c6a/TR_ISTANBUL/m.ys";
                }
                if (url.Contains("Papa-Johns-Pizza"))
                {
                    return "http://istanbul.yemeksepeti.com/TR/Restoran/Papa-Johns-Pizza_-Kavacik/a358c4fc-0e3e-4087-a3ef-20186d9f755f/TR_ISTANBUL/m.ys";
                }
                if (url.Contains("Pizza-Pizza"))
                {
                    return "http://istanbul.yemeksepeti.com/TR/Restoran/Pizza-Pizza-Delivery_-Kayisdagi-(Inonu-Mahn)/1145fe2f-06fc-4860-b35c-ba95c2808b0b/TR_ISTANBUL/m.ys";
                }
                if (url.Contains("Pizza-Bulls"))
                {
                    return "http://istanbul.yemeksepeti.com/TR/Restoran/Pizza-Bulls_-Merdivenkoy/3101ff1f-e8aa-4387-b321-11e555f2bcb7/TR_ISTANBUL/m.ys";
                }
                if (url.Contains("Little-Caesars"))
                {
                    return "http://istanbul.yemeksepeti.com/TR/Restoran/Little-Caesars-Pizza_-Ikitelli/1a5645ab-08b5-481e-85ae-9345f2ff1ad2/TR_ISTANBUL/m.ys";
                }
                else
                {
                    return "";
                }
            }

            else
            {


                if (url.Contains("Burger-King"))
                {
                    return "Burger-King";
                }
                if (url.Contains("Kentucky-Fried-Chicken"))
                {
                    return "Kentucky-Fried-Chicken";
                }
                if (url.Contains("McDonalds"))
                {
                    return "McDonalds";
                }
                if (url.Contains("Popeyes"))
                {
                    return "Popeyes";
                }
                if (url.Contains("Pizza-Hut"))
                {
                    return "Pizza-Hut";
                }
                if (url.Contains("Papa-Johns-Pizza"))
                {
                    return "Papa-Johns-Pizza";
                }
                if (url.Contains("Pizza-Pizza"))
                {
                    return "Pizza-Pizza";
                }
                if (url.Contains("Pizza-Bulls"))
                {
                    return "Pizza-Bulls";
                }
                if (url.Contains("Little-Caesars"))
                {
                    return "Little-Caesars";
                }
                else
                {
                    return "Firma1";
                }
            }
        }
        private string findCOmpanyFromurl(string url)
        {


            if (url.Contains("Burger King"))
            {
                return "Burger-King";
            }
            if (url.Contains("Kentucky Fried Chicken"))
            {
                return "Kentucky-Fried-Chicken";
            }
            if (url.Contains("McDonald's"))
            {
                return "McDonalds";
            }
            if (url.Contains("Popeyes"))
            {
                return "Popeyes";
            }
            if (url.Contains("Pizza Hut"))
            {
                return "Pizza-Hut";
            }
            if (url.Contains("Papa John's Pizza"))
            {
                return "Papa-Johns-Pizza";
            }
            if (url.Contains("Pizza Pizza"))
            {
                return "Pizza-Pizza";
            }
            if (url.Contains("Pizza Bulls"))
            {
                return "Pizza-Bulls";
            }
            if (url.Contains("Little Caesars Pizza"))
            {
                return "Little-Caesars";
            }
            else
            {
                return "Firma1";
            }

        }
        private void trydbCon()
        {
            var connectionString = "mongodb://192.168.202.42:27017/";
            var client = new MongoClient(connectionString);
            try
            {
                client.GetServer().Ping();
                DBCONNECTION = true;
            }
            catch (Exception)
            {

                DBCONNECTION = false;
            }


        }

        private void Form1_Shown(Object sender, EventArgs e)
        {

            thread1 = new Thread(new ThreadStart(showMessageForStartUp));
            thread1.IsBackground = true;


            thread1.Start();
            trydbCon();


            thread1.Abort();






        }

        private void settingTheDefaults()
        {
            start.MinDate = new DateTime(Convert.ToInt32(DateTime.Now.Year), 1, 1);
            start.MaxDate = DateTime.Now.AddDays(-1.0);

            end.MinDate = new DateTime(Convert.ToInt32(DateTime.Now.Year), 1, 1);
            end.MaxDate = DateTime.Today;
            urlListOfCompanies = configurlS.Split(',');

            thread2 = new Thread(new ThreadStart(GenerateTheurlList));
            thread2.Start();







        }

        private void Form1_Load(object sender, EventArgs e)
        {

            settingTheDefaults();

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false;
            if (txtUrl.Text == "")
            {
                return;
            }

            GetProducts(txtUrl.Text + "", "", false, false, false);
        }

        private void GetProducts(string url, string searchInput, bool searchAll, bool buttonSearchFilterOption, bool companyCLicked)
        {
            if (!firstTie)
            {
                thread4 = new Thread(new ThreadStart(pleaseWaitMessage));
                thread4.IsBackground = true;

                thread4.Start();

                addressCheck();
                thread4.Abort();
                firstTie = true;
            }


            recentUrl = url + "";
            Application.DoEvents();

            dgvProducts.Rows.Clear();

            Cursor.Current = Cursors.WaitCursor;

            if (companyCLicked)
            {
                arrayHtmlToSearch = new List<string>();
                foreach (var item in urlListDownloads)
                {
                    if (item.Contains(findCOmpanyFromAddress(recentUrl, false)))
                    {
                        arrayHtmlToSearch.Add(item);
                    }

                }
            }

            if (searchAll && finishedDownloadingUrl)
            {
                arrayHtmlToSearch = urlListDownloads;


            }
            if (searchAll && !finishedDownloadingUrl)
            {

                arrayHtmlToSearch = rushDownload;


            }




            foreach (var item1 in arrayHtmlToSearch)
            {

                string s = item1;

                string mycompany = findCOmpanyFromAddress(s, false);
                string searchCOmpany = findCOmpanyFromurl(item1);
                var splittedproducts = s.Split(new string[] { "<div class=\"rmd_product\"" }, StringSplitOptions.RemoveEmptyEntries);

                prgGetPrice.Maximum = splittedproducts.Length;
                prgGetPrice.Value = 1;


                foreach (var item in splittedproducts.Skip(1))
                {
                    prgGetPrice.Value++;
                    var productDetail = item;
                    var productNameSplitArr = productDetail.Split(new string[] { "<a id=\"AddToBasketHyperLink\"" }, StringSplitOptions.RemoveEmptyEntries);
                    var prodName = productNameSplitArr[0].Split(new string[] { "class=\"productName\">" }, StringSplitOptions.RemoveEmptyEntries)[1];
                    prodName = prodName.Substring(0, prodName.IndexOf("</a>"));

                    prodName = GetTurkish(prodName);
                    var prodDesc = productNameSplitArr[0].Split(new string[] { "<span class=\"productDescription\">" }, StringSplitOptions.RemoveEmptyEntries)[1];
                    prodDesc = prodDesc.Substring(0, prodDesc.IndexOf("</span>"));

                    prodDesc = GetTurkish(prodDesc);

                    var prodPrice = productNameSplitArr[0].Split(new string[] { "class=\"pv_new\">" }, StringSplitOptions.RemoveEmptyEntries)[1];
                    prodPrice = prodPrice.Substring(0, prodPrice.IndexOf("</span>"));



                    if (DBCONNECTION)
                    {
                        tempReslt = comparePrices(prodName.ToString(), prodPrice.ToString(), findCOmpanyFromAddress(url, false));
                    }



                    //if clicked by buttons no filter will be used


                    if (!buttonSearchFilterOption)
                    {
                        if (tempReslt == "artis")
                        {
                            try
                            {

                                object[] row = new object[] { up, findCOmpanyFromAddress(recentUrl, false), prodPrice, prodName, prodDesc, dTTable.ToShortDateString() };
                                dgvProducts.Rows.Add(row);
                            }
                            catch (Exception es)
                            {

                                //
                            }
                        }
                        if (tempReslt == "azalis")
                        {
                            try
                            {

                                object[] row = new object[] { down, findCOmpanyFromAddress(recentUrl, false), prodPrice, prodName, prodDesc, dTTable.ToShortDateString() };
                                dgvProducts.Rows.Add(row);
                            }
                            catch (Exception es)
                            {

                                //
                            }
                        }
                        if (tempReslt == "sabit" || tempReslt == "")
                        {
                            try
                            {

                                object[] row = new object[] { same, findCOmpanyFromAddress(recentUrl, false), prodPrice, prodName, prodDesc, dTTable.ToShortDateString() };
                                dgvProducts.Rows.Add(row);
                            }
                            catch (Exception es)
                            {

                                //
                            }
                        }
                    }




                    else                                                   //arama varsa
                    {


                        if (prodName.ToLower().ToString().Contains(searchInput.ToLower() + ""))
                        {


                            if (tempReslt == "artis")
                            {
                                object[] row = new object[] { up, searchCOmpany, prodPrice, prodName, prodDesc, dTTable.ToShortDateString() };
                                dgvProducts.Rows.Add(row);
                            }
                            if (tempReslt == "azalis")
                            {
                                object[] row = new object[] { down, searchCOmpany, prodPrice, prodName, prodDesc, dTTable.ToShortDateString() };
                                dgvProducts.Rows.Add(row);
                            }
                            if (tempReslt == "sabit")
                            {
                                object[] row = new object[] { same, searchCOmpany, prodPrice, prodName, prodDesc, dTTable.ToShortDateString() };
                                dgvProducts.Rows.Add(row);
                            }
                        }
                    }
                }





                Cursor.Current = Cursors.Default;

            }
        }

        private string moneyTagCorrectorRemoveTL(string input)
        {

            return input.Replace("tl", "").Replace("Tl", "").Replace("TL", "").Replace(" ", "");
        }

        private string GetTurkish(string english)
        {

            return english.Replace("ÅŸ", "ş").
                Replace("Ä±", "ı").
                Replace("Ã¼", "ü").
                Replace("Ãœ", "Ü").
                Replace("Ã‡", "Ç").
                Replace("Ä°", "İ").
                Replace("Ã§", "ç").
                Replace("Å", "Ş").
                Replace("Ã¶", "ö").
                Replace("ÄŸ", "ğ").
                Replace("Ã–", "Ö").
                Replace("&nbsp;", "");
        }

        private void btnBurgerKing_Click(object sender, EventArgs e)
        {

            clickedABrand = true;
            searchInHistoryFlag = false; btnSearch.Text = "Ara";
            btnRemoveHistory.Visible = false;
            GetProducts(urlListOfCompanies[1], "", false, false, true);



        }

        private void btnMcDonalds_Click(object sender, EventArgs e)
        {
            clickedABrand = true;
            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false;
            GetProducts(urlListOfCompanies[0], "", false, false, true);

        }

        private void btnKFC_Click(object sender, EventArgs e)
        {
            clickedABrand = true;
            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false;
            GetProducts(urlListOfCompanies[2], "", false, false, true);


        }

        private void btnLittleCeasers_Click(object sender, EventArgs e)
        {
            clickedABrand = true;
            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false;
            GetProducts(urlListOfCompanies[3], "", false, false, true);

        }

        private void btnPopeyes_Click(object sender, EventArgs e)
        {
            clickedABrand = true;
            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false;
            GetProducts(urlListOfCompanies[4], "", false, false, true);

        }

        private void btnPizzaHut_Click(object sender, EventArgs e)
        {
            clickedABrand = true;
            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false;

            GetProducts(urlListOfCompanies[5], "", false, false, true);

        }

        private void btnPapaJohn_Click(object sender, EventArgs e)
        {
            clickedABrand = true;
            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false;
            GetProducts(urlListOfCompanies[6], "", false, false, true);

        }

        private void btnPizzaPizza_Click(object sender, EventArgs e)
        {
            clickedABrand = true;
            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false;
            GetProducts(urlListOfCompanies[7], "", false, false, true);

        }

        private void btnPizzaBulls_Click(object sender, EventArgs e)
        {
            clickedABrand = true;
            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false;
            GetProducts(urlListOfCompanies[8], "", false, false, true);

        }

        //girilen ürün adı ve yeni fiyat eskiye bakacak
        private string comparePrices(string productName, string newproductPrice, string companyName)
        {



            if (mycompareData == null)
            {
                return "artis";
            }
            else
            {
                
                
              

                try
                {
                    if (  (Convert.ToDouble( mycompareData.Where(p => p.productName == productName && p.productCompanyName == companyName).FirstOrDefault().productPrice) > Convert.ToDouble(moneyTagCorrectorRemoveTL(newproductPrice))))
                    {
                        return "artis";
                    }

                    if (  (Convert.ToDouble( mycompareData.Where(p => p.productName == productName && p.productCompanyName == companyName).FirstOrDefault().productPrice) < Convert.ToDouble(moneyTagCorrectorRemoveTL(newproductPrice))))
                    {
                        return "azalis";
                    }

                    else return "sabit";
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }

        }

        // custom data göndermek istiyorsak dbmodeli numerable olarak data gönderiyoruz-- diğer tüm implementasyonlarda default olarak null değeri yolluyoruz
        private void printheTheGridFromDB(IEnumerable<DataMModelLayer> dbmodel)
        {

            if (dbmodel != null)
            {
                Application.DoEvents();

                dgvProducts.Rows.Clear();

                Cursor.Current = Cursors.WaitCursor;


                var dataFromDB = dbmodel.OrderBy(p => p.productName).ToList();

                dbmodel1 = dataFromDB;



                foreach (var item in dataFromDB)
                {


                    if (item.changedPriceField == "artis")
                    {
                        object[] row = new object[] { up, item.productCompanyName, item.productPrice, item.productName, item.productDescription, item.archiveDateAdded };
                        dgvProducts.Rows.Add(row);
                    }

                    if (item.changedPriceField == "azalis")
                    {
                        object[] row = new object[] { down, item.productCompanyName, item.productPrice, item.productName, item.productDescription, item.archiveDateAdded };
                        dgvProducts.Rows.Add(row);
                    }

                    else
                    {
                        try
                        {

                            object[] row = new object[] { same, item.productCompanyName, item.productPrice, item.productName, item.productDescription, item.archiveDateAdded.ToString() };
                            dgvProducts.Rows.Add(row);


                        }
                        catch (Exception c)
                        {

                            throw c;
                        }

                    }


                }

                Cursor.Current = Cursors.Default;
            }




        }

        private void addimages()
        {


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            //GE.MIŞTE ARAMA
            if (searchInHistoryFlag)
            {
                globalClass.dataProperty = "gecmisarama";

                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Arama Alanı Boş Olamaz");
                }
                else
                {
                    globalClass.searchKeyword = txtSearch.Text.ToLower() + "";

                    using (BusinessLayer cs = new BusinessLayer())
                    {
                        var prod = cs.getByNameOrDate(txtSearch.Text.ToLower() + "", DateTime.Now, DateTime.Now, false);

                        printheTheGridFromDB(prod);

                    }



                }

            }


                           //RECENT SEARCH
            else
            {   //IF not CLICKED A BRAND
                if (!clickedABrand)
                {

                    //boşsa
                    if (txtSearch.Text == "")
                    {
                        lblRessult.Visible = true;
                        getAllByLetter();
                        globalClass.dataProperty = "guncelarama";
                        globalClass.searchKeyword = txtSearch.Text.ToLower() + "";
                        lblRessult.Visible = false;

                    }



//doluysa
                    else
                    {

                        lblRessult.Visible = true;
                        globalClass.dataProperty = "guncelarama";
                        globalClass.searchKeyword = txtSearch.Text.ToLower() + "";

                        GetProducts("", GetTurkish(txtSearch.Text), true, true, false);
                        lblRessult.Visible = false;
                    }



                }

                    // MARKA  ARAMA YAPILMISSA
                else
                {
                    if (txtSearch.Text != "")
                    {
                        globalClass.dataProperty = "guncelarama";
                        globalClass.searchKeyword = txtSearch.Text.ToLower() + "";
                        GetProducts("" + recentUrl, GetTurkish(txtSearch.Text), true, true, true);
                    }

                    else
                    {
                        MessageBox.Show("Arama Alanı Boş Bırakılamaz.");
                    }
                }
            }


        }

        private void getAllByLetter()
        {
            dgvProducts.Rows.Clear();

            foreach (var item in urlListOfCompanies)
            {
                GetProducts(item.ToString(), GetTurkish(txtSearch.Text), true, true, false);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {




            if (_start < DateTime.Now)
            {
                _start = new DateTime(start.Value.Year, start.Value.Month, start.Value.Day, 23, 23, 23);
            }
            else
            {
                MessageBox.Show("Lütfen Arşivden Bir Gün Seçiniz.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DBCONNECTION)
            {
                searchInHistoryFlag = true; btnSearch.Text = "Arşivde Ara"; btnRemoveHistory.Visible = true;




                searchInHistoryFlag = true;

                thread3 = new Thread(new ThreadStart(pleaseWaitMessage));
                thread3.IsBackground = true;

                thread3.Start();

                using (BusinessLayer cs = new BusinessLayer())
                {
                    var prod = cs.getByNameOrDate("", _start, _end, true); //tar,he gore getirme
                    printheTheGridFromDB(prod);
                }

                thread3.Abort();

            }


        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void end_ValueChanged(object sender, EventArgs e)
        {
            if (_end == _start)
            {
                MessageBox.Show("Tarihler Aynı Gün Olamaz.");
            }
            if (_end < DateTime.Now)
            {
                _end = new DateTime(end.Value.Year, end.Value.Month, end.Value.Day, 23, 23, 23);
            }


        }

        private void btnRemoveHistory_Click(object sender, EventArgs e)
        {
            searchInHistoryFlag = false; btnSearch.Text = "Ara"; btnRemoveHistory.Visible = false; btnRemoveHistory.Visible = false;
        }

        private void collabrateLists(string pName, string pPrice, string pDescription, string pDate, string pCompanyName, string pChange, bool finalSave)
        {
            if (searchInHistoryFlag || recentUrl == "")
            {
                _pcompanyname = dbmodel1.Select(p => p.productCompanyName).ToList();

            }

            if (!finalSave)
            {

                _pname.Add(pName); _pprice.Add(pPrice); _pdesc.Add(pDescription); _pdate.Add(pDate); _pcompanyname.Add(pCompanyName); _pchange.Add(pChange);

            }


            else
            {

                try
                {
                    officeHelper oH = new officeHelper();




                    if (_pcompanyname.First().ToString() == "Firma1" && searchInHistoryFlag && (pDate != new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString()))
                    {
                        _pcompanyname = dbmodel1.Select(p => p.productCompanyName).ToList();

                    }

                    oH.excel(_pname, _pdesc, _pprice, _pcompanyname, _pdate, _pchange);
                    MessageBox.Show("YS Excel Çıktısı C: Sürücüne Başarıyla Kaydedildi");
                }
                catch (Exception)
                {


                }


            }




        }

        private void excelFormat()
        {

            _pname = new List<string>(); _pdesc = new List<string>(); _pprice = new List<string>(); _pdate = new List<string>(); _pcompanyname = new List<string>(); _pchange = new List<string>();
            _pname.Add("Ürün Adı"); _pprice.Add("Fiyat"); _pdesc.Add("Detay"); _pdate.Add("Tarih"); _pcompanyname.Add("Firma"); _pchange.Add("");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            excelFormat();
            lblRessult.Text = "     ***Excel Çıktı hazırlanıyor bekleyiniz."; lblRessult.Visible = true;


            if (dgvProducts.Rows.Count != 0)
            {

                prgGetPrice.Maximum = dgvProducts.Rows.Count + 50;
                prgGetPrice.Value = 1;



                foreach (DataGridViewRow row in dgvProducts.Rows)
                {

                    string prodCOmpany = row.Cells[1].Value.ToString();
                    string prodPrice = row.Cells[2].Value.ToString();
                    string prodName = row.Cells[3].Value.ToString();
                    string prodDesc = row.Cells[4].Value.ToString();
                    string prodDate = row.Cells[5].Value.ToString();



                    collabrateLists(prodName, prodPrice.ToString(), prodDesc.ToString(), prodDate + "", prodCOmpany.ToString(), "-", false);

                    int c = 12;

                    prgGetPrice.Value++;
                }

                collabrateLists("", "", "", "", "", "-", true);


            }

            lblRessult.Visible = false; lblRessult.Text = "     ***Sonuçlar internetten tüm firmalarda aranıyor.";
            prgGetPrice.Value = 0;
        }

        private void myAPP_Paint(object sender, PaintEventArgs e)
        {
            Graphics mGraphics = e.Graphics;
            Pen pen1 = new Pen(Color.FromArgb(255, 255, 255), 1);

            Rectangle Area1 = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush LGB = new LinearGradientBrush(Area1, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mGraphics.FillRectangle(LGB, Area1);
            mGraphics.DrawRectangle(pen1, Area1);
        }
    }



}
