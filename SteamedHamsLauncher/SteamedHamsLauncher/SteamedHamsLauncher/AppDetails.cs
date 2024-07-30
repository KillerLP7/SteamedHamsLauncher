using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamedHamsLauncher
{
    public class AppDetails
    {
        //SteamAPI -> AppDetails
        [JsonProperty("data")]
        public GameData Data { get; set; }
    }
}
