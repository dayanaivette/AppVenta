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

                foreach (var iterardatostbventa in tb_v)
                {
                    txtNumVenta.Text = iterardatostbventa.idVenta.ToString();

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
            catch(Exception ex)
            { 
            
            }
            dtvVentas.Rows.Add(txtCodProd.Text, txtNomProd.Text, txtPrecProd.Text, txtCantidad.Text, txtTotal.Text);
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
                txtCantidad.Text = "0";
                MessageBox.Show("No puedes operar datos menores de 0");

                txtCantidad.Select();
            }
        }
    }
}
