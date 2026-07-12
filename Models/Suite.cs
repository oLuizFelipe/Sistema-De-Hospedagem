using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    public class Suite
    {
        public Suite(){}

        public Suite(String tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }


        public string TipoSuite { get; set; } = string.Empty;
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }


}