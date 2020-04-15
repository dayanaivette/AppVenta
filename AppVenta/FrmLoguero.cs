using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVenta.Model;
using AppVenta.VISTA;

namespace AppVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                var lista = from usuario in db.tb_usuarios
                            where usuario.Email == txtUsuario.Text
                            && usuario.Contrasena == txtPass.Text
                            select usuario;

                if (lista.Count() > 0)
                {
                    FrmMenu menu = new FrmMenu();
                    menu.Show();
                }
                else 
                { 
                    
                    MessageBox.Show("El Usuario no existe"); 
                }
            }
        }
    }
}
