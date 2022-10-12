using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectTours
{
    public class ListTours
    {
        const string fileName = $"SaveTourData.json";

        private static Dictionary<string, Tour> _tourList = new();

        public static Dictionary<string, Tour> TourList { get => _tourList; set => _tourList = value; }

        public static void Load()
        {
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                if (!string.IsNullOrEmpty(jsonString))
                {
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                    _tourList = JsonConvert.DeserializeObject<Dictionary<string, Tour>>(jsonString, settings);
                }
            }
            else
            {
                _tourList = new();             
            }
        }

        public static void Save()
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            var jsonString = JsonConvert.SerializeObject(_tourList, Formatting.Indented, settings);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
