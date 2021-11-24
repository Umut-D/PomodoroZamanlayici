using System;

namespace PomodoroZamanlayiciLibrary
{
    [Serializable]
    public class Ayarlar
    {
        public bool KalanSure { get; set; }
        public bool AlarmCal { get; set; }
        public bool OtomatikBaslat { get; set; }
        public int Pomodoro { get; set; }
        public int KisaAra { get; set; }
        public int UzunAra { get; set; }
    }
}