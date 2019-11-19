using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab_final {
    class ClienteHorista {
        #region Atributos

        const double tarifa_hora = 8;

        #endregion

        #region GetSets

        double getTarifaHora() {
            return tarifa_hora;
        }

        #endregion

        #region Métodos
        public double ValorTarifa(Estacionada quando) {

            double tarifaFinal = 0;

            
            TimeSpan tempoEstacionada = quando.getSaida().Subtract(quando.getEntrada());

            tarifaFinal = getTarifaHora() * tempoEstacionada.Hours;

            return tarifaFinal;
            
        }

        #endregion

    }
}
