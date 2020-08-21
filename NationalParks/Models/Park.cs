using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NationalParks.Models

{
    [JsonObject(IsReference = true)]
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string StateOrNational { get; set; }
    }
}