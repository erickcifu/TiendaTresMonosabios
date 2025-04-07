using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Tienda_Tres_Monosabios
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contrasenia;
            usuario = textBox1.Text;
            contrasenia = textBox2.Text;

           
            
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; Database = tienda; User Id=root; password= '' ");
            try
            {
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }

            String consulta = "select Usuario,Contrasenia from usuarios where Usuario =  '"+usuario+"' AND Contrasenia = '"+contrasenia+"' ";
            MySqlCommand cmd = new MySqlCommand(consulta,conexion);
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                this.Hide();
                Pantallaprincipal form2 = new Pantallaprincipal();
                 form2.Show();
            }
            else
            {
                MessageBox.Show("No existe el usuario " + usuario);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
