using System;

namespace TiendaInformatica
{
    internal class ProductoInformatico
    {
        protected string codigo { get; set; }
        protected string marca { get; set; }
        protected string modelo { get; set; }
        protected double precio { get; set; }

        public void SetCodigo(string codigo) { this.codigo = codigo; }
        public string GetCodigo() { return this.codigo; }
        public void SetMarca(string marca) { this.marca = marca; }
        public string GetMarca() { return this.marca; }
        public void SetModelo(string modelo) { this.modelo = modelo; }
        public string GetModelo() { return this.modelo; }
        public void SetPrecio(double precio) { this.precio = precio; }
        public double GetPrecio() { return this.precio; }

        public ProductoInformatico(string codigo, string marca, string modelo, double precio)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
        }

        public virtual string ToString()
        {
            return this.codigo + ", " + this.marca + ", " + this.modelo + ", " + this.precio;
        }
    }
}
