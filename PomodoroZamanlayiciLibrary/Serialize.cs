using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PomodoroZamanlayiciLibrary
{
    public class Serialize
    {
        private readonly BinaryFormatter _binary;
        private readonly string _kayitAdi = "ayarlar";

        public Serialize()
        {
            _binary = new BinaryFormatter();
        }

        public object DeserializeYukle()
        {
            object okunan;
            using (FileStream akis = new FileStream(_kayitAdi, FileMode.OpenOrCreate, FileAccess.Read))
                okunan = _binary.Deserialize(akis);

            return okunan;
        }

        public void SerializeKaydet(object tur)
        {
            using (FileStream akis = new FileStream(_kayitAdi, FileMode.Create, FileAccess.Write))
                _binary.Serialize(akis, tur);
        }
    }
}