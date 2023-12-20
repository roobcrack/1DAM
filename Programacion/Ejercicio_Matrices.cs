//Ruben Martinez Martinez

using System;

struct Matrices{
	public int[,] matriz1;
	public int[,] matriz2;
	public int[,] matriz3;
}
class EjercicioMatrices{
	static void Main(){
		Matrices matrices = new Matrices();
		int opcion=1, dimension=0;
		do{
			try{
				Console.WriteLine("------MENU------");
				Console.WriteLine("1.Dimensionar matriz");
				Console.WriteLine("2.Rellenar matriz");
				Console.WriteLine("3.Mostrar matriz");
				Console.WriteLine("4.Operar matrices");
				Console.WriteLine("5.Trasponer matrices");
				Console.Write("0.Salir del programa\nInserte: ");
				opcion = Convert.ToInt32(Console.ReadLine());
				
				switch(opcion){
					case 0: Console.WriteLine("\nSaliendo del programa . . . "); 	
						break;
					case 1: DimensionarMatriz(ref matrices, ref dimension); 
						break;
					case 2: RellenarMatriz(ref matrices, dimension); break;
					case 3: MostrarMatriz(matrices, dimension); break;
					case 4: OperarMatrices(matrices, dimension); break;
					case 5: TrasponerMatrices(ref matrices, dimension); break;
					default: Console.WriteLine("ERROR. Opcion debe ser entre " +
							"0 y 5");
						break;
				}
			}catch(Exception){ Console.WriteLine("ERROR. Opcion no valida."); }
			Console.WriteLine();
			
		} while(opcion!=0);
	}
	//------------
	static void DimensionarMatriz(ref Matrices matrices, ref int dimension){
		bool done = false;
		while(!done){
			try{
				Console.Write("Dimension: ");
				dimension = Convert.ToInt32(Console.ReadLine());
				if(dimension>0){
					done = true;
					matrices.matriz1 = new int[dimension,dimension];
					matrices.matriz2 = new int[dimension,dimension];
					matrices.matriz3 = new int[dimension,dimension];
				} else{ throw new Exception(); }
			}catch(Exception){ Console.WriteLine("ERROR. Opcion no valida\n"); }
		}
	}
	//----------------
	static void RellenarMatriz(ref Matrices matrices, int dimension){
		if(dimension>0){
			Random rd = new Random();
			for(int i=0; i<dimension; i++){
				for(int j=0; j<dimension; j++){
					matrices.matriz1[i,j] = rd.Next(0,10);
					matrices.matriz2[i,j] = rd.Next(0,10);
				}
			}
		} else{
			Console.WriteLine("ERROR.Las matrices no estan dimensionadas"); }
	}
	//-----------------
	static void MostrarMatriz(Matrices matrices, int dimension){
		if(dimension>0){
			DibujarMatriz(matrices.matriz1, dimension);
			Console.WriteLine();
			DibujarMatriz(matrices.matriz2, dimension);
		} else{
			Console.WriteLine("ERROR.Las matrices no estan dimensionadas"); }
	}
	
	static void DibujarMatriz(int[,] matriz, int dimension){
		for(int i=0; i<dimension; i++){
			Console.Write("|");
			for(int j=0; j<dimension; j++){
				Console.Write(" "+matriz[i,j]);
			}
			Console.Write(" |\n");
		}
	}
	//----------------
	static void OperarMatrices(Matrices m, int dimension){
		if(dimension>0){
			int opcion=0;
			string operador="";
			bool done = false;
			while(!done){
				Console.Write("¿Quieres (1)sumar o (2)restar?\nInserte: ");
				try{
					opcion = Convert.ToInt32(Console.ReadLine());
					if(opcion==1 || opcion==2){ done = true; }
					else{ throw new Exception(); }
				}catch(Exception){
					Console.WriteLine("ERROR. Opcion no valida\n"); 
				}
			}
			for(int i=0; i<dimension; i++){
				for(int j=0; j<dimension; j++){
					switch(opcion){
						case 1:m.matriz3[i,j] = m.matriz1[i,j] + m.matriz2[i,j];
						operador = "+"; break;
						case 2:m.matriz3[i,j] = m.matriz1[i,j] - m.matriz2[i,j]; 
						operador = "-"; break; 
					}
				}
			}
			DibujarMatriz(m.matriz1, dimension);
			Console.WriteLine(" "+operador);
			DibujarMatriz(m.matriz2, dimension);
			Console.WriteLine(" =");
			DibujarMatriz(m.matriz3, dimension);
		} else{ Console.WriteLine("ERROR.Las matrices no estan " +
				"dimensionadas"); }
	}
	//------------
	static void TrasponerMatrices(ref Matrices m, int dimension){
		for(int i=0; i<dimension; i++){
			for(int j=dimension-1; j>0; j--){
				TrasponerMatrizAux(ref m.matriz1, dimension, i, j);
				TrasponerMatrizAux(ref m.matriz2, dimension, i, j);
			}
		}
		MostrarMatriz(m, dimension);
	}
	
	static void TrasponerMatrizAux(ref int[,] m, int dimension, int i, int j){
		int vTemp = m[i,j];
		m[i,j] = m[j,i];
		m[j,i] = vTemp;
	}
}
