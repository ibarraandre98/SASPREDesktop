using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Fertilizantes
    {
        public static DataTable MostrarFertilizantes()
        {
            var fertilizantes = new Capa_Datos.CD_Fertilizantes();
            return fertilizantes.MostrarFertilizantes();
        }
    }
}