using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
   public class LiquidacionCuataMoeradoraRepository
    {
        private List<LiquidacionCuotaModeradora> Liquidaciones;
        public LiquidacionCuataMoeradoraRepository()
        {
            Liquidaciones = new List<LiquidacionCuotaModeradora>();
        }
        public void Guardar(LiquidacionCuotaModeradora liquidacion){ Liquidaciones.Add(liquidacion); }
        public void Eliminar(LiquidacionCuotaModeradora liquidacion) { Liquidaciones.Remove(liquidacion); }
        public List<LiquidacionCuotaModeradora> Consultar() { return Liquidaciones; }
        
        public LiquidacionCuotaModeradora Buscar(string id)
        {
            foreach (var item in Liquidaciones)
            {
                if (item.NumeroLiquidacion.Equals(id))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
