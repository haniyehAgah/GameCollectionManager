using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gameCollectionManager
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.IO;

    public static class JsonService
    {
        public static void
            Save(List<Game> games)
        {
            string json = JsonConvert.SerializeObject(games, Formatting.Indented);
            File.WriteAllText("games.json", json);
        }

        public static List<Game> Load()
        {
            if (!File.Exists("games.json"))
            {
                return new List<Game>();
            }
            string json = File.ReadAllText("games.json");
            return
            JsonConvert.DeserializeObject<List<Game>>(json);
        }

    }
}
