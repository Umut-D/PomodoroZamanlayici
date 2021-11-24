﻿using System.Runtime.InteropServices;

namespace PomodoroZamanlayiciLibrary
{
    public static class Baglanti
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int description, int reservedValue);

        public static bool InternetVarMi()
        {
            return InternetGetConnectedState(out _, 0);
        }
    }
}