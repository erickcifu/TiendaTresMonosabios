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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            ConexionBD conexion = new ConexionBD();
            conexion.CargarClientes(dataGridViewClientes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearCliente formCrearCliente = new CrearCliente();
            formCrearCliente.Show();


            ConexionBD conexion = new ConexionBD();
            conexion.CargarClientes(dataGridViewClientes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Editar cliente
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int IdCliente = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["IdCliente"].Value);
                string NombreCliente = dataGridViewClientes.SelectedRows[0].Cells["NombreCliente"].Value.ToString();
                int Nit = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["Nit"].Value);
                int DPI = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["DPI"].Value);
                string Direccion = dataGridViewClientes.SelectedRows[0].Cells["Direccion"].Value.ToString();
                int Telefono = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["Telefono"].Value);
                DateTime FechaNacimiento = Convert.ToDateTime(dataGridViewClientes.SelectedRows[0].Cells["FechaNacimiento"].Value);
                int idCiudad = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["idCiudad"].Value);

                EditarCliente formEditarCliente = new EditarCliente(IdCliente, NombreCliente, Nit, DPI, Direccion, Telefono, FechaNacimiento, idCiudad);
                formEditarCliente.ShowDialog();

                ConexionBD conexion = new ConexionBD();
                conexion.CargarClientes(dataGridViewClientes);
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int Idclient = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["IdCliente"].Value);
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?",
                                                         "Confirmación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    ConexionBD conexion = new ConexionBD();
                    conexion.EliminarCliente(Idclient);
                    conexion.CargarClientes(dataGridViewClientes);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
