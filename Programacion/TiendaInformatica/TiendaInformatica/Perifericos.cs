using System;

namespace TiendaInformatica
{
    internal class Perifericos : ProductoInformatico
    {
        private string nombre { get; set; }
        private string conexion { get; set; }

        public void SetNombre(string nombre) { this.nombre = nombre; }
        public string GetNombre() {  return this.nombre; }
        public void SetConexion(string conexion) { this.conexion = conexion; }
        public string GetConexion() { return this.conexion; }

        public Perifericos(string nombre, string conexion, string codigo, string marca, string modelo, double precio)
            : base(codigo, marca, modelo, precio)
        {
            this.nombre = nombre;
            this.conexion = conexion;
        }

        public override string ToString()
        {
            return base.ToString()+", "+this.nombre+", "+this.conexion;
        }
    }
}