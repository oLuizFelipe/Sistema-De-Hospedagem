using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set;} =new();
        public Suite Suite {get; set;} = new();
        public int DiasReservados {get; set;}

        public Reserva() {}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
               throw new Exception("A capacidade da suíte é insuficiente para a quantidade de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            if(DiasReservados >= 10)
            {
                valor = valor * 0.90m;
            }

            return valor;

        }

    }
}