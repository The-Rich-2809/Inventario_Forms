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
    public partial class Lobby : MaterialSkin.Controls.MaterialForm
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private void ProductosBtn_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }

        private void VerificarBtn_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProBtn_Click(object sender, EventArgs e)
        {
            AgregarProductos agregarProductos = new AgregarProductos();
            agregarProductos.Show();
        }
    }
}
