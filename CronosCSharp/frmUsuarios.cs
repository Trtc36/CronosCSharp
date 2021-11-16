using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Funciones;

namespace CronosCSharp
{
    public partial class frmUsuarios : Form
    {
        Conexion cnx = new Conexion();
        SelectCronos utl = new SelectCronos();
        DataTable ds = new DataTable();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void Iniciar()
        {
            txtIdUsuario.Enabled = false;
            txtCodigo.Enabled = true;
            txtIdEmpleado.Enabled = false;
            txtNEmpleado.Enabled = false;
            txtPEmpleado.Enabled = false;
            txtMEmpleado.Enabled = false;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            txtIdPermiso.Enabled = false;
            txtPermiso.Enabled = false;
            cmbEstatus.Enabled = false;

            txtIdUsuario.Text = "";
            txtCodigo.Text = "";
            txtIdEmpleado.Text = "";
            txtNEmpleado.Text = "";
            txtPEmpleado.Text = "";
            txtMEmpleado.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtIdPermiso.Text = "";
            txtPermiso.Text = "";
            cmbEstatus.Text = "";

            btnEmpleado.Enabled = false;
            btnGenerar.Enabled = false;
            btnPermiso.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                ds = utl.BuscarUsuario(codigo, null);
                if (ds.Rows.Count != 0)
                {
                    dgvUsuarios.DataSource = ds;
                    dgvUsuarios.Columns[0].Visible = false;
                    dgvUsuarios.Columns[2].Visible = false;
                    dgvUsuarios.Columns[8].Visible = false;
                    dgvUsuarios.Columns[10].Visible = false;
                    lblInexistentes.Visible = false;
                }
                else
                {
                    dgvUsuarios.DataSource = null;
                    lblInexistentes.Visible = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Iniciar();
            cnx.cnx.Open();
            utl.Conection = cnx.cnx;
            InsertCronos.Conection = cnx.cnx;
            UpdateCronos.Conection = cnx.cnx;
            DeleteCronos.Conection = cnx.cnx;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnx.cnx.Close();
            utl.Conection = cnx.cnx;
            InsertCronos.Conection = cnx.cnx;
            UpdateCronos.Conection = cnx.cnx;
            DeleteCronos.Conection = cnx.cnx;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo;
            int numero;

            txtIdEmpleado.Enabled = true;
            txtIdPermiso.Enabled = true;
            cmbEstatus.Enabled = true;
            btnEmpleado.Enabled = true;
            btnGenerar.Enabled = true;
            btnPermiso.Enabled = true;

            try
            {
                if (utl.GenerarUsuario(null) != null)
                {
                    numero = int.Parse(utl.GenerarUsuario(null).Rows[0][0].ToString()) + 1;
                    if (numero < 10)
                    {
                        codigo = string.Format("CRONOSUSU000{0}", numero);
                    }
                    else if (numero > 9 && numero <= 99)
                    {
                        codigo = string.Format("CRONOSUSU00{00}", numero);
                    }
                    else if (numero > 99 && numero <= 999)
                    {
                        codigo = string.Format("CRONOSUSU0{000}", numero);
                    }
                    else
                    {
                        codigo = string.Format("CRONOSUSU{0000}", numero);
                    }
                    txtCodigo.Text = codigo.ToString();
                    txtIdUsuario.Text = numero.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdEmpleado.Text != "")
                {
                    string idEmpleado = txtIdEmpleado.Text;
                    ds = utl.AgregarEmpleado(idEmpleado, null);
                    if (ds.Rows.Count != 0)
                    {
                        txtNEmpleado.Text = ds.Rows[0][0].ToString();
                        txtPEmpleado.Text = ds.Rows[0][1].ToString();
                        txtMEmpleado.Text = ds.Rows[0][2].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Existe el Empleado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el Id del Empleado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdEmpleado.Focus();
                }
            }
            catch (Exception ex)
            {
                txtNEmpleado.Text = ex.Message;
            }
        }

        private void txtIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtNEmpleado.Text != "" && txtPEmpleado.Text != "" && txtIdEmpleado.Text != "")
            {
                Char[] nombre = txtNEmpleado.Text.ToCharArray();
                string usuario = nombre[0].ToString() + txtPEmpleado.Text + txtIdEmpleado.Text;
                txtUsuario.Text = usuario;
            }
            else
            {
                MessageBox.Show("Los campos:\n\t-Id Empleado\n\t-Nombre\n\t-Apellido Paterno\n\nNo pueden estar vacios", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEmpleado.Focus();
            }
        }

        private void btnPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPermiso.Text != "")
                {
                    String idPermiso = txtIdPermiso.Text;
                    ds = utl.AgregarPermiso(idPermiso, null);
                    if (ds.Rows.Count != 0)
                    {
                        txtPermiso.Text = ds.Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No existe el Permiso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe Ingresar el Id del Permiso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPermiso.Focus();
                }
            }
            catch (Exception ex)
            {
                txtPermiso.Text = ex.Message;
            }
        }

