namespace Tienda_Tres_Monosabios
{
    partial class Clientes
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.buttonCrearCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 105);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowTemplate.Height = 31;
            this.dataGridViewClientes.Size = new System.Drawing.Size(799, 162);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // buttonCrearCliente
            // 
            this.buttonCrearCliente.Location = new System.Drawing.Point(817, 110);
            this.buttonCrearCliente.Name = "buttonCrearCliente";
            this.buttonCrearCliente.Size = new System.Drawing.Size(155, 35);
            this.buttonCrearCliente.TabIndex = 1;
            this.buttonCrearCliente.Text = "Crear Cliente";
            this.buttonCrearCliente.UseVisualStyleBackColor = true;
            this.buttonCrearCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(817, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(817, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 345);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 31;
            this.dataGridView2.Size = new System.Drawing.Size(847, 135);
            this.dataGridView2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(866, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 72);
            this.button4.TabIndex = 5;
            this.button4.Text = "Agregar producto";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 13);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "---- Clientes -----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "---- Productos de cliente ";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1002, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCrearCliente);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button buttonCrearCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}