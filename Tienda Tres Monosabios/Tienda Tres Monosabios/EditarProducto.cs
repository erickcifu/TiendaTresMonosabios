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
    public partial class EditarProducto : Form
    {
        private int Idprod;
        ErrorProvider errorProvider = new ErrorProvider();

        public EditarProducto(int Idproducto, string Descripcion, float Precio, string Categoria, int Cantidad, string nombreProducto)
        {
            InitializeComponent();

            Idprod = Idproducto;
            textBoxDescripcion.Text = Descripcion;
            textBoxPrecio.Text = Precio.ToString();
            textBoxCategoria.Text = Categoria;
            textBoxCantidad.Text = Cantidad.ToString();
            textBoxNombre.Text = nombreProducto;

        }

        public class Producto
        {
            public string nombreProducto { get; set; }
            public string Descripcion { get; set; }
            public float Precio { get; set; }
            public string Categoria { get; set; }
            public int Cantidad { get; set; }
        }

        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {

            string nombreProd = textBoxNombre.Text.Trim();
            string descripcionProd = textBoxDescripcion.Text.Trim();
            float precioProd = 0;
            string categoriaProd = textBoxCategoria.Text.Trim();
            int cantidadProd = 0;

            string mensaje = "Este campo no puede estar vacío";
            //-----VALIDACIONES-----
            //Nombre de producto
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                errorProvider.SetError(textBoxNombre, mensaje);
                return;
            }
            else
            {
                errorProvider.SetError(textBoxNombre, string.Empty);
            }
            //Categoria de producto
            if (string.IsNullOrWhiteSpace(textBoxCategoria.Text))
            {
                errorProvider.SetError(textBoxCategoria, mensaje);
                return;
            }
            else
            {
                errorProvider.SetError(textBoxCategoria, string.Empty);
            }
            //Cantidad de producto (Stock)
            if (!int.TryParse(textBoxCantidad.Text, out cantidadProd) || cantidadProd < 0 || string.IsNullOrWhiteSpace(textBoxCantidad.Text))
            {
                errorProvider.SetError(textBoxCantidad, "Por favor ingresa un número entero válido.");
                return;
            }
            else
            {
                errorProvider.SetError(textBoxCantidad, string.Empty);
            }
            //Precio de producto
            if (!float.TryParse(textBoxPrecio.Text, out precioProd) || precioProd < 0 || string.IsNullOrWhiteSpace(textBoxPrecio.Text))
            {
                errorProvider.SetError(textBoxPrecio, "Por favor ingresa un número entero válido.");
                return;
            }
            else
            {
                errorProvider.SetError(textBoxPrecio, string.Empty);
            }

            Producto producto = new Producto
            {
                nombreProducto = nombreProd,
                Descripcion = descripcionProd,
                Precio = precioProd,
                Categoria = categoriaProd,
                Cantidad = cantidadProd
            };

            //INSERTAR PRODUCTO A BD
            ConexionBD editarProducto = new ConexionBD();
            editarProducto.EditarProducto(Idprod, producto);
            this.Close();

        }
    }
}
