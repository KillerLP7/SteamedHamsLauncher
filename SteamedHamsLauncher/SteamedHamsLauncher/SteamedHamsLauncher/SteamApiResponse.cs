using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamedHamsLauncher
{
    public class SteamApiResponse
    {
        //SteamAPI
        //Änder die Zahl in alles mögliche
        [JsonProperty()]
        public AppDetails AppData { get; set; }
    }
}
