using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HomeKitAccessory
{
    public class CharacteristicWriteRequest
    {
        [JsonProperty("characteristics")]
        public List<CharacteristicWriteItem> Characteristics {get;set;}
    }

    public class CharacteristicWriteItem
    {
        [JsonProperty("aid")]
        public int AccessoryId {get;set;}

        [JsonProperty("iid")]
        public int InstanceId {get;set;}

        [JsonProperty("value")]
        public JToken Value {get;set;}

        [JsonProperty("ev")]
        public bool? Events {get;set;}

        [JsonProperty("authData")]
        public string AuthData {get;set;}

        [JsonProperty("remote")]
        public bool? Remote {get;set;}
    }
}