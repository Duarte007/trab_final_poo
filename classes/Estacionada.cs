using System;

public class Estacionada
{
    private Vaga vaga;
    private DateTime entrada;
    private DateTime saida;
	public Estacionada() {

	}

    public DateTime getSaida(){
        return this.saida;
    }

    public DateTime getEntrada(){
        return this.entrada;
    }
}
