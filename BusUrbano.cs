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
            Console.WriteLine($"Bus Urbano - Placa: {this.Placa}" +
                $"Capacidad: {this.Capacidad}" +
                $"Velocidad Máxima: {this.VelocidadMaxima} km/h" +
                $"Kilómetros Recorridos: {this.KilometrosRecorridos} km" +
                $"Tarifa por Km: {this.tarifaPorKm}");
        }
    }
}
