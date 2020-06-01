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
using AppVenta.VISTA.FormulariosBusqueda;

namespace AppVenta.VISTA
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            retornoId();
            CargarCombo();
        }

        void retornoId() 
        {
            using (sistema_ventasEntities2 db = new sistema_ventasEntities2())
            {

                var tb_v = db.tb_venta;
                txtNumVenta.Text = "1";
                foreach (var iterardatostbventa in tb_v)
                {
                    int idVenta = iterardatostbventa.idVenta;
                    int suma = idVenta + 1;
                    txtNumVenta.Text = suma.ToString();


                }
            }
        }

        void CargarCombo()
        {
            using (sistema_ventasEntities2 db = new sistema_ventasEntities2()) 
            {
                var clientes = db.tb_cliente.ToList();

                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "nombreCliente";
                cmbCliente.ValueMember = "idCliente";


                var tipodoc = db.tb_documento.ToList();

                cmbTipDoc.DataSource = tipodoc;
                cmbTipDoc.DisplayMember = "nombreDocumento";
                cmbTipDoc.ValueMember = "idDocumento";
                
            }
        }

        private void btnBuscarV_Click(object sender, EventArgs e)
        {
            FrmBusqueda busqueda = new FrmBusqueda();
            busqueda.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                calculo();
            }
            catch (Exception ex)
            {

            }
            dtvVentas.Rows.Add(txtCodProd.Text, txtNomProd.Text, txtPrecProd.Text, txtCantidad.Text, txtTotal.Text);
            calculartotalfinal();


            //dtvVentas.Refresh();
            dtvVentas.ClearSelection();
            int ObtenerUltimaFila = dtvVentas.Rows.Count - 1;
            dtvVentas.FirstDisplayedScrollingRowIndex = ObtenerUltimaFila;
            dtvVentas.Rows[ObtenerUltimaFila].Selected = true;

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }

        void calculo() 
        {
            try
            {
                Double precioProd;
                Double cantidad;
                Double total;

                precioProd = Double.Parse(txtPrecProd.Text);
                cantidad = Convert.ToDouble(txtCantidad.Text);

                total = precioProd * cantidad;

                txtTotal.Text = total.ToString();

            }
            catch (Exception ex)
            {
                txtCantidad.Text = "1";
                txtCantidad.Select();
            }
        }

        void calculartotalfinal()
        {
            Double suma = 0;
            for (int i = 0; i < dtvVentas.RowCount; i++)
            {
                String datosOperar = dtvVentas.Rows[i].Cells[4].Value.ToString();
                Double datosConvertidos = Convert.ToDouble(datosOperar);

                //suma = suma + datosConvertidos;
                suma += datosConvertidos;
                txtTotalFinal.Text = suma.ToString();
            }
        }

        private void btnGuardarV_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities2 db = new sistema_ventasEntities2())
            {
                tb_venta tb_v = new tb_venta();
                String comboTipDoc = cmbTipDoc.SelectedValue.ToString();
                tb_v.idDocumento = Convert.ToInt32(comboTipDoc);

                String comboCliente = cmbCliente.SelectedValue.ToString();
                tb_v.idCliente = Convert.ToInt32(comboCliente);

                tb_v.idUsuario = 1;
                tb_v.totalVenta = Convert.ToDecimal(txtTotalFinal.Text);
                tb_v.fecha = Convert.ToDateTime(dtpFecha.Text);

                db.tb_venta.Add(tb_v);
                db.SaveChanges();

                detalleVenta detalle = new detalleVenta();
                for (int i = 0; i < dtvVentas.RowCount; i++)
                {
                    String idProducto = dtvVentas.Rows[i].Cells[0].Value.ToString();
                    int idProductoConvertidos = Convert.ToInt32(idProducto);

                    String cantidad = dtvVentas.Rows[i].Cells[3].Value.ToString();
                    int cantidadConvertidos = Convert.ToInt32(cantidad);

                    String precio = dtvVentas.Rows[i].Cells[2].Value.ToString();
                    decimal precioConvertidos = Convert.ToDecimal(precio);

                    String total = dtvVentas.Rows[i].Cells[4].Value.ToString();
                    decimal totalConvertidos = Convert.ToDecimal(total);


                    detalle.idVenta = Convert.ToInt32(txtNumVenta.Text);
                    detalle.idProducto = idProductoConvertidos;
                    detalle.cantidad = cantidadConvertidos;
                    detalle.precio = precioConvertidos;
                    detalle.total = totalConvertidos;

                    db.detalleVenta.Add(detalle);
                    db.SaveChanges();
                }
            }
            retornoId();
            dtvVentas.Rows.Clear();
            txtTotalFinal.Text = "";
        }

        private void txtBusBarraProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBusBarraProducto.Text == "")
            {
                if (e.KeyCode==Keys.Enter)
                {
                    btnBuscarV.PerformClick();
                }
            } else if(e.KeyCode == Keys.Enter)
            {
                using (sistema_ventasEntities2 db = new sistema_ventasEntities2())
                {
                    producto pr = new producto();
                    int buscar = int.Parse(txtBusBarraProducto.Text);

                    pr = db.producto.Where(idBuscar => idBuscar.idProducto == buscar).First();

                    txtCodProd.Text = Convert.ToString(pr.idProducto);
                    txtNomProd.Text = Convert.ToString(pr.nombreProducto);
                    txtPrecProd.Text = Convert.ToString(pr.precioProducto);

                    txtCantidad.Focus();
                    txtBusBarraProducto.Text = "";
                    intentos = 2;

                }
            }

        }
        int intentos = 1;

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (intentos == 2)
                {

                    btnAgregar.PerformClick();

                    txtCodProd.Text = "";
                    txtNomProd.Text = "";
                    txtPrecProd.Text = "";
                    txtTotal.Text = "";
                        intentos = 0;
                    txtCantidad.Text = "1";
                    txtBusBarraProducto.Focus();
                }
                intentos += 1;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtvVentas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculartotalfinal();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dtvVentas.Rows.Remove(dtvVentas.CurrentRow);
        }

       
    }
}
