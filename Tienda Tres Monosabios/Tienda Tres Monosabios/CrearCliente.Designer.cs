namespace Tienda_Tres_Monosabios
{
    partial class CrearCliente
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
            this.buttonGuardarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.textBoxTeléfono = new System.Windows.Forms.TextBox();
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardarCliente
            // 
            this.buttonGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCliente.Location = new System.Drawing.Point(809, 491);
            this.buttonGuardarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarCliente.Name = "buttonGuardarCliente";
            this.buttonGuardarCliente.Size = new System.Drawing.Size(142, 46);
            this.buttonGuardarCliente.TabIndex = 10;
            this.buttonGuardarCliente.Text = "Guardar";
            this.buttonGuardarCliente.UseVisualStyleBackColor = true;
            this.buttonGuardarCliente.Click += new System.EventHandler(this.buttonGuardarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBoxCiudad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxDireccion);
            this.panel1.Controls.Add(this.textBoxNit);
            this.panel1.Controls.Add(this.textBoxTeléfono);
            this.panel1.Controls.Add(this.textBoxDPI);
            this.panel1.Controls.Add(this.textBoxNombreCliente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(55, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 398);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(612, 241);
            this.textBoxNit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNit.Multiline = true;
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(247, 30);
            this.textBoxNit.TabIndex = 10;
            // 
            // textBoxTeléfono
            // 
            this.textBoxTeléfono.Location = new System.Drawing.Point(159, 242);
            this.textBoxTeléfono.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTeléfono.Name = "textBoxTeléfono";
            this.textBoxTeléfono.Size = new System.Drawing.Size(235, 29);
            this.textBoxTeléfono.TabIndex = 9;
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Location = new System.Drawing.Point(603, 54);
            this.textBoxDPI.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDPI.Multiline = true;
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(256, 30);
            this.textBoxDPI.TabIndex = 7;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(147, 52);
            this.textBoxNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreCliente.Multiline = true;
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(334, 30);
            this.textBoxNombreCliente.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "NIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "DPI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(296, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "---------- CREAR CLIENTE ----------";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(147, 150);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(334, 30);
            this.textBoxDireccion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ciudad";
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(636, 148);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(223, 32);
            this.comboBoxCiudad.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 317);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha de nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 29);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // CrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.buttonGuardarCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "CrearCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.TextBox textBoxTeléfono;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDireccion;

    }
}