using System;
using System.Collections.Generic;
using System.Text;

namespace GestionTransporteUrbano
{
    internal abstract class Vehiculo
    {
        private String placa;
        private int capacidad;
        private double velocidadMaxima; //  km/h
        private double kilometrosRecorridos;

        public Vehiculo(string placa, int capacidad, double velocidadMaxima, double kilometrosRecorridos)
        {
            this.placa = placa;
            this.capacidad = capacidad;
            this.velocidadMaxima = velocidadMaxima;
            this.kilometrosRecorridos = kilometrosRecorridos;
        }

        public void recorrerKilometros(double kilometros)
        {
            kilometrosRecorridos += kilometros;
        }

        public abstract void calcularCostoViaje();
        public abstract void mostrarInformacion();
    }
}
