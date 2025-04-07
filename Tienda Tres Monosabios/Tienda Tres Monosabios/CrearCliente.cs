using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Tres_Monosabios
{
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
            ConexionBD conexion = new ConexionBD();
            conexion.CmbCiudades(comboBoxCiudad);
        }

        public class Cliente
        {
            public string NombreCliente { get; set; }
            public int Nit { get; set; }
            public int DPI { get; set; }
            public string Direccion { get; set; }
            public int Telefono { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public int idCiudad { get; set; }
        }

        ErrorProvider errorProvider = new ErrorProvider();

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            string NombreCliente = textBoxNombreCliente.Text.Trim();
            int Nit = 0;
            int DPI = 0;
            string Direccion = textBoxDireccion.Text.Trim();
            int Telefono = 0;
            DateTime FechaNacimiento = dateTimePicker1.Value;
            
            int idCiudadSeleccionada = ((KeyValuePair<int, string>)comboBoxCiudad.SelectedItem).Key;
            int idCiudad = idCiudadSeleccionada;

            string mensaje = "Este campo no puede estar vacío";
            //-----VALIDACIONES-----
            //Nombre de cliente
            if (string.IsNullOrWhiteSpace(textBoxNombreCliente.Text))
            {
                errorProvider.SetError(textBoxNombreCliente, mensaje);
                return;
            }
            else
            {
                errorProvider.SetError(textBoxNombreCliente, string.Empty);
            }
            //Dirección
            if (string.IsNullOrWhiteSpace(textBoxDireccion.Text))
            {
                errorProvider.SetError(textBoxDireccion, mensaje);
                return;
            }
            else
            {
                errorProvider.SetError(textBoxDireccion, string.Empty);
            }
            //Fecha de nacimiento
            if (dateTimePicker1.Value >= DateTime.Today)
            {
                errorProvider.SetError(dateTimePicker1, "La fecha de nacimiento no puede ser en el futuro.");
                return;
            }
            else
            {
                errorProvider.SetError(dateTimePicker1, string.Empty);
            }
            //Nit
            if (!int.TryParse(textBoxNit.Text, out Nit) || Nit < 0  || string.IsNullOrWhiteSpace(textBoxNit.Text))
            {
                errorProvider.SetError(textBoxNit, "Por favor ingresa un NIT válido.");
                return;
            }
            else
            {
                errorProvider.SetError(textBoxNit, string.Empty);
            }
            //DPI
            if (!int.TryParse(textBoxDPI.Text, out DPI) || DPI < 0  || string.IsNullOrWhiteSpace(textBoxDPI.Text))
            {
                errorProvider.SetError(textBoxDPI, "Por favor ingresa un DPI válido.");
                return;
            }
            else
            {
                errorProvider.SetError(textBoxDPI, string.Empty);
            }
            //Teléfono
            if (!int.TryParse(textBoxTeléfono.Text, out Telefono) || Telefono < 0 || string.IsNullOrWhiteSpace(textBoxTeléfono.Text))
            {
                errorProvider.SetError(textBoxTeléfono, "Por favor ingresa un teléfono válido.");
                return;
            }
            else
            {
                errorProvider.SetError(textBoxTeléfono, string.Empty);
            }
            if (comboBoxCiudad.SelectedItem == null)
            {
                errorProvider.SetError(comboBoxCiudad, "Por favor selecciona una ciudad.");
                return;
            }
            else
            {
                errorProvider.SetError(comboBoxCiudad, string.Empty);
            }

            Cliente cliente = new Cliente
            {
                NombreCliente = NombreCliente,
                Nit = Nit,
                DPI = DPI,
                Direccion = Direccion,
                Telefono = Telefono,
                FechaNacimiento = FechaNacimiento,
                idCiudad = idCiudadSeleccionada
            };

            //INSERTAR PRODUCTO A BD
            ConexionBD registroCliente = new ConexionBD();
            registroCliente.GuardarCliente(idCiudad, cliente);
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
