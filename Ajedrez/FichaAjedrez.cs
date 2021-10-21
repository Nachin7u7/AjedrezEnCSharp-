using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
	abstract class FichaAjedrez
	{
		string color;
		int fila, columna;

		public string ColorFicha
		{
			get
			{
				return color;
			}

			set
			{
				color = value;
			}
		}

		public abstract void mostrar();
		public abstract bool validaMovimiento(int filaDestino, int columnaDestino);
		public abstract void mover(int filaNueva, int columnaNueva);
	}
}