        private void txtIdPermiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtIdEmpleado.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtNEmpleado.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtPEmpleado.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtMEmpleado.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
            txtIdPermiso.Text = dgvUsuarios.CurrentRow.Cells[8].Value.ToString();
            txtPermiso.Text = dgvUsuarios.CurrentRow.Cells[9].Value.ToString();
            if (dgvUsuarios.CurrentRow.Cells[10].Value.ToString() == "1")
            {
                cmbEstatus.Text = dgvUsuarios.CurrentRow.Cells[10].Value.ToString() + " - ACTIVO";
            }
            else if (dgvUsuarios.CurrentRow.Cells[10].Value.ToString() == "2")
            {
                cmbEstatus.Text = dgvUsuarios.CurrentRow.Cells[10].Value.ToString() + " - INACTIVO";
            }

            txtContraseña.Enabled = true;
            btnPermiso.Enabled = true;
            cmbEstatus.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlTransaction trans = null;
            string psResult = "";

            if (txtCodigo.Text != "" && txtUsuario.Text != "" && txtContraseña.Text != "" && txtIdEmpleado.Text != "" && txtIdPermiso.Text != "" && cmbEstatus.Text != "")
            {
                bool status;
                trans = cnx.cnx.BeginTransaction();
                status = true;

                try
                {
                    char[] estatus = cmbEstatus.Text.ToCharArray();
                    psResult = InsertCronos.GuardarUsuario(txtCodigo.Text,
                                                txtUsuario.Text,
                                                txtContraseña.Text,
                                                int.Parse(txtIdEmpleado.Text),
                                                int.Parse(txtIdPermiso.Text),
                                                Int32.Parse(estatus[0].ToString()), trans);


                    if (psResult == "Successful")
                    {
                        trans.Commit();
                        MessageBox.Show("Usuario Registrado Correctamente", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        trans.Rollback();
                        MessageBox.Show("Usuario No Registrado Correctamente", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    if (status == true)
                        trans.Rollback();
                    MessageBox.Show("Usuario No Registrado Correctamente", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception ex)
                {
                    if (status == true)
                        trans.Rollback();
                    MessageBox.Show("Usuario No Registrado Correctamente", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por Ingresar", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Iniciar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlTransaction trans = null;
            string psResult = "";

            if (txtIdUsuario.Text != "" && txtCodigo.Text != "" && txtUsuario.Text != "" && txtContraseña.Text != "" && txtIdEmpleado.Text != "" && txtIdPermiso.Text != "" && cmbEstatus.Text != "")
            {
                bool status;
                trans = cnx.cnx.BeginTransaction();
                status = true;

                try
                {
                    char[] estatus = cmbEstatus.Text.ToCharArray();
                    psResult = UpdateCronos.ActualizarUsuario(int.Parse(txtIdUsuario.Text),
                                                txtCodigo.Text,
                                                txtUsuario.Text,
                                                txtContraseña.Text,
                                                int.Parse(txtIdEmpleado.Text),
                                                int.Parse(txtIdPermiso.Text),
                                                Int32.Parse(estatus[0].ToString()), trans);


                    if (psResult == "Successful")
                    {
                        trans.Commit();
                        MessageBox.Show("Usuario Modificado Correctamente", "Modificación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        trans.Rollback();
                        MessageBox.Show("Usuario No Modificado Correctamente", "Modificación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    if (status == true)
                        trans.Rollback();
                    MessageBox.Show("Usuario No Modificado Correctamente", "Modificación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception)
                {
                    if (status == true)
                        trans.Rollback();
                    MessageBox.Show("Usuario No Modificado Correctamente", "Modificación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por Ingresar", "Modificación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Iniciar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlTransaction trans = null;
            string psResult = "";

            if (txtIdUsuario.Text != "")
            {
                bool status;
                trans = cnx.cnx.BeginTransaction();
                status = true;

                try
                {
                    char[] estatus = cmbEstatus.Text.ToCharArray();
                    psResult = DeleteCronos.BorrarUsuario(int.Parse(txtIdUsuario.Text), trans);


                    if (psResult == "Sucessfull")
                    {
                        trans.Commit();
                        MessageBox.Show("Usuario Eliminado Correctamente", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        trans.Rollback();
                        MessageBox.Show("Usuario No Eliminado Correctamente", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    if (status == true)
                        trans.Rollback();
                    MessageBox.Show("Usuario No Eliminado Correctamente", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception)
                {
                    if (status == true)
                        trans.Rollback();
                    MessageBox.Show("Usuario No Eliminado Correctamente", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se requiere el Id de Uuario", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Iniciar();
        }
    }
}
