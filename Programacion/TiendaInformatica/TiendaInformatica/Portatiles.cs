using System;

namespace TiendaInformatica
{
    internal class Portatiles : ProductoInformatico
    {
        private double pantalla {  get; set; }
        private int ram { get; set; }
        private int disco {  get; set; }

        public void SetPantalla(double pantalla) { this.pantalla = pantalla; }
        public double GetPantalla() {  return this.pantalla; }
        public void SetRam(int ram) {  this.ram = ram; }
        public int GetRam() { return this.ram;}
        public void SetDisco(int disco) {  this.disco = disco; }
        public int GetDisco() {  return this.disco; }

        public Portatiles(double pantalla, int ram, int disco, string codigo, string marca, string modelo, double precio)
            :base(codigo, marca, modelo, precio)
        {
            this.pantalla = pantalla;
            this.ram = ram;
            this.disco = disco;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + this.pantalla + ", " + this.ram + ", " + this.disco;
        }
    }
}
