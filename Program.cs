// Alvin Asael Amaya Pineda | 20241930068

using GestionTransporteUrbano;

BusUrbano busUrbano = new BusUrbano("BUS123", 50, 80, 200, 0.5);
Taxi taxi = new Taxi("TAXI456", 4, 120, 150, 5, 0.2);
BicicletaElectrica bicicletaElectrica = new BicicletaElectrica("BIKE789", 1, 25, 50, 0.1);

busUrbano.mostrarInformacion();
taxi.mostrarInformacion();
bicicletaElectrica.mostrarInformacion();

Console.WriteLine("\nViajando en Bus");
busUrbano.recorrerKilometros(10);
busUrbano.recorrerKilometros(30);
busUrbano.calcularCostoViaje();

Console.WriteLine("\nViajando en Taxi");
taxi.recorrerKilometros(10);
taxi.recorrerKilometros(30);
taxi.calcularCostoViaje();

Console.WriteLine("\nViajando en Bicicleta Eléctrica");
bicicletaElectrica.recorrerKilometros(10);
bicicletaElectrica.recorrerKilometros(30);
bicicletaElectrica.calcularCostoViaje();