using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
	class Caballo : FichaAjedrez
	{
		public Caballo(string Color)
		{
			ColorFicha = Color;
		}

		public override void mostrar()
		{

		}
		public override void mover(int filaDestino, int columnaDestino)
		{

		}
		public override bool validaMovimiento(int filaDestino, int columnaDestino)
		{
			return false;
		}

	}
}
