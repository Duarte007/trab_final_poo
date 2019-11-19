using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab_final {
    public abstract class Cliente {
        #region Atributos
        public string nome;
        public string cpf;

        #endregion

        #region GetSets
        public string getNome() {
            return this.nome;
        }

        public string getCpf() {
            return this.cpf;
        }

        public void setNome(string nome)  {
            try {
                if (nome != "")
                    this.nome = nome;
            } catch (ArgumentNullException) {
                Console.WriteLine("A string passada como nome está vazia!");
            }

        }

        public void setCpf(string cpf) {
            try {
                if (cpf != "")
                    this.cpf = cpf;
            } catch (ArgumentNullException) {
                Console.WriteLine("A string passada como cpf está vazia!");
            }
        }

        #endregion

        #region Métodos

        public double valorTarifa(Estacionada quando) {
            return 0d;
        }

        #endregion
    }
}
