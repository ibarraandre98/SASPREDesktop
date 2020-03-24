using Capa_Datos;
using System.Collections.Generic;

namespace Capa_Negocio
{
    public class ScrapperCN
    {

        public static Dictionary<string, string> GetMaxTemperature()
        {
            var scrapper = new Scrapper();
            scrapper.Scrap();
            return scrapper.TemperaturaMaxima;
        }
        public static Dictionary<string, string> GetMinTemperature()
        {
            var scrapper = new Scrapper();
            scrapper.Scrap();
            return scrapper.TemperaturaMinima;
        }
        public static Dictionary<string, string> GetPrecipitation()
        {
            var scrapper = new Scrapper();
            scrapper.Scrap();
            return scrapper.Precipitacion;
        }
        public static Dictionary<string, string> GetDescription()
        {
            var scrapper = new Scrapper();
            scrapper.GetDescripcionclima();
            return scrapper.DescripcionDia;
        }

        public static int GetTemperaturaHoy()
        {
            var scrapper = new Scrapper();
            return scrapper.GetTemperaturaHoy();
        }
    }
}
