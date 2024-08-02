using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

namespace EasyGo
{
    public static class DataService
    {
        private static readonly string FilePath = "data.xml";

        public static void SaveUsers(List<User> users)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using (var writer = new StreamWriter(FilePath))
            {
                serializer.Serialize(writer, users);
            }
        }

        public static List<User> LoadUsers()
        {
            if (!File.Exists(FilePath))
                return new List<User>();

            var serializer = new XmlSerializer(typeof(List<User>));
            using (var reader = new StreamReader(FilePath))
            {
                return (List<User>)serializer.Deserialize(reader);
            }
        }
    }
}

