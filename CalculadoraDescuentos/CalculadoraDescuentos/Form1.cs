using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDescuentos
{
	public partial class Form1 : Form
	{
		// Crear una instancia de la clase de backend
		Calculadora calc = new Calculadora();
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			// Capturar los valores del frontend
			// Creamos dos variables para almacenar el valor introducido en cada TextBox
			decimal PrecioUnidad = Convert.ToDecimal(txtPrecio.Text);
			int Cantidad = Convert.ToInt32(txtCantidad.Text);

			// Llamar al método que calcula el total con descuento
			decimal TotalConDescuento = calc.CalcularTotal(PrecioUnidad, Cantidad);

			// Mostrar el resultado en el formulario
			lblTotal.Text = $"Total con descuento: {TotalConDescuento:C}";
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			BorrarLimpiar();
		}


		private void BorrarLimpiar()
		{
			txtPrecio.Text = "";
			txtCantidad.Text = "";
			lblTotal.Text = "";

			txtPrecio.Focus();
		}


	}

}
