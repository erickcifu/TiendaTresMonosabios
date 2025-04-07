namespace Tienda_Tres_Monosabios
{
    partial class Productos
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.buttonCrearProducto = new System.Windows.Forms.Button();
            this.buttonEditarProducto = new System.Windows.Forms.Button();
            this.buttonEliminarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(50, 89);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowTemplate.Height = 28;
            this.dataGridViewProductos.Size = new System.Drawing.Size(771, 398);
            this.dataGridViewProductos.TabIndex = 2;
            // 
            // buttonCrearProducto
            // 
            this.buttonCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearProducto.Location = new System.Drawing.Point(829, 89);
            this.buttonCrearProducto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrearProducto.Name = "buttonCrearProducto";
            this.buttonCrearProducto.Size = new System.Drawing.Size(130, 82);
            this.buttonCrearProducto.TabIndex = 3;
            this.buttonCrearProducto.Text = "Crear producto";
            this.buttonCrearProducto.UseVisualStyleBackColor = true;
            this.buttonCrearProducto.Click += new System.EventHandler(this.buttonCrearProducto_Click);
            // 
            // buttonEditarProducto
            // 
            this.buttonEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarProducto.Location = new System.Drawing.Point(829, 190);
            this.buttonEditarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarProducto.Name = "buttonEditarProducto";
            this.buttonEditarProducto.Size = new System.Drawing.Size(130, 73);
            this.buttonEditarProducto.TabIndex = 4;
            this.buttonEditarProducto.Text = "Editar producto";
            this.buttonEditarProducto.UseVisualStyleBackColor = true;
            this.buttonEditarProducto.Click += new System.EventHandler(this.buttonEditarProducto_Click);
            // 
            // buttonEliminarProducto
            // 
            this.buttonEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarProducto.Location = new System.Drawing.Point(829, 281);
            this.buttonEliminarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarProducto.Name = "buttonEliminarProducto";
            this.buttonEliminarProducto.Size = new System.Drawing.Size(130, 80);
            this.buttonEliminarProducto.TabIndex = 5;
            this.buttonEliminarProducto.Text = "Eliminar producto";
            this.buttonEliminarProducto.UseVisualStyleBackColor = true;
            this.buttonEliminarProducto.Click += new System.EventHandler(this.buttonEliminarProducto_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.buttonEliminarProducto);
            this.Controls.Add(this.buttonEditarProducto);
            this.Controls.Add(this.buttonCrearProducto);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button buttonCrearProducto;
        private System.Windows.Forms.Button buttonEditarProducto;
        private System.Windows.Forms.Button buttonEliminarProducto;
    }
}