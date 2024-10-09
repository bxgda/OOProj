using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Lab5.Settings
{
    [Serializable]
    public class Settings
    {
        #region Atributi

        private int _brojRedova;
        private int _brojKolona;
        private int _brojParova;
        private int _brojSlika;

        private static Settings _instance;

        #endregion

        #region Properties

        [XmlIgnore]
        public static Settings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Settings();

                return _instance;
            }
            set { _instance = value; }
        }

        public int BrojRedova
        {
            get { return _brojRedova; }
            set { _brojRedova = value; }
        }

        public int BrojKolona
        {
            get { return _brojKolona; }
            set { _brojKolona = value; }
        }

        public int BrojParova
        {
            get { return _brojParova; }
            set { _brojParova = value; }
        }

        public int BrojSlika
        {
            get { return _brojSlika; }
            set { _brojSlika = value; }
        }

        #endregion

        #region Metode

        public void Save(string fileName)
        {
            XmlTextWriter wr = null;

            try
            {
                wr = new XmlTextWriter(fileName, Encoding.Unicode);
          
                XmlSerializer sr = new XmlSerializer(typeof(Settings));

                sr.Serialize(wr, this);
            }
            catch
            {
            }
            finally
            {
                wr.Close();
            }
        }

        public static void Load(string fileName)
        {
            StreamReader rd = null;

            try
            {
                rd = new StreamReader(fileName, Encoding.Unicode);

                XmlSerializer sr = new XmlSerializer(typeof(Settings));

                Instance = (Settings)sr.Deserialize(rd);
            }
            catch
            {
            }
            finally
            {
                rd.Close();
            }
        }

        #endregion
    }
}
