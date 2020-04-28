using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVenta.VISTA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoles Rol = new FrmRoles();
            Rol.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios Usu = new FrmUsuarios();
            Usu.Show();
        }

        public static FrmVentas venta = new FrmVentas();

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            venta.Show();
        }
    }
}
