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
    internal class Activo_SQL
    {
        public DataTable Mostrar_Activo()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * From activo";
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
        public DataTable Mostrar_Producto()
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
        public DataTable Mostrar_Site()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * From site";
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

        public bool Agregar_Activo()
        {
            DataTable dt = new DataTable();
            string sql = "Insert Into activo (Nombre, Marca, Modelo, Color, IMEI, NumeroSerie, Estado, UltimaRevision, Costo, idSite, idProducto) values (@Nombre, @Marca, @Modelo, @Color, @IMEI, @NumeroSerie, @Estado, @UltimaRevision, @Costo, @idSite, @idProducto)";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("Nombre", Datos.TipoProducto);
                comando.Parameters.AddWithValue("Marca", Datos.Marca);
                comando.Parameters.AddWithValue("Modelo", Datos.Modelo);
                comando.Parameters.AddWithValue("Color", Datos.Color);
                comando.Parameters.AddWithValue("IMEI", Datos.IMEI);
                comando.Parameters.AddWithValue("NumeroSerie", Datos.Serie);
                comando.Parameters.AddWithValue("Estado", Datos.Estado);
                comando.Parameters.AddWithValue("UltimaRevision", DateTime.Now);
                comando.Parameters.AddWithValue("Costo", Datos.Costo);
                comando.Parameters.AddWithValue("idSite", 1);
                comando.Parameters.AddWithValue("idProducto", 1);
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
    }
}
