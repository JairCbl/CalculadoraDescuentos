using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDescuentos
{
	internal class Calculadora
	{
		public decimal CalcularTotal(decimal PrecioUnidad, int Cantidad)
		{
			decimal descuento = 0;

			// Condicional con IF para determinar el descuento
			if (Cantidad >= 6 && Cantidad <= 10)
			{
				descuento = 0.10m; //10% de descuento
			}
			else if (Cantidad >10)
			{
				descuento = 0.20m; //20% de descuento
			}

			//Calcular total sin descuento 
			decimal TotalSinDescuento = PrecioUnidad * Cantidad;

			//Aplicar descuento
			decimal TotalConDescuento = TotalSinDescuento * (1 - descuento);

			return TotalConDescuento;
		}
	}
}
