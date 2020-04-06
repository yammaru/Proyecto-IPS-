using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL

{
    public class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuataMoeradoraRepository RepositorioLiquidacion = new LiquidacionCuataMoeradoraRepository();
        public string Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            if (RepositorioLiquidacion.Buscar(liquidacion.NumeroLiquidacion)==null)
            {
                RepositorioLiquidacion.Guardar(liquidacion);
                return $"la liquidacion fue guarda";
            }
            return $"paciente {liquidacion.NumeroLiquidacion}, ya exite";
        }
       
        public string Eliminar(string numeroLiquidacion)
        {
            LiquidacionCuotaModeradora liquidacion = RepositorioLiquidacion.Buscar(numeroLiquidacion);
            if (liquidacion == null)
            {
                return $"la liquidacion {numeroLiquidacion}, no exite";
            }
            RepositorioLiquidacion.Eliminar(liquidacion);
            return $"la liquidacion {liquidacion.NumeroLiquidacion} fue borrada";
        }
        public List<LiquidacionCuotaModeradora> Consultar() { return RepositorioLiquidacion.Consultar(); }
        public LiquidacionCuotaModeradora Buscar(string id){return RepositorioLiquidacion.Buscar(id);}
    }
}
