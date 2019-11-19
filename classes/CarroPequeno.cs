using System;

public class CarroPequeno:Veiculo {
	#region Atributos

    const double tarifaBasica = 5;

    #endregion

    #region Construtores

    public CarroPequeno(string placa) {

        setPlaca(placa);

    }

    #endregion 


    #region GetSets
    public double getTarifaBasica() {
        return tarifaBasica;
    }
    #endregion

    #region Métodos 
    public override double tarifa(Estacionada quando) {

        double tarifaFinal = 0;

        int tarifaHora = 5;

        TimeSpan tempoEstacionada = quando.getSaida().Subtract(quando.getEntrada());

        tarifaFinal = getTarifaBasica() * tempoEstacionada.Hours;

        return tarifaFinal;
        #endregion 

    }

}
