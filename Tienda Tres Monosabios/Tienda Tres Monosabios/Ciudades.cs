using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;


namespace Tienda_Tres_Monosabios
{

    public partial class Ciudades : Form
    {

        public Ciudades()
        {
            InitializeComponent();
        }

        public static string obtenerCiudades(string codPais) {
            string apiUrl = string.Format("https://wft-geo-db.p.rapidapi.com/v1/geo/cities?countryIds={0}", codPais);
            HttpWebRequest solicitud = (HttpWebRequest)WebRequest.Create(apiUrl);
            solicitud.Method = "GET";
            solicitud.Headers["x-rapidapi-key"] = "01a3dae2ffmshc99a90f8f92fc71p115d63jsnce7b2fa15966";
            solicitud.Headers["x-rapidapi-host"] = "wft-geo-db.p.rapidapi.com";

            try
            {
                using (WebResponse respuesta = solicitud.GetResponse())
                using (Stream flujo = respuesta.GetResponseStream())
                using (StreamReader lector = new StreamReader(flujo))
                {
                    return lector.ReadToEnd();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ciudades: " + ex.Message);
                return null;
            }

        }

        public class Ciudad
        {
            public string Nombre { get; set; }
            public string Pais { get; set; }
            public string Region { get; set; }
        }

        public class ServicioCiudades
        {
            public static List<Ciudad> 
            ConvertirJson(string json)
            {
                List<Ciudad> listaCiudades = new List<Ciudad>();
                JObject datos = JObject.Parse(json);

                foreach (var item in datos["data"])
                {
                    listaCiudades.Add(new Ciudad
                    {
                        Nombre = item["city"].ToString(),
                        Pais = item["country"].ToString(),
                        Region = item["region"].ToString()
                    });
                }
                return listaCiudades;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ciudades_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarCiudad_Click(object sender, EventArgs e)
        {
            string codPais = textBoxPais.Text.Trim();
            if (string.IsNullOrEmpty(codPais))
            {
                MessageBox.Show("Ingrese un código de país válido");
                return;
            }

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string respuestaJson = Ciudades.obtenerCiudades(codPais);
            if (!
                string.IsNullOrEmpty(respuestaJson))
            {
                List<Ciudad> ciudades = ServicioCiudades.ConvertirJson(respuestaJson);
                dataGridViewCiudades.DataSource = ciudades;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrearCiudad_Click(object sender, EventArgs e)
        {
            if (dataGridViewCiudades.SelectedRows.Count > 0)
            {
               
                Ciudad ciudadSeleccionada = new Ciudad
                {
                    Nombre = dataGridViewCiudades.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                    Pais = dataGridViewCiudades.SelectedRows[0].Cells["Pais"].Value.ToString(),
                    Region = dataGridViewCiudades.SelectedRows[0].Cells["Region"].Value.ToString()
                };

                ConexionBD registroCiudad = new ConexionBD();

                registroCiudad.GuardarCiudad(ciudadSeleccionada);

               
            }
            else
            {
                MessageBox.Show("Selecciona una ciudad de la lista.");
            }
        }
        //706; 474

    }
}
