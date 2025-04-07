using Inventario.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario
{
    public partial class AgregarProductos : MaterialSkin.Controls.MaterialForm
    {
        AgregarProductos_SQL agregarProductos = new AgregarProductos_SQL();
        public static int idTipoProducto;
        public static DataTable data;
        public AgregarProductos()
        {
            InitializeComponent();
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            TipoProductoTxt.Text = "";
            TipoProductoSelect.Items.Clear();
            TipoProductoSelect.Text = "";
            MarcaTxt.Text = "";
            TipoProductoDetallesTxt.Text = "";
            MarcaSelect.Items.Clear();
            MarcaSelect.Text = "";
            ModeloTxt.Text = "";
            CostoTxt.Text = "";

            DataTable dtTipo = agregarProductos.Mostrar_TipoProductos();
            TipoProductoDGV.DataSource = dtTipo;

            DataTable dtMarca = agregarProductos.Mostrar_Marca();
            MarcaDGV.DataSource = dtMarca;

            foreach (DataRow row in dtTipo.Rows)
            {
                TipoProductoSelect.Items.Add(new { Display = row["Nombre"].ToString(), Value = row["idTipoProducto"].ToString()});
            }
            TipoProductoSelect.DisplayMember = "Display";

            foreach (DataRow row in dtMarca.Rows)
            {
                MarcaSelect.Items.Add(row["Marca"].ToString());
            }

            DetallesDGV.DataSource = agregarProductos.Mostrar_Detalles();
        }

        private void AgregarTipoBtn_Click(object sender, EventArgs e)
        {
            Datos.TipoProducto = TipoProductoTxt.Text;

            if(TipoProductoTxt.Text == "")
            {
                MessageBox.Show("Ingrese un tipo de producto");
                return;
            }
            else if(agregarProductos.Agregar_TipoProducto())
            {
                MessageBox.Show("Tipo de producto agregado");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al agregar tipo de producto");
            }
        }
        private void ModificarTipoBtn_Click(object sender, EventArgs e)
        {
            Datos.TipoProducto = TipoProductoTxt.Text;
            Datos.IdTipoProducto = idTipoProducto;
        }
        private void TipoProductoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int renglon = TipoProductoDGV.CurrentRow.Index;
            TipoProductoTxt.Text = TipoProductoDGV.Rows[renglon].Cells[1].Value.ToString();
            idTipoProducto = Convert.ToInt32(TipoProductoDGV.Rows[renglon].Cells[0].Value.ToString());
        }
        private void ElimarTipoBtn_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarTipoBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        
        private void AgregarMarcabtn_Click(object sender, EventArgs e)
        {
            var selectedItem = TipoProductoSelect.SelectedItem;
            var value = selectedItem.GetType().GetProperty("Value").GetValue(selectedItem, null);

            Datos.TipoProducto = TipoProductoSelect.Text;
            Datos.Marca = MarcaTxt.Text;
            Datos.IdTipoProducto = Convert.ToInt32(value);
            if (TipoProductoSelect.Text == "" || (MarcaTxt.Text == "" || MarcaTxt.Text == null))
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            else if (agregarProductos.Agregar_Marca())
            {
                MessageBox.Show("Marca agregada");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al agregar marca");
            }
        }
        private void ModificarMarcaBtn_Click(object sender, EventArgs e)
        {

        }
        private void EliminarMarcaBtn_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarMarcaBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void AgregarDetallesBtn_Click(object sender, EventArgs e)
        {
            Datos.TipoProducto = TipoProductoDetallesTxt.Text;
            Datos.Marca = MarcaSelect.Text;
            Datos.Modelo = ModeloTxt.Text;
            Datos.Costo = CostoTxt.Text;

            if (TipoProductoDetallesTxt.Text == "" || ModeloTxt.Text == "" || CostoTxt.Text == "" || (MarcaSelect.Text == "" || MarcaSelect.Text == null))
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            else if (agregarProductos.Agregar_Detalles())
            {
                MessageBox.Show("Detalles agregados");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al agregar detalles");
            }
        }
        private void ModificarDetallesBtn_Click(object sender, EventArgs e)
        {
            Datos.TipoProducto = TipoProductoTxt.Text;
            Datos.IdTipoProducto = idTipoProducto;
            Datos.Marca = MarcaTxt.Text;
            Datos.Modelo = ModeloTxt.Text;
            Datos.Costo = CostoTxt.Text;
        }
        private void DetallesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int renglon = DetallesDGV.CurrentRow.Index;
            idTipoProducto = Convert.ToInt32(DetallesDGV.Rows[renglon].Cells[0].Value.ToString());
            TipoProductoDetallesTxt.Text = DetallesDGV.Rows[renglon].Cells[1].Value.ToString();
            MarcaSelect.Text = DetallesDGV.Rows[renglon].Cells[2].Value.ToString();
            ModeloTxt.Text = DetallesDGV.Rows[renglon].Cells[3].Value.ToString();
            CostoTxt.Text = DetallesDGV.Rows[renglon].Cells[4].Value.ToString();
        }
        private void EliminarDetallesBtn_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarDetallesBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void MarcaSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtMarca = agregarProductos.Mostrar_Marca();

            foreach (DataRow row in dtMarca.Rows)
            {
                if (row["Marca"].ToString() == MarcaSelect.Text)
                {
                    TipoProductoDetallesTxt.Text = row["NombreProducto"].ToString();
                }
            }
        }
    }
}
