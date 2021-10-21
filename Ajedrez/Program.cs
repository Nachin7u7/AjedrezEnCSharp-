using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
	class Program
	{
		static void Main(string[] args)
		{
			char seguir;
			string[,] tablero = new string[8, 8];
			Peon peonBlanco = new Peon("PB");
			Peon peonNegro = new Peon("PN");
			Torre torreBlanca = new Torre("TB");
			Torre torreNegra = new Torre("TN");
			Caballo caballoBlanco = new Caballo("CB");
			Caballo caballoNegro = new Caballo("CN");
			Alfil alfilBlanco = new Alfil("AB");
			Alfil alfilNegro = new Alfil("AN");
			Reina reinaBlanca = new Reina("QB");
			Reina reinaNegra = new Reina("QN");
			Rey reyBlanco = new Rey("RB");
			Rey reyNegro = new Rey("RN");

			for (int f = 0; f < 8; f++)
			{
				for (int c = 0; c < 8; c++)
				{
					if ((c+f)%2 == 0)
						tablero[f, c] = ((char)15).ToString()+ ((char)15).ToString();
				}
			}


			for (int c=0;c<8;c++)
			{
				tablero[1, c] = peonBlanco.ColorFicha;
				tablero[6, c] = peonNegro.ColorFicha;
			}

			{
				tablero[0, 0] = torreBlanca.ColorFicha;
				tablero[0, 7] = torreBlanca.ColorFicha;
				tablero[0, 1] = caballoBlanco.ColorFicha;
				tablero[0, 6] = caballoBlanco.ColorFicha; 
				tablero[0, 2] = alfilBlanco.ColorFicha;
				tablero[0, 5] = alfilBlanco.ColorFicha;
				tablero[0, 3] = reinaBlanca.ColorFicha;
				tablero[0, 4] = reyBlanco.ColorFicha;

				tablero[7, 0] = torreNegra.ColorFicha;
				tablero[7, 7] = torreNegra.ColorFicha;
				tablero[7, 1] = caballoNegro.ColorFicha;
				tablero[7, 6] = caballoNegro.ColorFicha;
				tablero[7, 2] = alfilNegro.ColorFicha;
				tablero[7, 5] = alfilNegro.ColorFicha;
				tablero[7, 3] = reinaNegra.ColorFicha;
				tablero[7, 4] = reyNegro.ColorFicha;
			}



			Console.Write("\tA\tB\tC\tD\tE\tF\tG\tH");
			Console.WriteLine();
			for (int f = 0; f < 8; f++)
			{
				Console.Write(8 - f + "\t");
				for (int c = 0; c < 8; c++)
				{
					Console.Write(tablero[f, c] + "\t");
				}
				Console.WriteLine();
				Console.WriteLine();

			}

			string movida;
			string destino;
			int fila=0;
			int columna=0;
			int filaD = 0;
			int columnaD = 0;

			do
			{
				for(int i =0 ; i<=1 ; i++){
					
					if(i==0)
						Console.WriteLine("Turno de blancas");
					else
						Console.WriteLine("Turno de negras");
					
					Console.Write("--->Ficha a mover: Ingrese FilaColumna: ");
					movida = Console.ReadLine();

					Console.Write("--->Destino: Ingrese FilaColumna: ");
					destino = Console.ReadLine();

					fila = Math.Abs(movida[0] - 48 - 8);
					filaD = Math.Abs(destino[0] - 48 - 8);

					switch (destino[1])
					{
					case 'A':
						columnaD = 0;
						break;
					case 'B':
						columnaD = 1;
						break;
					case 'C':
						columnaD = 2;
						break;
					case 'D':
						columnaD = 3;
						break;
					case 'E':
						columnaD = 4;
						break;
					case 'F':
						columnaD = 5;
						break;
					case 'G':
						columnaD = 6;
						break;
					case 'H':
						columnaD = 7;
						break;
					}

					switch (movida[1])
					{
					case 'A':
						columna = 0;
						break;
					case 'B':
						columna = 1;
						break;
					case 'C':
						columna = 2;
						break;
					case 'D':
						columna = 3;
						break;
					case 'E':
						columna = 4;
						break;
					case 'F':
						columna = 5;
						break;
					case 'G':
						columna = 6;
						break;
					case 'H':
						columna = 7;
						break;
					}

					//tablero[fila+2, columna] = tablero[fila, columna];

					if(i==0 && tablero[fila, columna][1] == 'N'){
						Console.WriteLine("No es su turno");
						break;
					}
					else if(i==1 && tablero[fila, columna][1] == 'B'){
						Console.WriteLine("No es su turno");
						break;
					}


					tablero[filaD, columnaD] = tablero[fila, columna];
					if ((fila + columna) % 2 == 0)
						tablero[fila, columna] = ((char)15).ToString() + ((char)15).ToString();
					else
						tablero[fila, columna] = "";

					Console.Write("\tA\tB\tC\tD\tE\tF\tG\tH");
					Console.WriteLine();
					for (int f = 0; f < 8; f++)
					{
						Console.Write(8 - f + "\t");
						for (int c = 0; c < 8; c++)
						{
							Console.Write(tablero[f, c] + "\t");
						}
						Console.WriteLine();
						Console.WriteLine();

					}


					//Console.ReadKey();
				}
				Console.WriteLine("Continuar (S/N):");
				seguir = char.Parse(Console.ReadLine());
			} while (seguir == 'S');
		}
	}
}
