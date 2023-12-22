//Ruben Martinez Martinez

using System;

struct Matrices{
	public int[,] matriz1;
	public int[,] matriz2;
	public int[,] matrizR;
}
class EjercicioMatrices{
	static void Main(){
		Matrices matrix = new Matrices();
		int opcion=1, dimension=0;
		do{
			try{
				Console.WriteLine("------MENU------");
				Console.WriteLine("1.Dimensionar matriz");
				Console.WriteLine("2.Rellenar matriz");
				Console.WriteLine("3.Mostrar matriz");
				Console.WriteLine("4.Sumar matrices");
				Console.WriteLine("5.Restar matrices");
				Console.WriteLine("6.Multiplicar matrices");
				Console.WriteLine("7.Trasponer matrices");
				Console.Write("0.Salir del programa\nInserte: ");
				opcion = Convert.ToInt32(Console.ReadLine());
				
				switch(opcion){
					case 0: Console.WriteLine("\nSaliendo del programa . . . "); 	
						break;
					case 1: 
						bool done = false;
						while(!done){
							Console.Write("Dimension: ");
							try{
								dimension = Convert.ToInt32(Console.ReadLine());
								if(dimension>0){
									done = true;
									DimensionarMatriz(ref matrix, ref dimension);
								} else throw new Exception(); 
							}catch(Exception){ Console.WriteLine("ERROR.Opcion"+
								" no valida\n"); }
						}
						break;
					case 2: ComprobarDimensionado(dimension);
							RellenarMatriz(ref matrix, dimension); 
						break;
					case 3: ComprobarDimensionado(dimension);
							MostrarMatriz(matrix, dimension); 
						break;
					case 4: ComprobarDimensionado(dimension);
							SumarMatrices(ref matrix, dimension);
							MostrarMatriz(matrix, dimension, '+');
						break;
					case 5: ComprobarDimensionado(dimension);
							RestarMatrices(ref matrix, dimension);
							MostrarMatriz(matrix, dimension, '-');
						break;
					case 6: ComprobarDimensionado(dimension);
							MultiplicarMatrices(ref matrix, dimension);
							MostrarMatriz(matrix, dimension, '*');
						break;
					case 7: ComprobarDimensionado(dimension);
							Console.WriteLine("Originales: ");
							MostrarMatriz(matrix, dimension);
							TrasponerMatrices(ref matrix, dimension);
							Console.WriteLine("Traspuestas: ");
							MostrarMatriz(matrix, dimension);
						break;
					default: Console.WriteLine("ERROR.Opcion debe ser entre " +
							"0 y 7");
						break;
				}
			}catch(Exception e){ Console.WriteLine("ERROR."+e.Message); }
			Console.WriteLine();
			
		} while(opcion!=0);
	}
	//------------
	static void DimensionarMatriz(ref Matrices m, ref int dimension){
		m.matriz1 = new int[dimension,dimension];
		m.matriz2 = new int[dimension,dimension];
		m.matrizR = new int[dimension,dimension];
	}
	//----------------
	static void RellenarMatriz(ref Matrices m, int dimension){
		Random rd = new Random();
		for(int i=0; i<dimension; i++){
			for(int j=0; j<dimension; j++){
				m.matriz1[i,j] = rd.Next(0,10);
				m.matriz2[i,j] = rd.Next(0,10);
			}
		}
	}
	//-----------------
	static void MostrarMatriz(Matrices m, int dimension, char tipo=' '){
		DibujarMatriz(m.matriz1, dimension);
		Console.WriteLine("   "+tipo);
		DibujarMatriz(m.matriz2, dimension);
		if(tipo!=' '){
			Console.WriteLine("   =");
			DibujarMatriz(m.matrizR, dimension);
		}
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
	static void SumarMatrices(ref Matrices m, int dimension){
		for(int i=0; i<dimension; i++){
			for(int j=0; j<dimension; j++){
				m.matrizR[i,j] = m.matriz1[i,j] + m.matriz2[i,j];
			}
		}
	}
	
	static void RestarMatrices(ref Matrices m, int dimension){
		for(int i=0; i<dimension; i++){
			for(int j=0; j<dimension; j++){
				m.matrizR[i,j] = m.matriz1[i,j] - m.matriz2[i,j];
			}
		}
	}
	
	static void MultiplicarMatrices(ref Matrices m, int dimension){
		for(int i=0; i>dimension; i++){
			for(int j=0; j>dimension; j++){
				int suma=0;
				for(int k=0; k>dimension; k++){
					suma +=m.matriz1[i,k] * m.matriz2[k,j];
				}
				m.matrizR[i,j] = suma;
			}
		}
	}
	//--------------
	static void TrasponerMatrices(ref Matrices m, int dimension){
		for(int i=0; i<dimension; i++){
			for(int j=dimension-1; j>0; j--){
				TrasponerMatrizAux(ref m.matriz1, dimension, i, j);
				TrasponerMatrizAux(ref m.matriz2, dimension, i, j);
			}
		}
	}
	
	static void TrasponerMatrizAux(ref int[,] matriz, int dimension, int i, int j){
		int vTemp = matriz[i,j];
		matriz[i,j] = matriz[j,i];
		matriz[j,i] = vTemp;
	}
	//--------------
	static void ComprobarDimensionado(int dimension){
		if(dimension<1)
			throw new Exception("Las matrices no esta dimensionadas");
	}
}
