using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        string operacion = "3 4 6 5 - + * 6 +";
        Console.WriteLine("El resultado es: {0}", Calcular(operacion));
    }

    static int Calcular(string operacion) {
        Stack<int> pila = new Stack<int>();
		int numero;
		
        string[] operacionSplited = operacion.Split(' ');
		foreach(string l in operacionSplited){
			if(int.TryParse(l, out numero))
				pila.Push(numero);
			else
				pila.Push(Operar(l, pila.Pop(), pila.Pop()));
		}
        return pila.Pop();
    }

    static int Operar(string operador, int op2, int op1) {
        switch (operador) {
            case "+": return op1 + op2;
            case "-": return op1 - op2;
            case "*": return op1 * op2;
            case "/": return op1 / op2;
        }
        return 0;
    }
}
