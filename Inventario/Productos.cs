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

namespace Inventario
{
    public partial class Productos : MaterialSkin.Controls.MaterialForm
    {
        Activo_SQL activo_SQL = new Activo_SQL();
        public static DataTable dtProductos;
        public Productos()
        {
            InitializeComponent();
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            List<string> miLista = new List<string>();

            TipoProductoCB.Items.Clear();
            SiteCB.Items.Clear();
            CostoTxt.Text = "";
            IMEITXT.Text = "";
            NumSerieTxt.Text = "";

            ActivoDGV.DataSource = activo_SQL.Mostrar_Activo();
            dtProductos = activo_SQL.Mostrar_Producto();
            DataTable dtSite = activo_SQL.Mostrar_Site();

            HashSet<string> unicos = new HashSet<string>();
            string dato = "";

            foreach (DataRow item in dtProductos.Rows)
            {
                dato = item["Nombre"].ToString();
                if (unicos.Add(dato)) // Solo se agregan los que no estaban antes
                {
                    TipoProductoCB.Items.Add(dato); // ← Aquí el cambio
                }
            }

            foreach (DataRow row in dtSite.Rows)
            {
                SiteCB.Items.Add(new { Display = row["NombreSite"].ToString(), Value = row["idSite"].ToString() });
            }
            SiteCB.DisplayMember = "Display";

            MarcaCB.Items.Clear();
            ModeloCB.Items.Clear();
            MarcaCB.Enabled = false;
            ModeloCB.Enabled = false;
            MarcaCB.Text = "";
            ModeloCB.Text = "";
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            if(TipoProductoCB.Text == "" || MarcaCB.Text == "" || ModeloCB.Text == "" || CostoTxt.Text == "" || SiteCB.Text == "" || IMEITXT.Text == "" || NumSerieTxt.Text == "" || EstadoCB.Text == "" || ColorCB.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                var selectedItem = ModeloCB.SelectedItem;
                var value = selectedItem.GetType().GetProperty("Value").GetValue(selectedItem, null);
                var selectedItem2 = SiteCB.SelectedItem;
                var value2 = selectedItem.GetType().GetProperty("Value").GetValue(selectedItem2, null);

                Datos.IdProducto = value.ToString();
                Datos.IdSite = value2.ToString();

                foreach (DataRow row in dtProductos.Rows)
                {
                    if (value.ToString() == row["idproducto"].ToString())
                    {
                        Datos.TipoProducto = TipoProductoCB.Text;
                        Datos.Marca = MarcaCB.Text;
                        Datos.Modelo = row["Modelo"].ToString();
                        Datos.Costo = CostoTxt.Text;
                        break;
                    }
                }
                Datos.IMEI = IMEITXT.Text;
                Datos.Serie = NumSerieTxt.Text;
                Datos.Estado = EstadoCB.Text;
                Datos.Color = ColorCB.Text;

                if (activo_SQL.Agregar_Activo())
                {
                    MessageBox.Show("Producto agregado");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al agregar producto");
                }
            }
        }
        private void ModificarBtn_Click(object sender, EventArgs e)
        {

        }
        private void ElimarBtn_Click(object sender, EventArgs e)
        {

        }

        private void TipoProductoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarcaCB.Items.Clear();
            ModeloCB.Items.Clear();
            MarcaCB.Enabled = true;
            ModeloCB.Enabled = false;

            HashSet<string> marcasUnicas = new HashSet<string>();

            foreach (DataRow row in dtProductos.Rows)
            {
                if (TipoProductoCB.Text == row["Nombre"].ToString())
                {
                    string marca = row["Marca"].ToString();
                    if (marcasUnicas.Add(marca)) // Solo se agrega si no existe ya
                    {
                        MarcaCB.Items.Add(marca);
                    }
                }
            }

        }
        private void MarcaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModeloCB.Items.Clear();
            ModeloCB.Enabled = true;

            HashSet<string> modelosUnicos = new HashSet<string>();

            foreach (DataRow row in dtProductos.Rows)
            {
                if (TipoProductoCB.Text == row["Nombre"].ToString() &&
                    MarcaCB.Text == row["Marca"].ToString())
                {
                    string modelo = row["Modelo"].ToString();
                    if (modelosUnicos.Add(modelo)) // Solo agrega si no está repetido
                    {
                        ModeloCB.Items.Add(new { Display = modelo, Value = row["idproducto"].ToString() });
                    }
                }
            }

            ModeloCB.DisplayMember = "Display";

        }
        private void ModeloCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ModeloCB.SelectedItem;
            var value = selectedItem.GetType().GetProperty("Value").GetValue(selectedItem, null);

            foreach (DataRow row in dtProductos.Rows)
            {
                if(value.ToString() == row["idproducto"].ToString())
                {
                    CostoTxt.Text = row["Costo"].ToString();
                    break;
                }
            }
        }

        private void ActivoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();
            ModeloCB.Enabled = true;
            MarcaCB.Enabled = true;

            int renglon = ActivoDGV.CurrentRow.Index;
            TipoProductoCB.Text = ActivoDGV.Rows[renglon].Cells[1].Value.ToString();
            MarcaCB.Text = ActivoDGV.Rows[renglon].Cells[2].Value.ToString();
            ModeloCB.Text = ActivoDGV.Rows[renglon].Cells[3].Value.ToString();
            ColorCB.Text = ActivoDGV.Rows[renglon].Cells[4].Value.ToString();
            IMEITXT.Text = ActivoDGV.Rows[renglon].Cells[5].Value.ToString();
            NumSerieTxt.Text = ActivoDGV.Rows[renglon].Cells[6].Value.ToString();
            EstadoCB.Text = ActivoDGV.Rows[renglon].Cells[7].Value.ToString();
            CostoTxt.Text = ActivoDGV.Rows[renglon].Cells[9].Value.ToString();
            //SiteCB.Text = ActivoDGV.Rows[renglon].Cells[10].Value.ToString();
        }
    }
}
