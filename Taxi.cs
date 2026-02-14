using System;
using System.Collections.Generic;
using System.Text;

namespace GestionTransporteUrbano
{
    internal class Taxi: Vehiculo
    {
        private double tarifaBase;
        private double tarifaPorKm;
        public Taxi(string placa, int capacidad, double velocidadMaxima, double kilometrosRecorridos, double tarifaBase, double tarifaPorKm) : 
            base(placa, capacidad, velocidadMaxima, kilometrosRecorridos) 
        {
            this.tarifaBase = tarifaBase;
            this.tarifaPorKm = tarifaPorKm;
        }
        public override void calcularCostoViaje()
        {
            Console.WriteLine($"Costo del viaje: {tarifaBase + (tarifaPorKm * this.KilometrosRecorridos)}");
        }
        public override void mostrarInformacion()
        {
            Console.WriteLine($"Taxi - Placa: {this.Placa}" +
                $"Capacidad: {this.Capacidad}" +
                $"Velocidad Máxima: {this.VelocidadMaxima} km/h" +
                $"Kilómetros Recorridos: {this.KilometrosRecorridos} km" +
                $"Tarifa Base: {this.tarifaBase}" +
                $"Tarifa por Km: {this.tarifaPorKm}");
        }
    }
}
