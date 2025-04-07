using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace Tienda_Tres_Monosabios
{
    class ConexionBD
    {
        private string cadenaConexion = "Server=localhost; Database=tienda; User ID=root; Password=''";

        //CIUDADES
        public bool CiudadExiste(string nombreCiudad)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM ciudades WHERE NombreCiudad = @Nombre ";
                MySqlCommand comandoquery = new MySqlCommand(query, conexion);
                comandoquery.Parameters.AddWithValue("@Nombre", nombreCiudad);
                int cantidad = Convert.ToInt32(comandoquery.ExecuteScalar());
                return cantidad >  0;
            }
        }

        public void GuardarCiudad(Ciudades.Ciudad ciudad)
        {
            if (CiudadExiste(ciudad.Nombre))
            {
                MessageBox.Show("La ciudad ya existe en la base de datos");
                
            }
            else
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        string insertar = "INSERT INTO ciudades (NombreCiudad, Pais, Region) VALUES (@Nombre, @Pais, @Region)";
                        MySqlCommand comando = new MySqlCommand(insertar, conexion);
                        comando.Parameters.AddWithValue("@Nombre", ciudad.Nombre);
                        comando.Parameters.AddWithValue("@Pais", ciudad.Pais);
                        comando.Parameters.AddWithValue("@Region", ciudad.Region);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Ciudad guardada correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
        }

        public void CargarCiudadesBD()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string traerCiudades = "SELECT * FROM ciudades";
                    MySqlCommand comandoCiudades = new MySqlCommand(traerCiudades, conexion);
                    
                    conexion.Open();
                    comandoCiudades.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ciudades: " + ex.Message);
            }
        }

        public void EditarCiudad(int id, Ciudades.Ciudad ciudad)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string actualizar = "UPDATE ciudades SET NombreCiudad = @Nombre, Pais = @Pais, Region = @Region WHERE IdCiudad = @Id";
                    MySqlCommand comando = new MySqlCommand(actualizar, conexion);
                    comando.Parameters.AddWithValue("@Nombre", ciudad.Nombre);
                    comando.Parameters.AddWithValue("@Pais", ciudad.Pais);
                    comando.Parameters.AddWithValue("@Region", ciudad.Region);
                    comando.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("Ciudad actualizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar ciudad: " + ex.Message);
            }
        }


        //PRODUCTOS
        public void CargarProductos(DataGridView dataGridViewProductos)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string traerProductos = "SELECT * FROM productos";
                    MySqlDataAdapter comandoProductos = new MySqlDataAdapter(traerProductos, conexion);
                    DataTable dtProductos = new DataTable();
                    comandoProductos.Fill(dtProductos);
                    dataGridViewProductos.DataSource = dtProductos; 
                    
                    conexion.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        //Guardar
        public bool ProductoExiste(string nombreProducto)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM productos WHERE nombreProducto = @nombreProducto ";
                MySqlCommand queryProd = new MySqlCommand(query, conexion);
                queryProd.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                int cantidad = Convert.ToInt32(queryProd.ExecuteScalar());
                return cantidad > 0;
            }
        }

        public void GuardarProducto(CrearProducto.Producto producto)
        {
            if (ProductoExiste(producto.nombreProducto))
            {
                MessageBox.Show("Producto ya existe en la base de datos");

            }
            else
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        string insertar = "INSERT INTO productos (Descripcion, Precio, Categoria, Cantidad, nombreProducto) VALUES (@Descripcion, @Precio, @Categoria, @Cantidad, @nombreProducto)";
                        MySqlCommand comando = new MySqlCommand(insertar, conexion);
                        comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                        comando.Parameters.AddWithValue("@Precio", producto.Precio);
                        comando.Parameters.AddWithValue("@Categoria", producto.Categoria);
                        comando.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                        comando.Parameters.AddWithValue("@nombreProducto", producto.nombreProducto);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Producto guardado correctamente.");
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
        }

        //Editar
        public void EditarProducto(int Idprod, EditarProducto.Producto producto)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string actualizarProd = "UPDATE productos SET Descripcion = @Descripcion, Precio = @Precio, Categoria = @Categoria, Cantidad = @Cantidad, nombreProducto = @nombreProducto WHERE Idproducto = @Idproducto";
                    MySqlCommand comando = new MySqlCommand(actualizarProd, conexion);
                    comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@Categoria", producto.Categoria);
                    comando.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    comando.Parameters.AddWithValue("@nombreProducto", producto.nombreProducto);
                    comando.Parameters.AddWithValue("@Idproducto", Idprod);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("Producto actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }
        }


        //Eliminar
        public void EliminarProducto(int Idprod)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string eliminarProd = "DELETE FROM productos WHERE Idproducto = @Idproducto";

                    MySqlCommand comando = new MySqlCommand(eliminarProd, conexion);
                    comando.Parameters.AddWithValue("@Idproducto", Idprod);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        MessageBox.Show("Producto eliminado correctamente.");
                    else
                        MessageBox.Show("No se encontró el producto para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
        }

        //Clientes
        public void CargarClientes(DataGridView dataGridViewClientes)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                string consulta = "SELECT IdCliente, NombreCliente, Nit, DPI, Direccion, Telefono, FechaNacimiento, IdCiudad FROM clientes";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridViewClientes.DataSource = dt;

                conexion.Open();
            }
        }

        //Cargar ciudades en ComboBox
        public void CmbCiudades(ComboBox comboBoxCiudad)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                string consulta = "SELECT IdCiudad, NombreCiudad FROM ciudades"; 
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    MySqlDataReader reader = comando.ExecuteReader();
                    List<KeyValuePair<int, string>> listaCiudades = new List<KeyValuePair<int, string>>();

                    while (reader.Read())
                    {
                        int idCiudad = reader.GetInt32("IdCiudad");
                        string nombreCiudad = reader.GetString("NombreCiudad");

                        listaCiudades.Add(new KeyValuePair<int, string>(idCiudad, nombreCiudad));
                    }

                    comboBoxCiudad.DataSource = listaCiudades;
                    comboBoxCiudad.DisplayMember = "Value"; 
                    comboBoxCiudad.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar ciudades: " + ex.Message);
                }
            }
        }

        //Crear Cliente
        public void GuardarCliente(int idCiudadSeleccionada, CrearCliente.Cliente cliente)
        {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        string insertarCliente = "INSERT INTO clientes (NombreCliente, Nit, DPI, Direccion, Telefono, FechaNacimiento, idCiudad ) VALUES (@NombreCliente, @Nit, @DPI, @Direccion, @Telefono, @FechaNacimiento, @idCiudad)";
                        MySqlCommand comando = new MySqlCommand(insertarCliente, conexion);
                        comando.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                        comando.Parameters.AddWithValue("@Nit", cliente.Nit);
                        comando.Parameters.AddWithValue("@DPI", cliente.DPI);
                        comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                        comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                        comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                        comando.Parameters.AddWithValue("@idCiudad", idCiudadSeleccionada);

                        try
                        {
                            conexion.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Cliente agregado correctamente.");
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al agregar cliente: " + ex.Message);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
        }

        //Editar
        public void EditarCliente(int Idclient, EditarCliente.Cliente cliente)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string actualizarProd = "UPDATE clientes SET NombreCliente = @NombreCliente, Nit = @Nit, DPI = @DPI, Direccion = @Direccion, Telefono = @Telefono, FechaNacimiento = @FechaNacimiento, IdCiudad = @IdCiudad  WHERE IdCliente = @IdCliente";
                    MySqlCommand comando = new MySqlCommand(actualizarProd, conexion);
                    comando.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                    comando.Parameters.AddWithValue("@Nit", cliente.Nit);
                    comando.Parameters.AddWithValue("@DPI", cliente.DPI);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@IdCiudad", cliente.IdCiudad);
                    comando.Parameters.AddWithValue("@IdCliente", Idclient);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("Cliente actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cliente: " + ex.Message);
            }
        }


        //Eliminar
        public void EliminarCliente(int Idclient)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    string eliminarCliente = "DELETE FROM clientes WHERE IdCliente = @IdCliente";

                    MySqlCommand comando = new MySqlCommand(eliminarCliente, conexion);
                    comando.Parameters.AddWithValue("@IdCliente", Idclient);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        MessageBox.Show("Cliente eliminado correctamente.");
                    else
                        MessageBox.Show("No se encontró el cliente para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
            }
        }

    }
}
