using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Presentacion
{

    public class Ciudad
    {
        public string CityId { get; set; }
        public string Name { get; set; }
        public string StateAbbr { get; set; }
        public int HourNumber { get; set; }
        public string LastReportTime { get; set; }
        public string DayOfWeek { get; set; }
        public string ValidDateUtc { get; set; }
        public string LocalValidDate { get; set; }
        public string TempF { get; set; }
        public string TempC { get; set; }
        public string SkyDescriptionLong { get; set; }
        public string ProbabilityOfPrecip { get; set; }
        public string RelativeHumidity { get; set; }
        public string WindSpeedMph { get; set; }
        public string WindSpeedKm { get; set; }
        public string WindDirectionCardinal { get; set; }
        public string IconCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
