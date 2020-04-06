using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public decimal Tarifa { get; set; }
        public string NumeroLiquidacion { get; set; }
        public string IdentificacionPasiente { get; set; }
        public string Tipo { get; set; }
        public decimal SalarioPaciente { get; set; }
        public decimal ValorServicio { get; set; }
        public decimal CuotaModeradora { get; set; }
        public LiquidacionCuotaModeradora(string numeroLiquidacion, string identificacionPaciente, string tipo, decimal salarioPaciente,decimal valorServicio)
        {
            NumeroLiquidacion = numeroLiquidacion;
            IdentificacionPasiente = identificacionPaciente;
            Tipo = tipo;
            SalarioPaciente = salarioPaciente;
            ValorServicio = valorServicio;

        }
        public abstract void Liquidar();
        public void calcularLiquidacion()
        {
            if (Tipo=="contributivo")
            {
                if (SalarioPaciente<=1600000)
                {
                    Tarifa = 0.15m;
                   CuotaModeradora= ValorServicio * Tarifa;
                    if (CuotaModeradora>=250000)
                    {
                        CuotaModeradora = 250000;
                    }
                }
                else if (SalarioPaciente<=4000000)
                {
                    Tarifa = 0.2m;
                    CuotaModeradora = ValorServicio* Tarifa;
                    if (CuotaModeradora >= 900000)
                    {
                        CuotaModeradora = 900000;
                    }
                }
                else if (SalarioPaciente>4000000)
                {
                    Tarifa= 0.25m;
                    CuotaModeradora = ValorServicio * Tarifa;
                    if (CuotaModeradora >= 1500000)
                    {
                        CuotaModeradora = 1500000;
                    }
                }
                

            }
            else
            {
                if (Tipo == "subsidiado")
                {
                    Tarifa = 0.05m;
                    CuotaModeradora = ValorServicio* Tarifa;
                    if (CuotaModeradora>=200000)
                    {
                        CuotaModeradora = 200000;
                    }
                }
            }

        }
      
        public override string ToString()
        {
            return $"       {NumeroLiquidacion}                    {IdentificacionPasiente}               {Tipo}         {SalarioPaciente}      {Tarifa}         {ValorServicio}           {CuotaModeradora} ";
        }
    }
}
