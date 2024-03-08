using System;

namespace TiendaInformatica
{
    internal class OtrosComponentes : ProductoInformatico
    {
        private string nombre {  get; set; }
        private string descripcion { get; set; }

        public void SetNombre(string nombre) { this.nombre = nombre; }
        public string GetNombre() {  return this.nombre; }
        public void SetDescripcion(string descripcion) { this.descripcion = descripcion;  }
        public string GetDescripcion() {  return this.descripcion; }

        public OtrosComponentes(string nombre, string descripcion, string codigo, string marca, string modelo, double precio)
            :base(codigo, marca, modelo, precio)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + this.nombre + ", " + this.descripcion;
        }
    }
}
