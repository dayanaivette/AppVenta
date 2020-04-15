﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVenta.Model;

namespace AppVenta.VISTA
{
    public partial class FrmUsuarios : Form
    {
        
        public FrmUsuarios()
        {
            InitializeComponent();
            cargardatos();
        }
        tb_usuarios user = new tb_usuarios();

        void cargardatos()
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                //var tb_Usuarios = db.tb_usuarios;
                //foreach(var iterardatostbUsuario in tb_Usuarios)
                //{
                //    dvgUsuarios.Rows.Add(iterardatostbUsuario.email, iterardatostbUsuario.contrasena);
                //}
                dvgUsuarios.DataSource = db.tb_usuarios.ToList();
            }
        }
        void limpiardatos()
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                user.Email = txtUsuario.Text;
                user.Contrasena = txtPass.Text;
                db.tb_usuarios.Add(user);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                string Id = dvgUsuarios.CurrentRow.Cells[0].Value.ToString();

                user = db.tb_usuarios.Find(int.Parse(Id));
                db.tb_usuarios.Remove(user);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                string Id = dvgUsuarios.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                user = db.tb_usuarios.Where(VerificarId => VerificarId.Id == IdC).First();
                user.Email = txtUsuario.Text;
                user.Contrasena = txtPass.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
            
        }

        private void dvgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String email = dvgUsuarios.CurrentRow.Cells[1].Value.ToString();
            String pass = dvgUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = email;
            txtPass.Text = pass;
        }

    }
}
