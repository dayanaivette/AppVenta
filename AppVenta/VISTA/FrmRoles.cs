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

namespace AppVenta.VISTA
{
    public partial class FrmRoles : Form
    {
        public FrmRoles()
        {
            InitializeComponent();
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities2 bd = new sistema_ventasEntities2())
            {

                var JoinTablas = from tbusua in bd.tb_usuarios
                                 from rolesusuarios in bd.roles_usuario
                                 where tbusua.idUsuario == rolesusuarios.idUsuario

                select new
                                 {
                                     Id = tbusua.idUsuario,
                                     Email = tbusua.Email,
                                     TipoRol = rolesusuarios.tipo_rol

                                 };

                dtVistaRoles.DataSource = JoinTablas.ToList();

            }
        }

        private void dtVistaRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
