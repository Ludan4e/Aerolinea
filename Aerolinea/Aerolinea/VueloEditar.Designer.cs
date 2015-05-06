namespace Aerolinea
{
    partial class VueloEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VueloEditar));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.comboOrigen = new System.Windows.Forms.ComboBox();
            this.comboAvion = new System.Windows.Forms.ComboBox();
            this.dateTimeSalida = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimeHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.textIDVuelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hora de Llegada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hora de Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre del Avión:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fecha de Salida:";
            // 
            // comboDestino
            // 
            this.comboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Items.AddRange(new object[] {
            "Acapulco (ACA)",
            "Aguascalientes (AGU)",
            "Campeche (CPE)",
            "Cancún (CUN)",
            "Chihuahua (CUU)",
            "Ciudad de México (MEX)",
            "Ciudad del Carmen (CME)",
            "Ciudad Juárez (CJS)",
            "Ciudad Obregón (CEN)",
            "Ciudad Victoria (CVM)",
            "Colima (CLQ)",
            "Cozumel (CZM)",
            "Culiacán (CUL)",
            "Durango (DGO)",
            "Guadalajara (GDL)",
            "Hermosillo (HMO)",
            "Huatulco (HUX)",
            "Ixtapa Zihuatanejo (ZIH)",
            "Jalapa (JAL)",
            "La Paz (LAP)",
            "Lázaro Cárdenas (LZC)",
            "León Bajío (BJX)",
            "Los Cabos - Cabo San Lucas (SJD)",
            "Los Mochis (LMM)",
            "Manzanillo (ZLO)",
            "Matamoros (MAM)",
            "Mazatlán (MZT)",
            "Mérida (MID)",
            "Mexicali (MXL)",
            "Minatitlán (MTT)",
            "Monclova (LOV)",
            "Monterrey (MTY)",
            "Morelia (MLM)",
            "Nuevo Laredo (NLD)",
            "Oaxaca (OAX)",
            "Piedras Negras (PDS)",
            "Poza Rica (PAZ)",
            "Puebla (PBC)",
            "Puerto Escondido (PXM)",
            "Puerto Vallarta (PVR)",
            "Querétaro (QRO)",
            "Reynosa (REX)",
            "Riviera Maya - Playa del Carmen (CUN)",
            "Riviera Nayarit (PVR)",
            "Saltillo (SLW)",
            "San Luis Potosí (SLP)",
            "Tampico (TAM)",
            "Tapachula (TAP)",
            "Tepic (TPQ)",
            "Tijuana (TIJ)",
            "Toluca (TLC)",
            "Torreón (TRC)",
            "Tuxtla Gutiérrez (TGZ)",
            "Veracruz (VER)",
            "Villahermosa (VSA)",
            "Zacatecas (ZCL)"});
            this.comboDestino.Location = new System.Drawing.Point(145, 275);
            this.comboDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(300, 28);
            this.comboDestino.TabIndex = 24;
            // 
            // comboOrigen
            // 
            this.comboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOrigen.FormattingEnabled = true;
            this.comboOrigen.Items.AddRange(new object[] {
            "Acapulco (ACA)",
            "Aguascalientes (AGU)",
            "Campeche (CPE)",
            "Cancún (CUN)",
            "Chihuahua (CUU)",
            "Ciudad de México (MEX)",
            "Ciudad del Carmen (CME)",
            "Ciudad Juárez (CJS)",
            "Ciudad Obregón (CEN)",
            "Ciudad Victoria (CVM)",
            "Colima (CLQ)",
            "Cozumel (CZM)",
            "Culiacán (CUL)",
            "Durango (DGO)",
            "Guadalajara (GDL)",
            "Hermosillo (HMO)",
            "Huatulco (HUX)",
            "Ixtapa Zihuatanejo (ZIH)",
            "Jalapa (JAL)",
            "La Paz (LAP)",
            "Lázaro Cárdenas (LZC)",
            "León Bajío (BJX)",
            "Los Cabos - Cabo San Lucas (SJD)",
            "Los Mochis (LMM)",
            "Manzanillo (ZLO)",
            "Matamoros (MAM)",
            "Mazatlán (MZT)",
            "Mérida (MID)",
            "Mexicali (MXL)",
            "Minatitlán (MTT)",
            "Monclova (LOV)",
            "Monterrey (MTY)",
            "Morelia (MLM)",
            "Nuevo Laredo (NLD)",
            "Oaxaca (OAX)",
            "Piedras Negras (PDS)",
            "Poza Rica (PAZ)",
            "Puebla (PBC)",
            "Puerto Escondido (PXM)",
            "Puerto Vallarta (PVR)",
            "Querétaro (QRO)",
            "Reynosa (REX)",
            "Riviera Maya - Playa del Carmen (CUN)",
            "Riviera Nayarit (PVR)",
            "Saltillo (SLW)",
            "San Luis Potosí (SLP)",
            "Tampico (TAM)",
            "Tapachula (TAP)",
            "Tepic (TPQ)",
            "Tijuana (TIJ)",
            "Toluca (TLC)",
            "Torreón (TRC)",
            "Tuxtla Gutiérrez (TGZ)",
            "Veracruz (VER)",
            "Villahermosa (VSA)",
            "Zacatecas (ZCL)"});
            this.comboOrigen.Location = new System.Drawing.Point(145, 210);
            this.comboOrigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboOrigen.Name = "comboOrigen";
            this.comboOrigen.Size = new System.Drawing.Size(300, 28);
            this.comboOrigen.TabIndex = 22;
            // 
            // comboAvion
            // 
            this.comboAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAvion.FormattingEnabled = true;
            this.comboAvion.Items.AddRange(new object[] {
            "Pilatus",
            "Embraer 120",
            "Embraer 145"});
            this.comboAvion.Location = new System.Drawing.Point(145, 145);
            this.comboAvion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboAvion.Name = "comboAvion";
            this.comboAvion.Size = new System.Drawing.Size(120, 28);
            this.comboAvion.TabIndex = 21;
            // 
            // dateTimeSalida
            // 
            this.dateTimeSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeSalida.Location = new System.Drawing.Point(305, 80);
            this.dateTimeSalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeSalida.Name = "dateTimeSalida";
            this.dateTimeSalida.Size = new System.Drawing.Size(298, 26);
            this.dateTimeSalida.TabIndex = 19;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(494, 370);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 50);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(366, 370);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(120, 50);
            this.buttonAceptar.TabIndex = 17;
            this.buttonAceptar.Text = "Guardar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(39, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Vuelos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimeHoraSalida
            // 
            this.dateTimeHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHoraSalida.Location = new System.Drawing.Point(474, 212);
            this.dateTimeHoraSalida.Name = "dateTimeHoraSalida";
            this.dateTimeHoraSalida.ShowUpDown = true;
            this.dateTimeHoraSalida.Size = new System.Drawing.Size(120, 26);
            this.dateTimeHoraSalida.TabIndex = 41;
            this.dateTimeHoraSalida.Value = new System.DateTime(2015, 4, 8, 0, 0, 0, 0);
            // 
            // dateTimeHoraLlegada
            // 
            this.dateTimeHoraLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHoraLlegada.Location = new System.Drawing.Point(474, 277);
            this.dateTimeHoraLlegada.Name = "dateTimeHoraLlegada";
            this.dateTimeHoraLlegada.ShowUpDown = true;
            this.dateTimeHoraLlegada.Size = new System.Drawing.Size(120, 26);
            this.dateTimeHoraLlegada.TabIndex = 42;
            this.dateTimeHoraLlegada.Value = new System.DateTime(2015, 4, 8, 0, 0, 0, 0);
            // 
            // textIDVuelo
            // 
            this.textIDVuelo.Enabled = false;
            this.textIDVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDVuelo.Location = new System.Drawing.Point(145, 80);
            this.textIDVuelo.Name = "textIDVuelo";
            this.textIDVuelo.Size = new System.Drawing.Size(100, 26);
            this.textIDVuelo.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "ID del Vuelo:";
            // 
            // textPrecio
            // 
            this.textPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.Location = new System.Drawing.Point(329, 145);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 26);
            this.textPrecio.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Precio:";
            // 
            // VueloEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(653, 436);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textIDVuelo);
            this.Controls.Add(this.dateTimeHoraLlegada);
            this.Controls.Add(this.dateTimeHoraSalida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.comboOrigen);
            this.Controls.Add(this.comboAvion);
            this.Controls.Add(this.dateTimeSalida);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VueloEditar";
            this.Text = "Editar Vuelo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.ComboBox comboOrigen;
        private System.Windows.Forms.ComboBox comboAvion;
        private System.Windows.Forms.DateTimePicker dateTimeSalida;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimeHoraSalida;
        private System.Windows.Forms.DateTimePicker dateTimeHoraLlegada;
        private System.Windows.Forms.TextBox textIDVuelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label9;
    }
}