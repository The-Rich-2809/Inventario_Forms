using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Clases;

namespace Inventario
{
    public partial class AgregarProductos : MaterialSkin.Controls.MaterialForm
    {
        AgregarProductos_SQL agregarProductos = new AgregarProductos_SQL();
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
            TipoProductoDGV.DataSource = agregarProductos.Mostrar_TipoProductos();
            MarcaDGV.DataSource = agregarProductos.Mostrar_Marca();
            DetallesDGV.DataSource = agregarProductos.Mostrar_Detalles();
        }
    }
}
