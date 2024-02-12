using System;

class MiPila {
    private string[] pila = new string[100];
    private int cantidad = 0;

    public int Cantidad {
        get { return cantidad; }
        private set { cantidad = value; }
    }

    public int GetCantidad() {
        return this.Cantidad;
    }

    public void SetCantidad(int cantidad) {
        this.Cantidad = cantidad;
    }

    public void Push(string s) {
        if (Cantidad < pila.Length) {
            pila[Cantidad] = s;
            Cantidad++;
        } else {
            Console.WriteLine("La pila está llena, no se puede agregar más elementos.");
        }
    }
}

class Ejercicio_7_2_2 {
    static void Main() {
        MiPila miPila = new MiPila();
        miPila.Push("e1");
        miPila.Push("e2");
        Console.WriteLine("Cantidad de elementos en la pila: " + miPila.GetCantidad());
    }
}
