using System;
using System.Windows.Forms;
using PomodoroZamanlayiciLibrary;

namespace PomodoroZamanlayiciUI
{
    public partial class FrmAyarlar : Form
    {
        private readonly Ayarlar _ayarlar;

        public FrmAyarlar(Ayarlar ayarlar)
        {
            InitializeComponent();

            _ayarlar = ayarlar;
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            clBoxTercihler.SetItemChecked(0, _ayarlar.KalanSure);
            clBoxTercihler.SetItemChecked(1, _ayarlar.AlarmCal);
            clBoxTercihler.SetItemChecked(2, _ayarlar.OtomatikBaslat);

            nudPomodoro.Value = _ayarlar.Pomodoro;
            nudKisaAra.Value = _ayarlar.KisaAra;
            nudUzunAra.Value = _ayarlar.UzunAra;
        }

        public void BtnKaydet_Click(object sender, EventArgs e)
        {
            Serialize serialize = new Serialize();
            serialize.SerializeKaydet(AyarTercihleriniAl());

            Close();
        }

        private Ayarlar AyarTercihleriniAl()
        {
            _ayarlar.KalanSure = clBoxTercihler.GetItemChecked(0);
            _ayarlar.AlarmCal = clBoxTercihler.GetItemChecked(1);
            _ayarlar.OtomatikBaslat = clBoxTercihler.GetItemChecked(2);

            _ayarlar.Pomodoro = (int)nudPomodoro.Value;
            _ayarlar.KisaAra = (int)nudKisaAra.Value;
            _ayarlar.UzunAra = (int)nudUzunAra.Value;

            return _ayarlar;
        }

        public void BtnSifirla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                clBoxTercihler.SetItemChecked(i, false);

            nudPomodoro.Value = 25;
            nudKisaAra.Value = 5;
            nudUzunAra.Value = 10;
        }
    }
}