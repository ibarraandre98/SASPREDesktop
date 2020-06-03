using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Costos
    {
        DataTable tablaCostos = new DataTable();
        DataTable tablaCultivo = new DataTable();

        private CD_Costos _Costos = new CD_Costos();

        public void InsertarCostos(String cultivo, double precio, String descripcion)
        {
            _Costos.InsertarCostos(cultivo, precio, descripcion);
        }

        public void ElimiarCostos(String cultivo)
        {
            _Costos.ELimiarCostos(cultivo);
        }

        public void ModificarCostos(String idCostos,String cultivo, double precio, String descripcion)
        {
            _Costos.ModificarCostos(idCostos,cultivo, precio, descripcion);
        }

        public DataTable MostrarCostos()
        {
            tablaCostos = _Costos.MostrarCostos();
            return tablaCostos;
        }

        public DataTable MostrarCultivo()
        {
            tablaCultivo = _Costos.MostrarCultivo();
            return tablaCultivo;
        }

    }
}
