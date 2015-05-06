namespace Aerolinea
{
    partial class ReservacionesClientes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservacionesClientes));
            this.groupGenerales = new System.Windows.Forms.GroupBox();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDatos = new System.Windows.Forms.Label();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.comboPrefijo = new System.Windows.Forms.ComboBox();
            this.labelNacimiento = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboPasajero = new System.Windows.Forms.ComboBox();
            this.checkContacto = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelNombreContacto = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelNacimientoContacto = new System.Windows.Forms.Label();
            this.comboPrefijoContacto = new System.Windows.Forms.ComboBox();
            this.comboGeneroContacto = new System.Windows.Forms.ComboBox();
            this.labelApellidoContacto = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelConfirmarCorreo = new System.Windows.Forms.Label();
            this.textNombreContacto = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textConfirmarCorreo = new System.Windows.Forms.TextBox();
            this.textApellidoContacto = new System.Windows.Forms.TextBox();
            this.labelInformacion = new System.Windows.Forms.Label();
            this.dateTimeNacimientoContacto = new System.Windows.Forms.DateTimePicker();
            this.labelTituloContacto = new System.Windows.Forms.Label();
            this.labelGeneroContacto = new System.Windows.Forms.Label();
            this.groupContacto = new System.Windows.Forms.GroupBox();
            this.maskedTextTelefono = new System.Windows.Forms.MaskedTextBox();
            this.labelPasajero = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.pictureAyuda = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelServicios = new System.Windows.Forms.Label();
            this.labelTxtServicios = new System.Windows.Forms.Label();
            this.labelPrecioSalida = new System.Windows.Forms.Label();
            this.labelTxtSalida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCostoTotal = new System.Windows.Forms.Label();
            this.labelTxtTotal = new System.Windows.Forms.Label();
            this.labelPrecioRegreso = new System.Windows.Forms.Label();
            this.labelIVA = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.labelTxtDescuento = new System.Windows.Forms.Label();
            this.labelTxtIVA = new System.Windows.Forms.Label();
            this.labelTxtRegreso = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupGenerales.SuspendLayout();
            this.groupContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAyuda)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupGenerales
            // 
            this.groupGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.groupGenerales.Controls.Add(this.dateTimeNacimiento);
            this.groupGenerales.Controls.Add(this.labelGenero);
            this.groupGenerales.Controls.Add(this.labelTitulo);
            this.groupGenerales.Controls.Add(this.labelDatos);
            this.groupGenerales.Controls.Add(this.textApellidos);
            this.groupGenerales.Controls.Add(this.textNombres);
            this.groupGenerales.Controls.Add(this.labelApellido);
            this.groupGenerales.Controls.Add(this.comboGenero);
            this.groupGenerales.Controls.Add(this.comboPrefijo);
            this.groupGenerales.Controls.Add(this.labelNacimiento);
            this.groupGenerales.Controls.Add(this.labelNombre);
            this.groupGenerales.Location = new System.Drawing.Point(9, 76);
            this.groupGenerales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupGenerales.Name = "groupGenerales";
            this.groupGenerales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupGenerales.Size = new System.Drawing.Size(938, 193);
            this.groupGenerales.TabIndex = 1;
            this.groupGenerales.TabStop = false;
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Location = new System.Drawing.Point(138, 158);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(300, 26);
            this.dateTimeNacimiento.TabIndex = 6;
            this.dateTimeNacimiento.ValueChanged += new System.EventHandler(this.dateTimeNacimiento_ValueChanged);
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(12, 119);
            this.labelGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(63, 20);
            this.labelGenero.TabIndex = 2;
            this.labelGenero.Text = "Genero";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(8, 38);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(47, 20);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatos.Location = new System.Drawing.Point(7, 0);
            this.labelDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(126, 20);
            this.labelDatos.TabIndex = 2;
            this.labelDatos.Text = "Datos Pasajeros";
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(536, 70);
            this.textApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(388, 26);
            this.textApellidos.TabIndex = 4;
            this.textApellidos.TextChanged += new System.EventHandler(this.textApellidos_TextChanged);
            this.textApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellidos_KeyPress);
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(138, 71);
            this.textNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(388, 26);
            this.textNombres.TabIndex = 3;
            this.textNombres.TextChanged += new System.EventHandler(this.textNombres_TextChanged);
            this.textNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombres_KeyPress);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(537, 34);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(83, 20);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido(s)";
            // 
            // comboGenero
            // 
            this.comboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboGenero.Location = new System.Drawing.Point(11, 155);
            this.comboGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(96, 28);
            this.comboGenero.TabIndex = 5;
            this.comboGenero.SelectedIndexChanged += new System.EventHandler(this.comboGenero_SelectedIndexChanged);
            // 
            // comboPrefijo
            // 
            this.comboPrefijo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrefijo.FormattingEnabled = true;
            this.comboPrefijo.Items.AddRange(new object[] {
            "Sr.",
            "Sra.",
            "Srita."});
            this.comboPrefijo.Location = new System.Drawing.Point(12, 69);
            this.comboPrefijo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPrefijo.Name = "comboPrefijo";
            this.comboPrefijo.Size = new System.Drawing.Size(96, 28);
            this.comboPrefijo.TabIndex = 2;
            this.comboPrefijo.SelectedIndexChanged += new System.EventHandler(this.comboPrefijo_SelectedIndexChanged);
            // 
            // labelNacimiento
            // 
            this.labelNacimiento.AutoSize = true;
            this.labelNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNacimiento.Location = new System.Drawing.Point(142, 119);
            this.labelNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNacimiento.Name = "labelNacimiento";
            this.labelNacimiento.Size = new System.Drawing.Size(159, 20);
            this.labelNacimiento.TabIndex = 3;
            this.labelNacimiento.Text = "Fecha de Nacimiento";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(142, 38);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(83, 20);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre(s)";
            // 
            // comboPasajero
            // 
            this.comboPasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPasajero.FormattingEnabled = true;
            this.comboPasajero.Location = new System.Drawing.Point(173, 45);
            this.comboPasajero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPasajero.Name = "comboPasajero";
            this.comboPasajero.Size = new System.Drawing.Size(113, 28);
            this.comboPasajero.TabIndex = 1;
            this.comboPasajero.SelectedIndexChanged += new System.EventHandler(this.comboPasajero_SelectedIndexChanged);
            // 
            // checkContacto
            // 
            this.checkContacto.AutoSize = true;
            this.checkContacto.Location = new System.Drawing.Point(305, 47);
            this.checkContacto.Name = "checkContacto";
            this.checkContacto.Size = new System.Drawing.Size(250, 24);
            this.checkContacto.TabIndex = 8;
            this.checkContacto.Text = "Utilizar información de contacto";
            this.checkContacto.UseVisualStyleBackColor = true;
            this.checkContacto.CheckedChanged += new System.EventHandler(this.checkContacto_CheckedChanged);
            // 
            // labelNombreContacto
            // 
            this.labelNombreContacto.AutoSize = true;
            this.labelNombreContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreContacto.Location = new System.Drawing.Point(139, 42);
            this.labelNombreContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreContacto.Name = "labelNombreContacto";
            this.labelNombreContacto.Size = new System.Drawing.Size(83, 20);
            this.labelNombreContacto.TabIndex = 3;
            this.labelNombreContacto.Text = "Nombre(s)";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(536, 120);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(71, 20);
            this.labelTelefono.TabIndex = 3;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelNacimientoContacto
            // 
            this.labelNacimientoContacto.AutoSize = true;
            this.labelNacimientoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNacimientoContacto.Location = new System.Drawing.Point(145, 122);
            this.labelNacimientoContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNacimientoContacto.Name = "labelNacimientoContacto";
            this.labelNacimientoContacto.Size = new System.Drawing.Size(159, 20);
            this.labelNacimientoContacto.TabIndex = 3;
            this.labelNacimientoContacto.Text = "Fecha de Nacimiento";
            // 
            // comboPrefijoContacto
            // 
            this.comboPrefijoContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrefijoContacto.FormattingEnabled = true;
            this.comboPrefijoContacto.Items.AddRange(new object[] {
            "Sr.",
            "Sra.",
            "Srita."});
            this.comboPrefijoContacto.Location = new System.Drawing.Point(12, 68);
            this.comboPrefijoContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPrefijoContacto.Name = "comboPrefijoContacto";
            this.comboPrefijoContacto.Size = new System.Drawing.Size(96, 28);
            this.comboPrefijoContacto.TabIndex = 9;
            // 
            // comboGeneroContacto
            // 
            this.comboGeneroContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGeneroContacto.FormattingEnabled = true;
            this.comboGeneroContacto.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboGeneroContacto.Location = new System.Drawing.Point(12, 156);
            this.comboGeneroContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboGeneroContacto.Name = "comboGeneroContacto";
            this.comboGeneroContacto.Size = new System.Drawing.Size(96, 28);
            this.comboGeneroContacto.TabIndex = 12;
            // 
            // labelApellidoContacto
            // 
            this.labelApellidoContacto.AutoSize = true;
            this.labelApellidoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoContacto.Location = new System.Drawing.Point(549, 41);
            this.labelApellidoContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidoContacto.Name = "labelApellidoContacto";
            this.labelApellidoContacto.Size = new System.Drawing.Size(83, 20);
            this.labelApellidoContacto.TabIndex = 3;
            this.labelApellidoContacto.Text = "Apellido(s)";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(13, 217);
            this.labelCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(140, 20);
            this.labelCorreo.TabIndex = 3;
            this.labelCorreo.Text = "Correo Electronico";
            // 
            // labelConfirmarCorreo
            // 
            this.labelConfirmarCorreo.AutoSize = true;
            this.labelConfirmarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarCorreo.Location = new System.Drawing.Point(252, 218);
            this.labelConfirmarCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmarCorreo.Name = "labelConfirmarCorreo";
            this.labelConfirmarCorreo.Size = new System.Drawing.Size(213, 20);
            this.labelConfirmarCorreo.TabIndex = 3;
            this.labelConfirmarCorreo.Text = "Confirmar Correo Electronico";
            // 
            // textNombreContacto
            // 
            this.textNombreContacto.Location = new System.Drawing.Point(143, 68);
            this.textNombreContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNombreContacto.Name = "textNombreContacto";
            this.textNombreContacto.Size = new System.Drawing.Size(388, 26);
            this.textNombreContacto.TabIndex = 10;
            this.textNombreContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreContacto_KeyPress);
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(17, 242);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(231, 26);
            this.textCorreo.TabIndex = 15;
            // 
            // textConfirmarCorreo
            // 
            this.textConfirmarCorreo.Location = new System.Drawing.Point(256, 242);
            this.textConfirmarCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textConfirmarCorreo.Name = "textConfirmarCorreo";
            this.textConfirmarCorreo.Size = new System.Drawing.Size(231, 26);
            this.textConfirmarCorreo.TabIndex = 16;
            // 
            // textApellidoContacto
            // 
            this.textApellidoContacto.Location = new System.Drawing.Point(540, 67);
            this.textApellidoContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textApellidoContacto.Name = "textApellidoContacto";
            this.textApellidoContacto.Size = new System.Drawing.Size(388, 26);
            this.textApellidoContacto.TabIndex = 11;
            this.textApellidoContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellidoContacto_KeyPress);
            // 
            // labelInformacion
            // 
            this.labelInformacion.AutoSize = true;
            this.labelInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacion.Location = new System.Drawing.Point(0, -2);
            this.labelInformacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInformacion.Name = "labelInformacion";
            this.labelInformacion.Size = new System.Drawing.Size(162, 20);
            this.labelInformacion.TabIndex = 2;
            this.labelInformacion.Text = "Información Contacto";
            // 
            // dateTimeNacimientoContacto
            // 
            this.dateTimeNacimientoContacto.Location = new System.Drawing.Point(142, 158);
            this.dateTimeNacimientoContacto.Name = "dateTimeNacimientoContacto";
            this.dateTimeNacimientoContacto.Size = new System.Drawing.Size(299, 26);
            this.dateTimeNacimientoContacto.TabIndex = 13;
            // 
            // labelTituloContacto
            // 
            this.labelTituloContacto.AutoSize = true;
            this.labelTituloContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloContacto.Location = new System.Drawing.Point(13, 42);
            this.labelTituloContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloContacto.Name = "labelTituloContacto";
            this.labelTituloContacto.Size = new System.Drawing.Size(47, 20);
            this.labelTituloContacto.TabIndex = 9;
            this.labelTituloContacto.Text = "Titulo";
            // 
            // labelGeneroContacto
            // 
            this.labelGeneroContacto.AutoSize = true;
            this.labelGeneroContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneroContacto.Location = new System.Drawing.Point(13, 122);
            this.labelGeneroContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGeneroContacto.Name = "labelGeneroContacto";
            this.labelGeneroContacto.Size = new System.Drawing.Size(63, 20);
            this.labelGeneroContacto.TabIndex = 9;
            this.labelGeneroContacto.Text = "Genero";
            // 
            // groupContacto
            // 
            this.groupContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(215)))));
            this.groupContacto.Controls.Add(this.maskedTextTelefono);
            this.groupContacto.Controls.Add(this.labelGeneroContacto);
            this.groupContacto.Controls.Add(this.labelTituloContacto);
            this.groupContacto.Controls.Add(this.dateTimeNacimientoContacto);
            this.groupContacto.Controls.Add(this.labelInformacion);
            this.groupContacto.Controls.Add(this.textApellidoContacto);
            this.groupContacto.Controls.Add(this.textConfirmarCorreo);
            this.groupContacto.Controls.Add(this.textCorreo);
            this.groupContacto.Controls.Add(this.textNombreContacto);
            this.groupContacto.Controls.Add(this.labelConfirmarCorreo);
            this.groupContacto.Controls.Add(this.labelCorreo);
            this.groupContacto.Controls.Add(this.labelApellidoContacto);
            this.groupContacto.Controls.Add(this.comboGeneroContacto);
            this.groupContacto.Controls.Add(this.comboPrefijoContacto);
            this.groupContacto.Controls.Add(this.labelNacimientoContacto);
            this.groupContacto.Controls.Add(this.labelTelefono);
            this.groupContacto.Controls.Add(this.labelNombreContacto);
            this.groupContacto.Location = new System.Drawing.Point(9, 279);
            this.groupContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupContacto.Name = "groupContacto";
            this.groupContacto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupContacto.Size = new System.Drawing.Size(938, 278);
            this.groupContacto.TabIndex = 7;
            this.groupContacto.TabStop = false;
            this.groupContacto.Text = "Genero";
            // 
            // maskedTextTelefono
            // 
            this.maskedTextTelefono.Location = new System.Drawing.Point(543, 160);
            this.maskedTextTelefono.Mask = "(999)000-0000";
            this.maskedTextTelefono.Name = "maskedTextTelefono";
            this.maskedTextTelefono.Size = new System.Drawing.Size(112, 26);
            this.maskedTextTelefono.TabIndex = 14;
            // 
            // labelPasajero
            // 
            this.labelPasajero.AutoSize = true;
            this.labelPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasajero.Location = new System.Drawing.Point(169, 20);
            this.labelPasajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasajero.Name = "labelPasajero";
            this.labelPasajero.Size = new System.Drawing.Size(71, 20);
            this.labelPasajero.TabIndex = 9;
            this.labelPasajero.Text = "Pasajero";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(14, 3);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(55, 70);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 40;
            this.pictureLogo.TabStop = false;
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonContinuar.Location = new System.Drawing.Point(964, 17);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(157, 48);
            this.buttonContinuar.TabIndex = 41;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = false;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.buttonRegresar);
            this.groupBox1.Controls.Add(this.buttonContinuar);
            this.groupBox1.Location = new System.Drawing.Point(14, 565);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1139, 71);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegresar.Location = new System.Drawing.Point(12, 16);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(155, 48);
            this.buttonRegresar.TabIndex = 42;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // pictureAyuda
            // 
            this.pictureAyuda.Image = ((System.Drawing.Image)(resources.GetObject("pictureAyuda.Image")));
            this.pictureAyuda.Location = new System.Drawing.Point(1093, 16);
            this.pictureAyuda.Name = "pictureAyuda";
            this.pictureAyuda.Size = new System.Drawing.Size(49, 50);
            this.pictureAyuda.TabIndex = 43;
            this.pictureAyuda.TabStop = false;
            this.pictureAyuda.Click += new System.EventHandler(this.pictureAyuda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.groupBox3.Controls.Add(this.labelServicios);
            this.groupBox3.Controls.Add(this.labelTxtServicios);
            this.groupBox3.Controls.Add(this.labelPrecioSalida);
            this.groupBox3.Controls.Add(this.labelTxtSalida);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.labelCostoTotal);
            this.groupBox3.Controls.Add(this.labelTxtTotal);
            this.groupBox3.Controls.Add(this.labelPrecioRegreso);
            this.groupBox3.Controls.Add(this.labelIVA);
            this.groupBox3.Controls.Add(this.labelDescuento);
            this.groupBox3.Controls.Add(this.labelTxtDescuento);
            this.groupBox3.Controls.Add(this.labelTxtIVA);
            this.groupBox3.Controls.Add(this.labelTxtRegreso);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(954, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 481);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            // 
            // labelServicios
            // 
            this.labelServicios.AutoSize = true;
            this.labelServicios.Location = new System.Drawing.Point(40, 200);
            this.labelServicios.Name = "labelServicios";
            this.labelServicios.Size = new System.Drawing.Size(49, 20);
            this.labelServicios.TabIndex = 6;
            this.labelServicios.Text = "$0.00";
            // 
            // labelTxtServicios
            // 
            this.labelTxtServicios.AutoSize = true;
            this.labelTxtServicios.Location = new System.Drawing.Point(20, 180);
            this.labelTxtServicios.Name = "labelTxtServicios";
            this.labelTxtServicios.Size = new System.Drawing.Size(157, 20);
            this.labelTxtServicios.TabIndex = 7;
            this.labelTxtServicios.Text = "Servicios Adicionales";
            // 
            // labelPrecioSalida
            // 
            this.labelPrecioSalida.AutoSize = true;
            this.labelPrecioSalida.Location = new System.Drawing.Point(40, 100);
            this.labelPrecioSalida.Name = "labelPrecioSalida";
            this.labelPrecioSalida.Size = new System.Drawing.Size(49, 20);
            this.labelPrecioSalida.TabIndex = 4;
            this.labelPrecioSalida.Text = "$0.00";
            // 
            // labelTxtSalida
            // 
            this.labelTxtSalida.AutoSize = true;
            this.labelTxtSalida.Location = new System.Drawing.Point(20, 80);
            this.labelTxtSalida.Name = "labelTxtSalida";
            this.labelTxtSalida.Size = new System.Drawing.Size(123, 20);
            this.labelTxtSalida.TabIndex = 5;
            this.labelTxtSalida.Text = "Precio de Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Información de Vuelo";
            // 
            // labelCostoTotal
            // 
            this.labelCostoTotal.AutoSize = true;
            this.labelCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostoTotal.Location = new System.Drawing.Point(95, 355);
            this.labelCostoTotal.Name = "labelCostoTotal";
            this.labelCostoTotal.Size = new System.Drawing.Size(66, 26);
            this.labelCostoTotal.TabIndex = 1;
            this.labelCostoTotal.Text = "$0.00";
            // 
            // labelTxtTotal
            // 
            this.labelTxtTotal.AutoSize = true;
            this.labelTxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxtTotal.Location = new System.Drawing.Point(10, 355);
            this.labelTxtTotal.Name = "labelTxtTotal";
            this.labelTxtTotal.Size = new System.Drawing.Size(59, 26);
            this.labelTxtTotal.TabIndex = 1;
            this.labelTxtTotal.Text = "Total";
            // 
            // labelPrecioRegreso
            // 
            this.labelPrecioRegreso.AutoSize = true;
            this.labelPrecioRegreso.Location = new System.Drawing.Point(40, 150);
            this.labelPrecioRegreso.Name = "labelPrecioRegreso";
            this.labelPrecioRegreso.Size = new System.Drawing.Size(49, 20);
            this.labelPrecioRegreso.TabIndex = 1;
            this.labelPrecioRegreso.Text = "$0.00";
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Location = new System.Drawing.Point(40, 250);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(49, 20);
            this.labelIVA.TabIndex = 1;
            this.labelIVA.Text = "$0.00";
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Location = new System.Drawing.Point(40, 300);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(49, 20);
            this.labelDescuento.TabIndex = 1;
            this.labelDescuento.Text = "$0.00";
            // 
            // labelTxtDescuento
            // 
            this.labelTxtDescuento.AutoSize = true;
            this.labelTxtDescuento.Location = new System.Drawing.Point(20, 280);
            this.labelTxtDescuento.Name = "labelTxtDescuento";
            this.labelTxtDescuento.Size = new System.Drawing.Size(87, 20);
            this.labelTxtDescuento.TabIndex = 1;
            this.labelTxtDescuento.Text = "Descuento";
            // 
            // labelTxtIVA
            // 
            this.labelTxtIVA.AutoSize = true;
            this.labelTxtIVA.Location = new System.Drawing.Point(20, 230);
            this.labelTxtIVA.Name = "labelTxtIVA";
            this.labelTxtIVA.Size = new System.Drawing.Size(36, 20);
            this.labelTxtIVA.TabIndex = 1;
            this.labelTxtIVA.Text = "IVA";
            // 
            // labelTxtRegreso
            // 
            this.labelTxtRegreso.AutoSize = true;
            this.labelTxtRegreso.Location = new System.Drawing.Point(20, 130);
            this.labelTxtRegreso.Name = "labelTxtRegreso";
            this.labelTxtRegreso.Size = new System.Drawing.Size(140, 20);
            this.labelTxtRegreso.TabIndex = 1;
            this.labelTxtRegreso.Text = "Precio de Regreso";
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalir.Location = new System.Drawing.Point(576, 20);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(51, 41);
            this.buttonSalir.TabIndex = 47;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // ReservacionesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 642);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureAyuda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.labelPasajero);
            this.Controls.Add(this.groupContacto);
            this.Controls.Add(this.checkContacto);
            this.Controls.Add(this.groupGenerales);
            this.Controls.Add(this.comboPasajero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservacionesClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del pasajero";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupGenerales.ResumeLayout(false);
            this.groupGenerales.PerformLayout();
            this.groupContacto.ResumeLayout(false);
            this.groupContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAyuda)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupGenerales;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.ComboBox comboPrefijo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDatos;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.ComboBox comboPasajero;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.Label labelNacimiento;
        private System.Windows.Forms.CheckBox checkContacto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNombreContacto;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelNacimientoContacto;
        private System.Windows.Forms.ComboBox comboPrefijoContacto;
        private System.Windows.Forms.ComboBox comboGeneroContacto;
        private System.Windows.Forms.Label labelApellidoContacto;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelConfirmarCorreo;
        private System.Windows.Forms.TextBox textNombreContacto;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textConfirmarCorreo;
        private System.Windows.Forms.TextBox textApellidoContacto;
        private System.Windows.Forms.Label labelInformacion;
        private System.Windows.Forms.DateTimePicker dateTimeNacimientoContacto;
        private System.Windows.Forms.Label labelTituloContacto;
        private System.Windows.Forms.Label labelGeneroContacto;
        private System.Windows.Forms.GroupBox groupContacto;
        private System.Windows.Forms.Label labelPasajero;
        private System.Windows.Forms.MaskedTextBox maskedTextTelefono;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.PictureBox pictureAyuda;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelServicios;
        private System.Windows.Forms.Label labelTxtServicios;
        private System.Windows.Forms.Label labelPrecioSalida;
        private System.Windows.Forms.Label labelTxtSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCostoTotal;
        private System.Windows.Forms.Label labelTxtTotal;
        private System.Windows.Forms.Label labelPrecioRegreso;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.Label labelTxtDescuento;
        private System.Windows.Forms.Label labelTxtIVA;
        private System.Windows.Forms.Label labelTxtRegreso;
        private System.Windows.Forms.Button buttonSalir;
    }
}

