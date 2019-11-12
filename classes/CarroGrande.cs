﻿using System;

public class CarroGrande
{
	 #region Atributos


    double valorExtra = 2;

    const double tarifaBasica = 5;


    #endregion

    #region GetSets

    public double getTarifaBasica()
    {

        return tarifaBasica;

    }

    public double getValorExtra()
    {

        return valorExtra;

    }

    public void setValorExtra(double valor)
    {

        if (valor > 0)

            try
            {

                this.valorExtra = valor;

            }

            catch (ArgumentNullException)

            {

                Console.WriteLine("O parâmetro está nulo!");

            }


            catch (FormatException)

            {

                Console.WriteLine("Oformato do parâmetro está incorreto!");

            }


            catch (ArgumentException)

            {

                Console.WriteLine("O parâmetro não é válido!");

            }

    }


    #endregion


    #region Métodos
    public double tarifa(Estacionada quando)
    {

        double tarifa(Estacionada quando)

        {


            double tarifaFinal = 0;

            TimeSpan tempoEstacionada = Estacionada.saida.Subtract(Estacionada.entrada);

            tarifaFinal = (getTarifaBasica() + getValorExtra()) * tempoEstacionada.Hours;

            return tarifaFinal;


        }



    }

    #endregion

    #region Construtores

    public CarroGrande(string placa)
    {

        setPlaca(placa);

    }
    #endregion

}
