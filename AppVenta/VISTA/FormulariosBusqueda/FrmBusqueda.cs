using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVenta.MODEL;

namespace AppVenta.VISTA.FormulariosBusqueda
{
    public partial class FrmBusqueda : Form
    {
        public FrmBusqueda()
        {
            InitializeComponent();
        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            filtro();
        }

        void filtro() 
        {
            using (sistema_ventasEntities2 db = new sistema_ventasEntities2())
            {
                string nombre = txtBusqueda.Text;

                var buscarprod = from tbprod in db.producto
                                 where tbprod.nombreProducto.Contains(nombre)

                                 select new
                                 {
                                     id = tbprod.idProducto,
                                     Nombre = tbprod.nombreProducto,
                                     precio = tbprod.precioProducto
                                 };

                dtvProducto.DataSource = buscarprod.ToList();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dtvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            envio();
        }

        void envio() 
        {
            string id = dtvProducto.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dtvProducto.CurrentRow.Cells[1].Value.ToString();
            string Precio = dtvProducto.CurrentRow.Cells[2].Value.ToString();

            FrmMenu.venta.txtCodProd.Text = id;
            FrmMenu.venta.txtNomProd.Text = Nombre;
            FrmMenu.venta.txtPrecProd.Text = Precio;

            FrmMenu.venta.txtCantidad.Focus();
            this.Close();
        }

        private void dtvProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                envio();
            }
        
        }
    }
}
