using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Presentacion
{

    public class CiudadDia
    {
        public string CityId { get; set; }
        public string Name { get; set; }
        public string StateAbbr { get; set; }
        public string DayNumber { get; set; }
        public string ValidDateUtc { get; set; }
        public string LocalValidDate { get; set; }
        public string HiTempF { get; set; }
        public string LowTempF { get; set; }
        public string HiTempC { get; set; }
        public string LowTempC { get; set; }
        public string PhraseDay { get; set; }
        public string PhraseNight { get; set; }
        public string SkyText { get; set; }
        public string ProbabilityOfPrecip { get; set; }
        public string RelativeHumidity { get; set; }
        public string WindSpeedMph { get; set; }
        public string WindSpeedKm { get; set; }
        public string WindDirection { get; set; }
        public string WindDirectionCardinal { get; set; }
        public string CloudCoverage { get; set; }
        public string UvIndex { get; set; }
        public string UvDescription { get; set; }
        public string IconCode { get; set; }
        public string IconCodeNight { get; set; }
        public string SkyTextNight { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
