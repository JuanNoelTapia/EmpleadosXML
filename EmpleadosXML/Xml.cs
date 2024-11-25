using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmpleadosXML
{
    public static class Xml
    {
        public static void GuardarEnXml<T>(List<T> lista, string archivoXml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (StreamWriter writer = new StreamWriter(archivoXml))
            {
                serializer.Serialize(writer, lista);
            }
        }

        public static List<T> LeerDesdeXml<T>(string arcrhivoXml)
        {
            if (!File.Exists(arcrhivoXml)) return new List<T>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (StreamReader reader = new StreamReader(arcrhivoXml))
            {
                return (List<T>)serializer.Deserialize(reader);
            }
        }
    }
}
