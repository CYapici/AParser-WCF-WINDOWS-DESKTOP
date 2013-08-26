using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Uri ur = new Uri("https://secure.sahibinden.com/giris/?return_url=%2Findex.php");
            //this.webBrowser1.Url = ur;
            //dynamic doc = this.webBrowser1.Document;

            //MessageBox.Show(doc.body.outerHtml);

            webBrowser1.Url = new Uri("https://secure.sahibinden.com/giris/?return_url=%2Findex.php");
            webBrowser1.Document.GetElementById("username").SetAttribute("value", "cagatayyapici@windowslive.com");
            webBrowser1.Document.GetElementById("password").SetAttribute("value", "kemence85");

        }
    }
}
