using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAutomoveis
{
    public abstract class Veiculo
    {

        private string placa;
        private string cor;
        private string modelo;
        private string chassi;
        private int ano;

        public Veiculo()
        {

            this.placa = null;
            this.cor = null;
            this.modelo = null;
            this.chassi = null;
            this.ano = 0;

        }

        public Veiculo(string placa, string cor, string modelo,
        string chassi, int ano)
        {

            this.placa = placa;
            this.cor = cor;
            this.modelo = modelo;
            this.chassi = chassi;
            this.ano = ano; 

        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }

        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public abstract String MostrarDados();

    }
}
