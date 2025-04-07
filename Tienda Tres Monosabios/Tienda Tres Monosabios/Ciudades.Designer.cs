namespace Tienda_Tres_Monosabios
{
    partial class Ciudades
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarCiudad = new System.Windows.Forms.Button();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCrearCiudad = new System.Windows.Forms.Button();
            this.dataGridViewCiudades = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "---- Ciudades obtenidas desde RapidAPI -----";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonBuscarCiudad
            // 
            this.buttonBuscarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCiudad.Location = new System.Drawing.Point(526, 115);
            this.buttonBuscarCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscarCiudad.Name = "buttonBuscarCiudad";
            this.buttonBuscarCiudad.Size = new System.Drawing.Size(216, 40);
            this.buttonBuscarCiudad.TabIndex = 4;
            this.buttonBuscarCiudad.Text = "Buscar en API";
            this.buttonBuscarCiudad.UseVisualStyleBackColor = true;
            this.buttonBuscarCiudad.Click += new System.EventHandler(this.buttonBuscarCiudad_Click);
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(286, 119);
            this.textBoxPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(195, 29);
            this.textBoxPais.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código de país";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonCrearCiudad
            // 
            this.buttonCrearCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearCiudad.Location = new System.Drawing.Point(625, 392);
            this.buttonCrearCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCrearCiudad.Name = "buttonCrearCiudad";
            this.buttonCrearCiudad.Size = new System.Drawing.Size(148, 77);
            this.buttonCrearCiudad.TabIndex = 9;
            this.buttonCrearCiudad.Text = "Guardar Ciudad";
            this.buttonCrearCiudad.UseVisualStyleBackColor = true;
            this.buttonCrearCiudad.Click += new System.EventHandler(this.buttonCrearCiudad_Click);
            // 
            // dataGridViewCiudades
            // 
            this.dataGridViewCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCiudades.Location = new System.Drawing.Point(68, 224);
            this.dataGridViewCiudades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCiudades.Name = "dataGridViewCiudades";
            this.dataGridViewCiudades.RowTemplate.Height = 28;
            this.dataGridViewCiudades.Size = new System.Drawing.Size(549, 245);
            this.dataGridViewCiudades.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(625, 308);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 77);
            this.button2.TabIndex = 11;
            this.button2.Text = "Mis Ciudades";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Ciudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(836, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewCiudades);
            this.Controls.Add(this.buttonCrearCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.buttonBuscarCiudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ciudades";
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.Ciudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarCiudad;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCrearCiudad;
        private System.Windows.Forms.DataGridView dataGridViewCiudades;
        private System.Windows.Forms.Button button2;
    }
}