using System.Text;
using hosting_system.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Person> guests = new List<Person>();

Person p1 = new Person(name: "Hóspede 1");
Person p2 = new Person(name: "Hóspede 2");

guests.Add(p1);
guests.Add(p2);

// Cria a suíte
Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyValue: 30);

// Cria uma nova booking, passando a suíte e os hóspedes
Booking booking = new Booking(reservedDays: 5);
booking.AddingSuite(suite);
booking.AddingGuests(guests);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {booking.GetQuantityGuests()}");
Console.WriteLine($"Valor diária: {booking.CalculateDailyValue()}");