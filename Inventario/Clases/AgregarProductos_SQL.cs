using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Clases
{
    internal class AgregarProductos_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_TipoProductos()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * From tipoproducto";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                dt.Load(comando.ExecuteReader());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            return dt;
        }
        public bool Agregar_TipoProducto()
        {
            DataTable dt = new DataTable();

            string sql = "Insert Into tipoproducto (Nombre) values (@TipoProducto)";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("TipoProducto", Datos.TipoProducto);
                comando.ExecuteNonQuery();
                conexionBD.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
                conexionBD.Close();
                return false;
            }
        }
        public bool Modificar_TipoProducto()
        {
            string sql = "Update tipoproducto Set Nombre = @Nombre Where idTipoProducto = @idTipoProducto";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("Nombre", Datos.TipoProducto);
                comando.ExecuteNonQuery();
                conexionBD.Close();
                Mensaje = "Empleado modificado correctamente";
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
                conexionBD.Close();
                return false;
            }
        }





        public DataTable Mostrar_Marca()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * From marca";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                dt.Load(comando.ExecuteReader());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            return dt;
        }
        public bool Agregar_Marca()
        {
            DataTable dt = new DataTable();
            string sql = "Insert Into marca (NombreProducto, Marca, idTipoProducto) values (@TipoProducto, @Marca, @idTipoProducto)";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("Marca", Datos.Marca);
                comando.Parameters.AddWithValue("TipoProducto", Datos.TipoProducto);
                comando.Parameters.AddWithValue("idTipoProducto", Datos.IdTipoProducto);
                comando.ExecuteNonQuery();
                conexionBD.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
                conexionBD.Close();
                return false;
            }
        }




        public DataTable Mostrar_Detalles()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * From producto";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                dt.Load(comando.ExecuteReader());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            return dt;
        }
        public bool Agregar_Detalles()
        {
            DataTable dt = new DataTable();
            string sql = "Insert Into producto (Nombre, Marca, Modelo, Costo) values (@Nombre, @Marca, @Modelo, @Costo)";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("Nombre", Datos.TipoProducto);
                comando.Parameters.AddWithValue("Marca", Datos.Marca);
                comando.Parameters.AddWithValue("Modelo", Datos.Modelo);
                comando.Parameters.AddWithValue("Costo", Datos.Costo);
                comando.ExecuteNonQuery();
                conexionBD.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
                conexionBD.Close();
                return false;
            }
        }
        public bool Modificar_Detalles()
        {
            string sql = "Update producto Set Nombre = @Nombre, Marca = @Marca, Modelo = @Modelo, Costo = @Costo Where idproducto = @idproducto";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("idproducto", Datos.IdTipoProducto);
                comando.Parameters.AddWithValue("Nombre", Datos.TipoProducto);
                comando.Parameters.AddWithValue("Marca", Datos.Marca);
                comando.Parameters.AddWithValue("Modelo", Datos.Modelo);
                comando.Parameters.AddWithValue("Costo", Datos.Costo);
                comando.ExecuteNonQuery();
                conexionBD.Close();
                Mensaje = "Empleado modificado correctamente";
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
                conexionBD.Close();
                return false;
            }
        }
    }
}
