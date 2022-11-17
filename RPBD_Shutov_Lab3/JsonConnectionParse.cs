using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace RPBD_Shutov_Lab3
{
    class JsonConnectionParse
    {
        public Dictionary<string, Dictionary<string, string>> data { get; }
        public JsonConnectionParse(string jsonString)
        {
            data = JsonSerializer.Deserialize<JsonElement>(jsonString)
                .EnumerateObject()
                .ToDictionary(
                    x => x.Name, 
                    x => new Dictionary<string, string>(
                            x.Value.EnumerateObject()
                                .Select(y => new KeyValuePair<string, string>(y.Name, y.Value.GetString()))
                        )
                );
        }

        public Dictionary<string, string> GetConnection(string dbName)
        {
            Dictionary<string, string> result;
            if (data.TryGetValue(dbName, out result))
                return result;
            return null;
        }
    }
}
