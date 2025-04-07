namespace Tienda_Tres_Monosabios
{
    partial class CrearProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonGuardarProducto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(265, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "---------- CREAR PRODUCTO ----------";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxPrecio);
            this.panel1.Controls.Add(this.textBoxCantidad);
            this.panel1.Controls.Add(this.textBoxDescripcion);
            this.panel1.Controls.Add(this.textBoxCategoria);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(56, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 398);
            this.panel1.TabIndex = 6;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(612, 275);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecio.Multiline = true;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(247, 30);
            this.textBoxPrecio.TabIndex = 10;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(161, 271);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(235, 29);
            this.textBoxCantidad.TabIndex = 9;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(214, 151);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescripcion.Size = new System.Drawing.Size(646, 77);
            this.textBoxDescripcion.TabIndex = 8;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(612, 54);
            this.textBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCategoria.Multiline = true;
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(247, 30);
            this.textBoxCategoria.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(147, 52);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(250, 30);
            this.textBoxNombre.TabIndex = 6;
            // 
            // buttonGuardarProducto
            // 
            this.buttonGuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarProducto.Location = new System.Drawing.Point(810, 487);
            this.buttonGuardarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarProducto.Name = "buttonGuardarProducto";
            this.buttonGuardarProducto.Size = new System.Drawing.Size(142, 46);
            this.buttonGuardarProducto.TabIndex = 7;
            this.buttonGuardarProducto.Text = "Guardar";
            this.buttonGuardarProducto.UseVisualStyleBackColor = true;
            this.buttonGuardarProducto.Click += new System.EventHandler(this.buttonGuardarProducto_Click);
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.buttonGuardarProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CrearProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonGuardarProducto;
    }
}