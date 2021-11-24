using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PomodoroZamanlayiciLibrary;
using PomodoroZamanlayiciUI.Properties;

namespace PomodoroZamanlayiciUI
{
    public partial class FrmPomodoro : Form
    {
        private Ayarlar _ayarlar;
        private Serialize _serialize;
        private readonly Zaman _zaman;
        private FrmAyarlar _frmAyarlar;

        public FrmPomodoro()
        {
            InitializeComponent();

            _zaman = new Zaman();
        }

        private void FrmPomodoro_Load(object sender, EventArgs e)
        {
            _serialize = new Serialize();
            _ayarlar = new Ayarlar();

            AyarlarDosyasiYoksaOlustur(sender, e);

            _ayarlar = (Ayarlar) _serialize.DeserializeYukle();
        }

        private void AyarlarDosyasiYoksaOlustur(object sender, EventArgs e)
        {
            if (File.Exists("ayarlar"))
                return;

            _frmAyarlar = new FrmAyarlar(_ayarlar);
            _frmAyarlar.BtnSifirla_Click(sender, e);
            _frmAyarlar.BtnKaydet_Click(sender, e);
        }

        private void TabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ayarlar = (Ayarlar) _serialize.DeserializeYukle();

            SureleriSifirla(_ayarlar);
        }

        private void SureleriSifirla(Ayarlar ayarlar)
        {
            Dictionary<string, int> tabAdlari = new Dictionary<string, int>
            {
                {"tabPomodoro", ayarlar.Pomodoro},
                {"tabKisaAra", ayarlar.KisaAra},
                {"tabUzunAra", ayarlar.UzunAra}
            };
            TabDegerleriniAktar(tabAdlari);

            Text = ProductName;
        }

        private void TabDegerleriniAktar(Dictionary<string, int> tabAdlari)
        {
            bool zamanlayiciKapali = !timer.Enabled;
            foreach (KeyValuePair<string, int> tab in tabAdlari)
            {
                if (tabPage.SelectedTab == tabPage.TabPages[tab.Key] && zamanlayiciKapali)
                {
                    lblPomodoro.Text = tab.Value.ToString().PadLeft(2, '0') + @":00";
                    timer.Stop();
                }
            }
        }

        private void FrmPomodoro_Activated(object sender, EventArgs e)
        {
            TabPage_SelectedIndexChanged(sender, e);
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            SureAyirVeBaslat();

            SekmeleriAktifPasifYap(true);
        }

        private void SureAyirVeBaslat()
        {
            _zaman.SureyiAyir(lblPomodoro.Text);
            timer.Start();
        }

        private void SekmeleriAktifPasifYap(bool durum)
        {
            if (timer.Enabled)
                tabPage.Enabled = durum;
        }

        private void BtnDur_Click(object sender, EventArgs e)
        {
            SekmeleriAktifPasifYap(false);
            timer.Stop();
        }

        private void BtnSifirla_Click(object sender, EventArgs e)
        {
            SureleriSifirla(_ayarlar);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string geriSayim = _zaman.GeriSayimSayaci();
            
            if (geriSayim != @"00:00")
                KalanSureAktifMi(geriSayim);
            else
            {
                timer.Stop();

                AlarmCal();
                BilgilendirmeMesaji();
                SureDolduBilgilendirmesi();
                KisaArayiHemenBaslatAktif();
            }

            Text = lblPomodoro.Text;
        }

        private void KalanSureAktifMi(string geriSayim)
        {
            if (_ayarlar.KalanSure)
                Text = @"(" + geriSayim + @") " + ProductName;
            else
                Text = ProductName;

            lblPomodoro.Text = geriSayim;
        }

        private void AlarmCal()
        {
            if (!_ayarlar.AlarmCal)
                return;

            Ses ses = new Ses();
            ses.Cal();
        }

        public void BilgilendirmeMesaji()
        {
            using (NotifyIcon bilgilendirme = new NotifyIcon())
            {
                bilgilendirme.Visible = true;
                bilgilendirme.Icon = SystemIcons.Information;
                bilgilendirme.BalloonTipTitle = @"Pomodoro Zamanlayıcı";
                bilgilendirme.BalloonTipText = @"Süre doldu...";
                bilgilendirme.ShowBalloonTip(2500);
            }
        }

        private void SureDolduBilgilendirmesi()
        {
            Text = @"Süre Doldu!";
            lblPomodoro.Text = @"00:00";
        }

        private void KisaArayiHemenBaslatAktif()
        {
            if (!_ayarlar.OtomatikBaslat)
                return;

            tabPage.SelectedTab = tabPage.TabPages["tabKisaAra"];

            if (lblPomodoro.Text != @"00:00")
                SureAyirVeBaslat();
            else
                timer.Stop();
        }

        private void TsmiAyarlar_Click(object sender, EventArgs e)
        {
            _frmAyarlar = new FrmAyarlar(_ayarlar);
            _frmAyarlar.ShowDialog();
        }

        private void TsmKisayollar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Kisayollar, @"Kısayol Tuşları", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TsmGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            guncelle.VersiyonKontroluYap();
        }

        private void TsmHakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Pomodoro tekniğine uygun hazırlamaya çalıştığım basit bir sayaç bu. Elimden geldiğince her bir şeyi basitleştirmeye çalıştım. İşinizi görmesi dileğiyle.", @"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Kullanıcı kısayol tuşlarına bastıkça gerekli işlemleri tetikle
        private void FrmPomodoro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.B:
                    BtnBaslat_Click(null, null);
                    break;
                case Keys.D:
                    BtnDur_Click(null, null);
                    break;
                case Keys.S:
                    BtnSifirla_Click(null, null);
                    break;
                case Keys.P:
                    tabPage.SelectedIndex = 0;
                    break;
                case Keys.K:
                    tabPage.SelectedIndex = 1;
                    break;
                case Keys.U:
                    tabPage.SelectedIndex = 2;
                    break;
            }
        }
    }
}