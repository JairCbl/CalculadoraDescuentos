namespace CalculadoraDescuentos
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.lblBienvenida = new System.Windows.Forms.Label();
			this.lbl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPrecio
			// 
			this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(56, 56);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 23);
			this.txtPrecio.TabIndex = 0;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(56, 127);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 23);
			this.txtCantidad.TabIndex = 1;
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecio.Location = new System.Drawing.Point(53, 36);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(54, 17);
			this.lblPrecio.TabIndex = 2;
			this.lblPrecio.Text = "Precio";
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(53, 107);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(72, 17);
			this.lblCantidad.TabIndex = 3;
			this.lblCantidad.Text = "Cantidad";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(296, 56);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(53, 233);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(0, 17);
			this.lblTotal.TabIndex = 5;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrar.Location = new System.Drawing.Point(296, 127);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 6;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// lblBienvenida
			// 
			this.lblBienvenida.AutoSize = true;
			this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBienvenida.Location = new System.Drawing.Point(53, 9);
			this.lblBienvenida.Name = "lblBienvenida";
			this.lblBienvenida.Size = new System.Drawing.Size(318, 17);
			this.lblBienvenida.TabIndex = 7;
			this.lblBienvenida.Text = "Bienvenid@ al a calculadora de descuento";
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl.Location = new System.Drawing.Point(394, 36);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(98, 17);
			this.lbl.TabIndex = 8;
			this.lbl.Text = "Descuentos:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(394, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(469, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Comprando de 6 a 10 unidades obtienes un 10% de descuento.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(394, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(475, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Comprando más de 10 unidades obtienes un 20% de descuento.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.lblBienvenida);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtPrecio);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Label lblBienvenida;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

