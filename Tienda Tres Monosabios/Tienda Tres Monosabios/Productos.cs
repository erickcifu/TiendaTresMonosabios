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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            ConexionBD conexion = new ConexionBD();
            conexion.CargarProductos(dataGridViewProductos);
            dataGridViewProductos.Columns["nombreProducto"].DisplayIndex = 1;
        }


        private void buttonCrearProducto_Click(object sender, EventArgs e)
        {
            CrearProducto formCrearProducto = new CrearProducto();
            formCrearProducto.Show();

            ConexionBD conexion = new ConexionBD();
            conexion.CargarProductos(dataGridViewProductos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                int Idproducto = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells["Idproducto"].Value);
                string Descripcion = dataGridViewProductos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                float Precio = (float)Convert.ToDecimal(dataGridViewProductos.SelectedRows[0].Cells["Precio"].Value);
                string Categoria = dataGridViewProductos.SelectedRows[0].Cells["Categoria"].Value.ToString();
                int Cantidad = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells["Cantidad"].Value);
                string nombreProducto = dataGridViewProductos.SelectedRows[0].Cells["nombreProducto"].Value.ToString();

                EditarProducto formEditar = new EditarProducto(Idproducto, Descripcion, Precio, Categoria, Cantidad, nombreProducto);
                formEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                int Idproducto = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells["Idproducto"].Value);
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?",
                                                         "Confirmación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    ConexionBD conexion = new ConexionBD();
                    conexion.EliminarProducto(Idproducto);
                    conexion.CargarProductos(dataGridViewProductos);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
