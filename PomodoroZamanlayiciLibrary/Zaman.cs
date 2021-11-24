using System;

namespace PomodoroZamanlayiciLibrary
{
    public class Zaman
    {
        private int _dakika;
        private int _saniye;

        public void SureyiAyir(string zaman)
        {
            string[] sure = zaman.Split(':');
            _dakika = Convert.ToInt32(sure.GetValue(0));
            _saniye = Convert.ToInt32(sure.GetValue(1));
        }

        public string GeriSayimSayaci()
        {
            _saniye -= 1;

            if (_saniye == -1)
            {
                _dakika--;
                _saniye = 59;
            }

            if (_saniye == -1)
            {
                _saniye = 59;
            }

            return $"{_dakika:00}:{_saniye:00}";
        }
    }
}