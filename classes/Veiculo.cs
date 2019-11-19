using System;

public abstract class Veiculo
{
        #region Atributos

    protected string placa;

    protected Estacionada[] usos;

    #endregion

    #region GetSets

    public string getPlaca()
    {

        return this.placa;

    }

    public void setPlaca(string placa) {

        try {
            if (placa != "" && placa.Length == 7) {
                placa = placa;
            }
        } catch (FormatException) {

            Console.WriteLine("O formato dos dados da placa está incorreto");

        } catch (ArgumentNullException) {

            Console.WriteLine("A string passada como valor da placa está vazia!");

        }


    }

    public Estacionada getUsos(int posicao) {

        return this.usos[posicao];

    }

    public void setUsos(int posicao, Estacionada valorVaga) {
        try {
            if (this.usos[posicao] == null) {

                this.usos[posicao] = valorVaga;

            }

        } catch (FormatException) {

            Console.WriteLine("O formato de algum dos parâmetros não é válido!");

        } catch (ArgumentException) {

            Console.WriteLine("Algum dos parâmetros não é válido!");

        }

    }
    #endregion

    #region Métodos

    public virtual double tarifa(Estacionada quando) {
        return 0;
    }

    #endregion
}
