using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace PomodoroZamanlayiciLibrary
{
    public class Guncelle
    {
        private XmlReader _xmlOku;

        public void VersiyonKontroluYap()
        {
            if (Baglanti.InternetVarMi())
                WebXmlBaglanti();
        }

        private void WebXmlBaglanti()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            WebIstem();
            WebXmlOku();
        }

        private void WebIstem()
        {
            string guncellemeLinki = @"https://raw.githubusercontent.com/Umut-D/umutd.com/master/assets/program-versions/pomodoro-zamanlayici.xml";
            using (WebClient webIstemcisi = new WebClient())
            {
                Stream akis = webIstemcisi.OpenRead(guncellemeLinki);
                if (akis != null)
                    _xmlOku = XmlReader.Create(akis);
            }
        }

        private void WebXmlOku()
        {
            while (_xmlOku.Read())
            {
                if (_xmlOku.NodeType != XmlNodeType.Element || _xmlOku.Name != "pomodoro" || !_xmlOku.HasAttributes)
                    continue;

                VersiyonlariKarsilastir();
            }
        }

        private void VersiyonlariKarsilastir()
        {
            if ("1.03" == SunucudakiVersiyon())
                MessageBox.Show(@"Program günceldir. Yenisi çıkana kadar şimdilik en iyisi bu.", @"Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DialogResult diyalog = MessageBox.Show($@"Yeni bir güncelleme var. Programı {SunucudakiVersiyon()} versiyonuna yükselttim. Web sayfasına girip indirmek ister misiniz?", @"Güncelle", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (diyalog == DialogResult.OK)
                    Process.Start("http://www.umutd.com/programlar/pomodoro-zamanlayici");
            }
        }

        private string SunucudakiVersiyon()
        {
            return _xmlOku.GetAttribute("version");
        }
    }
}