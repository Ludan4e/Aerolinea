namespace Aerolinea
{
    partial class ReservacionesServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservacionesServicios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPasajero = new System.Windows.Forms.Label();
            this.dataGridServicios = new System.Windows.Forms.DataGridView();
            this.comboPasajero = new System.Windows.Forms.ComboBox();
            this.groupTitulo = new System.Windows.Forms.GroupBox();
            this.pictureAyuda = new System.Windows.Forms.PictureBox();
            this.labelServiciosReservacion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelServicios = new System.Windows.Forms.Label();
            this.labelTxtServicios = new System.Windows.Forms.Label();
            this.labelPrecioSalida = new System.Windows.Forms.Label();
            this.labelTxtSalida = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCostoTotal = new System.Windows.Forms.Label();
            this.labelTxtTotal = new System.Windows.Forms.Label();
            this.labelPrecioRegreso = new System.Windows.Forms.Label();
            this.labelIVA = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.labelTxtDescuento = new System.Windows.Forms.Label();
            this.labelTxtIVA = new System.Windows.Forms.Label();
            this.labelTxtRegreso = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).BeginInit();
            this.groupTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAyuda)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(771, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.groupBox1.Controls.Add(this.labelPasajero);
            this.groupBox1.Controls.Add(this.dataGridServicios);
            this.groupBox1.Controls.Add(this.comboPasajero);
            this.groupBox1.Location = new System.Drawing.Point(21, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 400);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // labelPasajero
            // 
            this.labelPasajero.AutoSize = true;
            this.labelPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasajero.Location = new System.Drawing.Point(13, 16);
            this.labelPasajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasajero.Name = "labelPasajero";
            this.labelPasajero.Size = new System.Drawing.Size(71, 20);
            this.labelPasajero.TabIndex = 11;
            this.labelPasajero.Text = "Pasajero";
            // 
            // dataGridServicios
            // 
            this.dataGridServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.dataGridServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServicios.Location = new System.Drawing.Point(7, 77);
            this.dataGridServicios.Name = "dataGridServicios";
            this.dataGridServicios.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridServicios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridServicios.Size = new System.Drawing.Size(726, 317);
            this.dataGridServicios.TabIndex = 0;
            this.dataGridServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridServicios_CellClick);
            // 
            // comboPasajero
            // 
            this.comboPasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPasajero.FormattingEnabled = true;
            this.comboPasajero.Location = new System.Drawing.Point(17, 41);
            this.comboPasajero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPasajero.Name = "comboPasajero";
            this.comboPasajero.Size = new System.Drawing.Size(113, 28);
            this.comboPasajero.TabIndex = 10;
            // 
            // groupTitulo
            // 
            this.groupTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.groupTitulo.Controls.Add(this.pictureAyuda);
            this.groupTitulo.Controls.Add(this.labelServiciosReservacion);
            this.groupTitulo.Location = new System.Drawing.Point(97, 12);
            this.groupTitulo.Name = "groupTitulo";
            this.groupTitulo.Size = new System.Drawing.Size(868, 123);
            this.groupTitulo.TabIndex = 43;
            this.groupTitulo.TabStop = false;
            // 
            // pictureAyuda
            // 
            this.pictureAyuda.Image = ((System.Drawing.Image)(resources.GetObject("pictureAyuda.Image")));
            this.pictureAyuda.Location = new System.Drawing.Point(808, 16);
            this.pictureAyuda.Name = "pictureAyuda";
            this.pictureAyuda.Size = new System.Drawing.Size(49, 50);
            this.pictureAyuda.TabIndex = 45;
            this.pictureAyuda.TabStop = false;
            this.pictureAyuda.Click += new System.EventHandler(this.pictureAyuda_Click);
            // 
            // labelServiciosReservacion
            // 
            this.labelServiciosReservacion.AutoSize = true;
            this.labelServiciosReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiciosReservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelServiciosReservacion.Location = new System.Drawing.Point(17, 41);
            this.labelServiciosReservacion.Name = "labelServiciosReservacion";
            this.labelServiciosReservacion.Size = new System.Drawing.Size(481, 54);
            this.labelServiciosReservacion.TabIndex = 0;
            this.labelServiciosReservacion.Text = "Servicios adicionales";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.groupBox2.Controls.Add(this.buttonSalir);
            this.groupBox2.Controls.Add(this.buttonRegresar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(21, 545);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(945, 64);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegresar.Location = new System.Drawing.Point(7, 11);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(155, 48);
            this.buttonRegresar.TabIndex = 43;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.groupBox3.Controls.Add(this.labelServicios);
            this.groupBox3.Controls.Add(this.labelTxtServicios);
            this.groupBox3.Controls.Add(this.labelPrecioSalida);
            this.groupBox3.Controls.Add(this.labelTxtSalida);
            this.groupBox3.Controls.Add(this.labelTitulo);
            this.groupBox3.Controls.Add(this.labelCostoTotal);
            this.groupBox3.Controls.Add(this.labelTxtTotal);
            this.groupBox3.Controls.Add(this.labelPrecioRegreso);
            this.groupBox3.Controls.Add(this.labelIVA);
            this.groupBox3.Controls.Add(this.labelDescuento);
            this.groupBox3.Controls.Add(this.labelTxtDescuento);
            this.groupBox3.Controls.Add(this.labelTxtIVA);
            this.groupBox3.Controls.Add(this.labelTxtRegreso);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(766, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 400);
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
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(7, 35);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(180, 20);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Información de Vuelo";
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
            this.buttonSalir.Location = new System.Drawing.Point(452, 15);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(51, 41);
            this.buttonSalir.TabIndex = 45;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // ReservacionesServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 616);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservacionesServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios adicionales";
            this.Load += new System.EventHandler(this.ReservacionesServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).EndInit();
            this.groupTitulo.ResumeLayout(false);
            this.groupTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAyuda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupTitulo;
        private System.Windows.Forms.Label labelServiciosReservacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.DataGridView dataGridServicios;
        private System.Windows.Forms.Label labelPasajero;
        private System.Windows.Forms.ComboBox comboPasajero;
        private System.Windows.Forms.PictureBox pictureAyuda;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelServicios;
        private System.Windows.Forms.Label labelTxtServicios;
        private System.Windows.Forms.Label labelPrecioSalida;
        private System.Windows.Forms.Label labelTxtSalida;
        private System.Windows.Forms.Label labelTitulo;
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