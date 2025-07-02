using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
List<Pessoa> hospedesDemais = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");

hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);

hospedesDemais.Add(p1);
hospedesDemais.Add(p2);
hospedesDemais.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 15);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Reserva reserva2 = new Reserva(diasReservados: 9);
reserva2.CadastrarSuite(suite);
reserva2.CadastrarHospedes(hospedes);

Reserva reserva3 = new Reserva(diasReservados: 5);
reserva3.CadastrarSuite(suite);
//reserva3.CadastrarHospedes(hospedesDemais);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"Valor diária reserva 2: {reserva2.CalcularValorDiaria()}");
//Console.WriteLine($"Valor diária reserva 3 (hóspedes demais): {reserva3.CalcularValorDiaria}");
