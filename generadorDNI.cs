using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        
        Console.WriteLine("Pulsa para continuar . . .");
        string loop = Console.ReadLine();
        
        do{
			string nombre = GenerarNombreCompleto(random);
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Email: " + GenerarEmail(random, nombre));
			Console.WriteLine("Contraseña: " + GenerarContrasenya(random));
			int dni = random.Next(10000000, 99999999);
			Console.WriteLine("DNI: " + dni + CalcularLetraDNI(dni));
			Console.WriteLine("Teléfono: " + GenerarNumeroTelefono(random));
			
			loop = Console.ReadLine();
		} while(loop != "0");
        
    }
    
    static string GenerarNombreCompleto(Random random)
    {
        string[] nombres = {
            "Juan", "María", "Pedro", "Ana", "Luis", "Laura", "Carlos", "Sofía", "Javier", "Elena",
            "Francisco", "Lucía", "Miguel", "Paula", "Alberto", "Isabel", "Diego", "Carmen", "Roberto", "Beatriz",
            "Alejandro", "Raquel", "Fernando", "Natalia", "Antonio", "Eva", "José", "Teresa", "Manuel", "Marta"
        };
        string[] apellidos = {
            "García", "Fernández", "López", "Martínez", "González", "Rodríguez", "Sánchez", "Pérez", "Martín", "Gómez",
            "Díaz", "Hernández", "Moreno", "Álvarez", "Romero", "Muñoz", "Ortega", "Torres", "Delgado", "Rubio",
            "Jiménez", "Gutiérrez", "Navarro", "Molina", "Serrano", "Ramírez", "Marín", "Iglesias", "Santos", "Castro"
        };

        return nombres[random.Next(nombres.Length)] + " " + apellidos[random.Next(apellidos.Length)];
	}
    
    static char CalcularLetraDNI(int dni)
    {
        char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D',
			 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

        return letras[dni % 23];
    }
    
    static string GenerarNumeroTelefono(Random random)
    {
        string numeroTelefono = "6";
        for (int i = 0; i < 8; i++)
        {
            numeroTelefono += random.Next(0, 10);
        }
        
        return numeroTelefono;
    }
    
     static string GenerarContrasenya(Random random)
    {
        string simbolos = "!@#$%^&*()-_+=<>?/.,;:";
        string letrasMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numeros = "0123456789";

        StringBuilder contrasenya = new StringBuilder();
        contrasenya.Append(simbolos[random.Next(simbolos.Length)]);
        contrasenya.Append(letrasMayusculas[random.Next(letrasMayusculas.Length)]);
        contrasenya.Append(numeros[random.Next(numeros.Length)]);

        for (int i = 0; i < 7; i++)
        {
            string caracteresPosibles = letrasMayusculas + 
				letrasMayusculas.ToLower() + numeros + simbolos;
            contrasenya.Append(
				caracteresPosibles[random.Next(caracteresPosibles.Length)]);
        }

        string contrasenyaFinal = contrasenya.ToString();
        contrasenyaFinal = MezclarCaracteres(contrasenyaFinal, random);

        return contrasenyaFinal;
    }

    static string MezclarCaracteres(string str, Random random)
    {
        char[] array = str.ToCharArray();

        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        return new string(array);
    }
    
    static string GenerarEmail(Random random, string nombre){
		string[] nom = nombre.Split(' ');
		
		return nom[0].ToLower()+nom[1].ToLower()+random.Next(100000, 999999)+"@gmail.com";
	}
}
