using System;
using System.Collections.Generic;
using System.Text;

namespace GestionTransporteUrbano
{
    internal class BicicletaElectrica: Vehiculo
    {
        private double costoEnergiaPorKm;
        public BicicletaElectrica(string placa, int capacidad, double velocidadMaxima, double kilometrosRecorridos, double costoEnergiaPorKm) : 
            base(placa, capacidad, velocidadMaxima, kilometrosRecorridos) 
        {
            this.costoEnergiaPorKm = costoEnergiaPorKm;
        }
        public override void calcularCostoViaje()
        {
            Console.WriteLine($"Costo del viaje: {costoEnergiaPorKm * this.KilometrosRecorridos}");
        }
        public override void mostrarInformacion()
        {
            Console.WriteLine($"\nBicicleta Eléctrica - Placa: {this.Placa}" +
                $"\nCapacidad: {this.Capacidad}" +
                $"\nVelocidad Máxima: {this.VelocidadMaxima} km/h" +
                $"\nKilómetros Recorridos: {this.KilometrosRecorridos} km" +
                $"\nCosto de energia por Km: {this.costoEnergiaPorKm}");
        }
    }
}
