namespace Aerolinea
{
    partial class ClientesContactos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesContactos));
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textIDContacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.maskedTextTelefono = new System.Windows.Forms.MaskedTextBox();
            this.textApellidoContacto = new System.Windows.Forms.TextBox();
            this.labelApellidoContacto = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelGeneroContacto = new System.Windows.Forms.Label();
            this.labelTituloContacto = new System.Windows.Forms.Label();
            this.dateTimeNacimientoContacto = new System.Windows.Forms.DateTimePicker();
            this.textConfirmarCorreo = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textNombreContacto = new System.Windows.Forms.TextBox();
            this.labelConfirmarCorreo = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.comboGeneroContacto = new System.Windows.Forms.ComboBox();
            this.comboPrefijoContacto = new System.Windows.Forms.ComboBox();
            this.labelNacimientoContacto = new System.Windows.Forms.Label();
            this.labelNombreContacto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(85, 85);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 41;
            this.pictureLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.groupBox1.Controls.Add(this.textIDContacto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.maskedTextTelefono);
            this.groupBox1.Controls.Add(this.textApellidoContacto);
            this.groupBox1.Controls.Add(this.labelApellidoContacto);
            this.groupBox1.Controls.Add(this.labelTelefono);
            this.groupBox1.Controls.Add(this.labelGeneroContacto);
            this.groupBox1.Controls.Add(this.labelTituloContacto);
            this.groupBox1.Controls.Add(this.dateTimeNacimientoContacto);
            this.groupBox1.Controls.Add(this.textConfirmarCorreo);
            this.groupBox1.Controls.Add(this.textCorreo);
            this.groupBox1.Controls.Add(this.textNombreContacto);
            this.groupBox1.Controls.Add(this.labelConfirmarCorreo);
            this.groupBox1.Controls.Add(this.labelCorreo);
            this.groupBox1.Controls.Add(this.comboGeneroContacto);
            this.groupBox1.Controls.Add(this.comboPrefijoContacto);
            this.groupBox1.Controls.Add(this.labelNacimientoContacto);
            this.groupBox1.Controls.Add(this.labelNombreContacto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 418);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // textIDContacto
            // 
            this.textIDContacto.Enabled = false;
            this.textIDContacto.Location = new System.Drawing.Point(34, 45);
            this.textIDContacto.Name = "textIDContacto";
            this.textIDContacto.Size = new System.Drawing.Size(100, 28);
            this.textIDContacto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID de Contacto";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelar.Location = new System.Drawing.Point(440, 351);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 50);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardar.Location = new System.Drawing.Point(314, 351);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 50);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // maskedTextTelefono
            // 
            this.maskedTextTelefono.Location = new System.Drawing.Point(358, 234);
            this.maskedTextTelefono.Mask = "(999)000-0000";
            this.maskedTextTelefono.Name = "maskedTextTelefono";
            this.maskedTextTelefono.Size = new System.Drawing.Size(112, 28);
            this.maskedTextTelefono.TabIndex = 7;
            // 
            // textApellidoContacto
            // 
            this.textApellidoContacto.Location = new System.Drawing.Point(160, 170);
            this.textApellidoContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textApellidoContacto.Name = "textApellidoContacto";
            this.textApellidoContacto.Size = new System.Drawing.Size(388, 28);
            this.textApellidoContacto.TabIndex = 5;
            this.textApellidoContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellidoContacto_KeyPress);
            // 
            // labelApellidoContacto
            // 
            this.labelApellidoContacto.AutoSize = true;
            this.labelApellidoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoContacto.Location = new System.Drawing.Point(161, 143);
            this.labelApellidoContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidoContacto.Name = "labelApellidoContacto";
            this.labelApellidoContacto.Size = new System.Drawing.Size(83, 20);
            this.labelApellidoContacto.TabIndex = 29;
            this.labelApellidoContacto.Text = "Apellido(s)";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(354, 207);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(71, 20);
            this.labelTelefono.TabIndex = 30;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelGeneroContacto
            // 
            this.labelGeneroContacto.AutoSize = true;
            this.labelGeneroContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneroContacto.Location = new System.Drawing.Point(30, 143);
            this.labelGeneroContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGeneroContacto.Name = "labelGeneroContacto";
            this.labelGeneroContacto.Size = new System.Drawing.Size(63, 20);
            this.labelGeneroContacto.TabIndex = 21;
            this.labelGeneroContacto.Text = "Genero";
            // 
            // labelTituloContacto
            // 
            this.labelTituloContacto.AutoSize = true;
            this.labelTituloContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloContacto.Location = new System.Drawing.Point(30, 80);
            this.labelTituloContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloContacto.Name = "labelTituloContacto";
            this.labelTituloContacto.Size = new System.Drawing.Size(47, 20);
            this.labelTituloContacto.TabIndex = 22;
            this.labelTituloContacto.Text = "Titulo";
            // 
            // dateTimeNacimientoContacto
            // 
            this.dateTimeNacimientoContacto.Location = new System.Drawing.Point(36, 234);
            this.dateTimeNacimientoContacto.Name = "dateTimeNacimientoContacto";
            this.dateTimeNacimientoContacto.Size = new System.Drawing.Size(299, 28);
            this.dateTimeNacimientoContacto.TabIndex = 6;
            // 
            // textConfirmarCorreo
            // 
            this.textConfirmarCorreo.Location = new System.Drawing.Point(275, 301);
            this.textConfirmarCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textConfirmarCorreo.Name = "textConfirmarCorreo";
            this.textConfirmarCorreo.Size = new System.Drawing.Size(231, 28);
            this.textConfirmarCorreo.TabIndex = 9;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(36, 301);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(231, 28);
            this.textCorreo.TabIndex = 8;
            // 
            // textNombreContacto
            // 
            this.textNombreContacto.Location = new System.Drawing.Point(160, 106);
            this.textNombreContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNombreContacto.Name = "textNombreContacto";
            this.textNombreContacto.Size = new System.Drawing.Size(388, 28);
            this.textNombreContacto.TabIndex = 3;
            this.textNombreContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreContacto_KeyPress);
            // 
            // labelConfirmarCorreo
            // 
            this.labelConfirmarCorreo.AutoSize = true;
            this.labelConfirmarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarCorreo.Location = new System.Drawing.Point(271, 276);
            this.labelConfirmarCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmarCorreo.Name = "labelConfirmarCorreo";
            this.labelConfirmarCorreo.Size = new System.Drawing.Size(213, 20);
            this.labelConfirmarCorreo.TabIndex = 17;
            this.labelConfirmarCorreo.Text = "Confirmar Correo Electronico";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(32, 276);
            this.labelCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(140, 20);
            this.labelCorreo.TabIndex = 18;
            this.labelCorreo.Text = "Correo Electronico";
            // 
            // comboGeneroContacto
            // 
            this.comboGeneroContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGeneroContacto.FormattingEnabled = true;
            this.comboGeneroContacto.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboGeneroContacto.Location = new System.Drawing.Point(34, 168);
            this.comboGeneroContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboGeneroContacto.Name = "comboGeneroContacto";
            this.comboGeneroContacto.Size = new System.Drawing.Size(96, 29);
            this.comboGeneroContacto.TabIndex = 4;
            // 
            // comboPrefijoContacto
            // 
            this.comboPrefijoContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrefijoContacto.FormattingEnabled = true;
            this.comboPrefijoContacto.Items.AddRange(new object[] {
            "Sr.",
            "Sra.",
            "Srita."});
            this.comboPrefijoContacto.Location = new System.Drawing.Point(34, 106);
            this.comboPrefijoContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPrefijoContacto.Name = "comboPrefijoContacto";
            this.comboPrefijoContacto.Size = new System.Drawing.Size(96, 29);
            this.comboPrefijoContacto.TabIndex = 2;
            // 
            // labelNacimientoContacto
            // 
            this.labelNacimientoContacto.AutoSize = true;
            this.labelNacimientoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNacimientoContacto.Location = new System.Drawing.Point(32, 211);
            this.labelNacimientoContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNacimientoContacto.Name = "labelNacimientoContacto";
            this.labelNacimientoContacto.Size = new System.Drawing.Size(159, 20);
            this.labelNacimientoContacto.TabIndex = 19;
            this.labelNacimientoContacto.Text = "Fecha de Nacimiento";
            // 
            // labelNombreContacto
            // 
            this.labelNombreContacto.AutoSize = true;
            this.labelNombreContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreContacto.Location = new System.Drawing.Point(156, 80);
            this.labelNombreContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreContacto.Name = "labelNombreContacto";
            this.labelNombreContacto.Size = new System.Drawing.Size(83, 20);
            this.labelNombreContacto.TabIndex = 20;
            this.labelNombreContacto.Text = "Nombre(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cambio de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "contacto";
            // 
            // ClientesContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientesContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Contacto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelGeneroContacto;
        private System.Windows.Forms.Label labelTituloContacto;
        private System.Windows.Forms.DateTimePicker dateTimeNacimientoContacto;
        private System.Windows.Forms.TextBox textConfirmarCorreo;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textNombreContacto;
        private System.Windows.Forms.Label labelConfirmarCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.ComboBox comboGeneroContacto;
        private System.Windows.Forms.ComboBox comboPrefijoContacto;
        private System.Windows.Forms.Label labelNacimientoContacto;
        private System.Windows.Forms.Label labelNombreContacto;
        private System.Windows.Forms.MaskedTextBox maskedTextTelefono;
        private System.Windows.Forms.TextBox textApellidoContacto;
        private System.Windows.Forms.Label labelApellidoContacto;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textIDContacto;
        private System.Windows.Forms.Label label3;
    }
}