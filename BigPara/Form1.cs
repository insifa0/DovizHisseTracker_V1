using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;
using System.Windows.Forms;
using HtmlAgilityPack;
using static System.Net.WebRequestMethods;

namespace BigPara
{
    public partial class Form1 : Form
    {
        HtmlWeb htmlWeb = new HtmlWeb();
        HtmlWeb htmlHisse = new HtmlWeb();
        public Form1()
        {
            InitializeComponent();
        }

        private static string dolarAlisXpath = "//td[@data-socket-key='USD'][1]"; // XPath ifadesi
        private static string dolarSatisXpath = "//td[@data-socket-key='USD'][2]";

        List<BigParaClass> dovizler = new List<BigParaClass>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlAgilityPack.HtmlDocument document = htmlWeb.Load("https://kur.doviz.com/");

                // XPath ifadelerini kullanarak
                var dolarAlisNode = document.DocumentNode.SelectSingleNode(dolarAlisXpath);
                var dolarSatisNode = document.DocumentNode.SelectSingleNode(dolarSatisXpath);

                // Elemanlarýn null olup olmadýðýný kontrol et
                if (dolarAlisNode != null && dolarSatisNode != null)
                {
                    var dolarAlis = dolarAlisNode.InnerText;
                    var dolarSatis = dolarSatisNode.InnerText;

                    label2.Text = dolarAlis + " TL";
                    label3.Text = dolarSatis + " TL";
                }
                else
                {
                    MessageBox.Show("Belirtilen XPath ifadesine uygun eleman bulunamadý.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}");
            }
        }


        //private static string hisseAdiXpath = "//td[@data-socket-key='USD'][1]"; // XPath ifadesi
        //private static string hisseFiyatiXpath = "//span[@class='last-JWoJqCpY js-symbol-last']/span";
        //private static string hisseFiyatiXpath = "//div['@lastContainer-JWoJqCpY']/span[1]/span[1]";

        //<div class="text-5xl/9 font-bold md:text-[42px] md:leading-[60px] text-[#232526]" data-test="instrument-price-last">381,00</div>
        //<td class="text-bold" data-socket-key="USD" data-socket-attr="bid" data-socket-animate="true" data-socket-animate-active="1" data-previous-value="30.3375" style="" xpath="1">30,3375</td>

        //NOT:Siteden veri çekiliyor sýkýntý yok.
        //private static string hisseFiyatiXpath = "//div[@class='bottom']//div[2]//span[1]";
        //private static string hisseFiyatiXpath = "(//span[@id='hisse_Son'])[1]";
        //private static string hisseFiyatiXpath = "//span[@id='hisse_Son']"
        //private static string hisseFiyatiXpath = "//span[@class='value']"; hürriyet borsa
        //private static string hisseFiyatiXpath = "//span[@class='inline-flex items-center tabular-nums'][1]"; // fintables
        private static string hisseFiyatiXpath = "//div[@class='D(ib) Mend(20px)']//fin-streamer[@data-field='regularMarketPrice']";//finance.yahoo 
        List<Hisse> hisseler = new List<Hisse>();


        private void btnHisseGetir_Click(object sender, EventArgs e)
        {   
            string hisseAdi = textBox2.Text.ToUpper();
            try
            {
                //https://fintables.com/sirketler/KBORU bu siteyi dene hisse almasý daha kolay gibi
                //HtmlAgilityPack.HtmlDocument document = htmlHisse.Load("https://www.isyatirim.com.tr/tr-tr/analiz/hisse/Sayfalar/sirket-karti.aspx?hisse=BIMAS");
                //HtmlAgilityPack.HtmlDocument document = htmlHisse.Load("https://bigpara.hurriyet.com.tr/borsa/hisse-fiyatlari/bimas-bim-magazalar-detay/genel/gunici/");
                /*string hisseSiteAdi = "https://fintables.com/sirketler/" + hisseAdi;
                 MessageBox.Show(hisseSiteAdi);
                 HtmlAgilityPack.HtmlDocument document = htmlHisse.Load("https://fintables.com/sirketler/BIMAS");
                */
                string hisseSiteAdi = "https://finance.yahoo.com/quote/" + hisseAdi + ".IS?p=" + hisseAdi + ".IS&.tsrc=fin-srch";
                MessageBox.Show(hisseSiteAdi, "The Website URL");
                HtmlAgilityPack.HtmlDocument document = htmlHisse.Load(hisseSiteAdi);

                // XPath ifadelerini kullanarak
                var hisseFiyatNode = document.DocumentNode.SelectSingleNode(hisseFiyatiXpath).InnerText;
                MessageBox.Show(hisseFiyatNode, "The Stock Price");

                // Elemanlarýn null olup olmadýðýný kontrol et
                if (hisseFiyatNode != null)
                {
                    Debug.WriteLine($"Dolar Alýþ: {hisseFiyatNode} TL");
                    string hisseFiyati = hisseFiyatNode;
                    label6.Text = hisseFiyatNode.ToString();

                    lblHisseFiyati.Text = hisseAdi + ": " + hisseFiyati + " TL";
                }
                else
                {
                    MessageBox.Show("Belirtilen XPath ifadesine uygun eleman bulunamadý.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                if (hisseAdi == "")
                {
                    MessageBox.Show("You forgot to write the name of the stock!");
                }
                else {
                    MessageBox.Show($"Bir hata oluþtu: {ex.Message}");
                }                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This proje created by insif0", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void euroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // I will make this code later.
        }
    }
}
