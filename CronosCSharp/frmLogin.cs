using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funciones;

namespace CronosCSharp
{
    public partial class frmLogin : Form
    {

        Conexion cnx = new Conexion();
        SelectCronos utl = new SelectCronos();
        DataTable ds = new DataTable();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cnx.cnx.Close();
            utl.Conection = cnx.cnx;
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblFPassword.TabIndex = 0;
            txtUsuario.TabIndex = 1;
            txtPassword.TabIndex = 2;
            btnAcceder.TabIndex = 3;

            cnx.cnx.Open();
            utl.Conection = cnx.cnx;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                string Usuario = txtUsuario.Text;
                string Password = txtPassword.Text;
                ds = utl.ValidarUsuario(Usuario, Password, null);

                if(ds.Rows.Count != 0)
                {
                    if(txtUsuario.Text == ds.Rows[0][0].ToString() && txtPassword.Text == ds.Rows[0][1].ToString())
                    {
                        this.Hide();
                        frmUsuarios frm = new frmUsuarios();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("El Usuario o Contraseña son incorrectos!", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
