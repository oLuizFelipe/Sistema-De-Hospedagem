using System.Text;
using SistemaHospedagemHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Felipe");
Pessoa p2 = new Pessoa(nome: "Joao");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine("======================================");
Console.WriteLine("      SISTEMA DE HOSPEDAGEM");
Console.WriteLine("====================================");

Console.WriteLine($"\n🏨 Suíte: {suite.TipoSuite}");
Console.WriteLine($"👥 Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"📅 Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"💵 Valor da diária: R$ {suite.ValorDiaria:F2}");
Console.WriteLine($"💰 Valor total: R$ {reserva.CalcularValorDiaria():F2}");

Console.WriteLine("\n📋 Lista de hóspedes:");
foreach (Pessoa hospede in reserva.Hospedes)
{
    Console.WriteLine($"- {hospede.NomeCompleto}");
}

Console.WriteLine("\n====================================");
Console.WriteLine("    Reserva cadastrada com sucesso!");
Console.WriteLine("====================================");
