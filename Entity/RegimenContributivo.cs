using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenContributivo : LiquidacionCuotaModeradora
    {
        public RegimenContributivo(string numeroLiquidacion, string identificacionPaciente, string tipo, decimal salarioPaciente, decimal valorServicio) : base(numeroLiquidacion, identificacionPaciente, tipo, salarioPaciente, valorServicio)
        {
            
        }

        public override void Liquidar()
        {

            if (SalarioPaciente <= 1600000)
            {
                Tarifa = 0.15m;
                CuotaModeradora = ValorServicio * Tarifa;
                if (CuotaModeradora >= 250000)
                {
                    CuotaModeradora = 250000;
                }
            }
            else if (SalarioPaciente <= 4000000)
            {
                Tarifa = 0.2m;
                CuotaModeradora = ValorServicio * Tarifa;
                if (CuotaModeradora >= 900000)
                {
                    CuotaModeradora = 900000;
                }
            }
            else if (SalarioPaciente > 4000000)
            {
                Tarifa = 0.25m;
                CuotaModeradora = ValorServicio * Tarifa;
                if (CuotaModeradora >= 1500000)
                {
                    CuotaModeradora = 1500000;
                }
            }
        }    
    }
}
