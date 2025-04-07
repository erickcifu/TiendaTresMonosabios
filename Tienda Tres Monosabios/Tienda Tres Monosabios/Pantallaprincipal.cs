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
    public partial class Pantallaprincipal : Form
    {
        public Pantallaprincipal()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSubConfig.Visible = false;

        }

        private void esconderSubMenu()
        {
            if (panelSubConfig.Visible == true)
            {
                panelSubConfig.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form formActivo = null;
        private void panelFormulario(Form formulario)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formulario);
            panelPrincipal.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        private void panelSubConfig_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void buttonCiudades_Click(object sender, EventArgs e)
        {
            panelFormulario(new Ciudades());
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubConfig);
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            panelFormulario(new Productos());
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            panelFormulario(new Clientes());
        }
    }
}
