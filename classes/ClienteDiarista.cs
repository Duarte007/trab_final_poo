using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab_final {
    class ClienteDiarista {
        #region Atributos

        const double tarifa_dia = 30;

        #endregion

        #region GetSets

        double getTarifaDia() {
            return tarifa_dia;
        }

        #endregion

        #region Métodos

        public double valorTarifa(Estacionada quando) {
            double tarifa_final = 0;            

           TimeSpan diasEstacionada = quando.getSaida().Subtract(quando.getEntrada());

            tarifa_final = getTarifaDia() * diasEstacionada.Days;

            return tarifa_final;


        }

        #endregion
    }
}
