using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando.Entidade
{
    class Voo
    {
        private int id;
        private DateTime data;
        private double custo;
        private int distancia;
        private string captura;
        private int nivelDor;

        public int Id { get => id; set => id = value; }

        public DateTime Data { get => data; set => data = value; }

        public double Custo { get => custo; set => custo = value; }

        public int Distancia { get => distancia; set => distancia = value; }

        public string Captura { get => captura; set => captura = value; }

        public int NivelDor { get => nivelDor; set => nivelDor = value; }
    }
}
