
namespace CronosCSharp
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInexistentes = new System.Windows.Forms.LinkLabel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.btnPermiso = new System.Windows.Forms.Button();
            this.txtPermiso = new System.Windows.Forms.TextBox();
            this.txtIdPermiso = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtMEmpleado = new System.Windows.Forms.TextBox();
            this.txtPEmpleado = new System.Windows.Forms.TextBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.txtNEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.53284F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.46715F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInexistentes);
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".::Usuarios::.";
            // 
            // lblInexistentes
            // 
            this.lblInexistentes.AutoSize = true;
            this.lblInexistentes.BackColor = System.Drawing.Color.Teal;
            this.lblInexistentes.ForeColor = System.Drawing.Color.White;
            this.lblInexistentes.LinkColor = System.Drawing.Color.White;
            this.lblInexistentes.Location = new System.Drawing.Point(317, 60);
            this.lblInexistentes.Name = "lblInexistentes";
            this.lblInexistentes.Size = new System.Drawing.Size(152, 18);
            this.lblInexistentes.TabIndex = 1;
            this.lblInexistentes.TabStop = true;
            this.lblInexistentes.Text = "Datos Inexistentes";
            this.lblInexistentes.Visible = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUsuarios.ColumnHeadersHeight = 30;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.PowderBlue;
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 24);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(761, 82);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".::Acciones::";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGenerar);
            this.groupBox3.Controls.Add(this.cmbEstatus);
            this.groupBox3.Controls.Add(this.btnPermiso);
            this.groupBox3.Controls.Add(this.txtPermiso);
            this.groupBox3.Controls.Add(this.txtIdPermiso);
            this.groupBox3.Controls.Add(this.Label9);
            this.groupBox3.Controls.Add(this.txtMEmpleado);
            this.groupBox3.Controls.Add(this.txtPEmpleado);
            this.groupBox3.Controls.Add(this.btnEmpleado);
            this.groupBox3.Controls.Add(this.txtNEmpleado);
            this.groupBox3.Controls.Add(this.txtIdEmpleado);
            this.groupBox3.Controls.Add(this.Label8);
            this.groupBox3.Controls.Add(this.Label5);
            this.groupBox3.Controls.Add(this.txtContraseña);
            this.groupBox3.Controls.Add(this.Label4);
            this.groupBox3.Controls.Add(this.txtUsuario);
            this.groupBox3.Controls.Add(this.Label3);
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Controls.Add(this.Label2);
            this.groupBox3.Controls.Add(this.txtIdUsuario);
            this.groupBox3.Controls.Add(this.Label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(761, 228);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = ".::Datos del Usuario::.";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(586, 106);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(172, 25);
            this.btnGenerar.TabIndex = 33;
            this.btnGenerar.Text = "Generar Usuario";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.Enabled = false;
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "1 - ACTIVO",
            "2 - INACTIVO"});
            this.cmbEstatus.Location = new System.Drawing.Point(108, 183);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(300, 26);
            this.cmbEstatus.TabIndex = 37;
            // 
            // btnPermiso
            // 
            this.btnPermiso.Enabled = false;
            this.btnPermiso.Location = new System.Drawing.Point(415, 145);
            this.btnPermiso.Name = "btnPermiso";
            this.btnPermiso.Size = new System.Drawing.Size(37, 23);
            this.btnPermiso.TabIndex = 36;
            this.btnPermiso.Text = "...";
            this.btnPermiso.UseVisualStyleBackColor = true;
            this.btnPermiso.Click += new System.EventHandler(this.btnPermiso_Click);
            // 
            // txtPermiso
            // 
            this.txtPermiso.Enabled = false;
            this.txtPermiso.Location = new System.Drawing.Point(154, 144);
            this.txtPermiso.Name = "txtPermiso";
            this.txtPermiso.Size = new System.Drawing.Size(255, 25);
            this.txtPermiso.TabIndex = 45;
            // 
            // txtIdPermiso
            // 
            this.txtIdPermiso.Enabled = false;
            this.txtIdPermiso.Location = new System.Drawing.Point(108, 144);
            this.txtIdPermiso.Name = "txtIdPermiso";
            this.txtIdPermiso.Size = new System.Drawing.Size(40, 25);
            this.txtIdPermiso.TabIndex = 44;
            this.txtIdPermiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPermiso_KeyPress);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(14, 147);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(64, 18);
            this.Label9.TabIndex = 43;
            this.Label9.Text = "Permiso";
            // 
            // txtMEmpleado
            // 
            this.txtMEmpleado.Enabled = false;
            this.txtMEmpleado.Location = new System.Drawing.Point(568, 69);
            this.txtMEmpleado.Name = "txtMEmpleado";
            this.txtMEmpleado.Size = new System.Drawing.Size(147, 25);
            this.txtMEmpleado.TabIndex = 42;
            // 
            // txtPEmpleado
            // 
            this.txtPEmpleado.Enabled = false;
            this.txtPEmpleado.Location = new System.Drawing.Point(415, 69);
            this.txtPEmpleado.Name = "txtPEmpleado";
            this.txtPEmpleado.Size = new System.Drawing.Size(147, 25);
            this.txtPEmpleado.TabIndex = 41;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Enabled = false;
            this.btnEmpleado.Location = new System.Drawing.Point(721, 70);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(37, 23);
            this.btnEmpleado.TabIndex = 32;
            this.btnEmpleado.Text = "...";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // txtNEmpleado
            // 
            this.txtNEmpleado.Enabled = false;
            this.txtNEmpleado.Location = new System.Drawing.Point(154, 69);
            this.txtNEmpleado.Name = "txtNEmpleado";
            this.txtNEmpleado.Size = new System.Drawing.Size(255, 25);
            this.txtNEmpleado.TabIndex = 40;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Location = new System.Drawing.Point(108, 69);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(40, 25);
            this.txtIdEmpleado.TabIndex = 39;
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEmpleado_KeyPress);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(14, 72);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 18);
            this.Label8.TabIndex = 38;
            this.Label8.Text = "Empleado";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(14, 186);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 18);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Estatus";
            // 
            // txtContraseña
            // 
            this.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(405, 106);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(172, 25);
            this.txtContraseña.TabIndex = 35;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(311, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 18);
            this.Label4.TabIndex = 31;
            this.Label4.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(108, 106);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(172, 25);
            this.txtUsuario.TabIndex = 30;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(14, 109);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 18);
            this.Label3.TabIndex = 29;
            this.Label3.Text = "Usuario";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(534, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(181, 25);
            this.txtCodigo.TabIndex = 28;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(472, 37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 18);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Código";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Location = new System.Drawing.Point(108, 34);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(40, 25);
            this.txtIdUsuario.TabIndex = 26;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 18);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Id Usuario";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(639, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(538, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(437, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(336, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(134, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".::Usuarios::.";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnGenerar;
        internal System.Windows.Forms.ComboBox cmbEstatus;
        internal System.Windows.Forms.Button btnPermiso;
        internal System.Windows.Forms.TextBox txtPermiso;
        internal System.Windows.Forms.TextBox txtIdPermiso;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtMEmpleado;
        internal System.Windows.Forms.TextBox txtPEmpleado;
        internal System.Windows.Forms.Button btnEmpleado;
        internal System.Windows.Forms.TextBox txtNEmpleado;
        internal System.Windows.Forms.TextBox txtIdEmpleado;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtContraseña;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtIdUsuario;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lblInexistentes;
    }
}

