using System;
using System.Collections.Generic;
using System.Text;

namespace GestionTransporteUrbano
{
    internal class BusUrbano : Vehiculo
    {
        private double tarifaPorKm;
        public BusUrbano(string placa, int capacidad, double velocidadMaxima, double kilometrosRecorridos, double tarifaPorKm) : 
            base(placa, capacidad, velocidadMaxima, kilometrosRecorridos) 
        {
            this.tarifaPorKm = tarifaPorKm;
        }


        public override void calcularCostoViaje()
        {
            Console.WriteLine($"Costo del viaje: {tarifaPorKm * this.KilometrosRecorridos}");
        }

        public override void mostrarInformacion()
        {
            Console.WriteLine($"\nBus Urbano - Placa: {this.Placa}" +
                $"\nCapacidad: {this.Capacidad}" +
                $"\nVelocidad Máxima: {this.VelocidadMaxima} km/h" +
                $"\nKilómetros Recorridos: {this.KilometrosRecorridos} km" +
                $"\nTarifa por Km: {this.tarifaPorKm}");
        }
    }
}
