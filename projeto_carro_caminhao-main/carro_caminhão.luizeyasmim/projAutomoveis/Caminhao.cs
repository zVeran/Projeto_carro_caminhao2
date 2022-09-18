using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAutomoveis
{
    public class Caminhao : Veiculo
    {

        private double capacidade_carga;
        private string tipo_carga;

        public Caminhao()
        {
            capacidade_carga = 0;
            tipo_carga = null;
        }

        public Caminhao(string modelo, string placa, string cor, string tipo_carga, 
        int ano, double capacidade_carga,  string chassi)
        {
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.Tipo_carga = tipo_carga;
            this.Ano = ano;
            this.Capacidade_carga = capacidade_carga;
            this.Chassi = chassi;

        }

        public double Capacidade_carga
        {
            get { return capacidade_carga; }
            set { capacidade_carga = value; }
        }

        public string Tipo_carga
        {
            get { return tipo_carga; }
            set { tipo_carga = value; }
        }

        public override string MostrarDados()
        {

            string message = string.Empty;
            message = String.Concat("MODELO: ", this.Modelo, "\n",
                                    "PLACA: ", this.Placa, "\n",
                                    "COR: ", this.Cor, "\n",
                                    "TIPO DE CARGA: ", this.Tipo_carga, "\n",
                                    "ANO: ", this.Ano, "\n",
                                    "CAPACIDADE DA BAGAGEM: ", this.Capacidade_carga, " LITROS", "\n",
                                    "CHASSI: ", this.Chassi, "\n",
                                    "BAU: SIM", "\n"
                );

            return message;

        }



    }
}
