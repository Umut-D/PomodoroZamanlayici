using System.Media;
using System.Windows.Forms;
using PomodoroZamanlayiciLibrary.Properties;

namespace PomodoroZamanlayiciLibrary
{
    public class Ses
    {
        public void Cal()
        {
            try
            {
                SoundPlayer oynatici = new SoundPlayer(Resources.alarm);
                oynatici.Play();
            }
            catch
            {
                 MessageBox.Show(@"Ses sorunu yaşandı. Ses kartınızla ilgili bir sorun olabilir mi? Fakat şunu da unutmayın, süre doldu!", @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}