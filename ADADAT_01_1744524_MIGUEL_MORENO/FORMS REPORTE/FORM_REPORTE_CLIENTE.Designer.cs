
namespace PROYECTO_ADADAT
{
    partial class FORM_REPORTE_CLIENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REPORTE_CLIENTE));
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Reporte Clientes", System.Windows.Forms.HorizontalAlignment.Center);
            BTN_REGRESAR = new System.Windows.Forms.Button();
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_FILTROANO = new System.Windows.Forms.Button();
            BTN_FILTRORFC = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            TXT_FILTRO = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            LV_HISTORIALCLIENTE = new System.Windows.Forms.ListView();
            COL_RFC = new System.Windows.Forms.ColumnHeader();
            COL_ANIO = new System.Windows.Forms.ColumnHeader();
            COL_NOMBRE_CLIENTE = new System.Windows.Forms.ColumnHeader();
            COL_CIUDAD = new System.Windows.Forms.ColumnHeader();
            COL_NOMBRE_HOTEL = new System.Windows.Forms.ColumnHeader();
            COL_TIPO_HABITACION = new System.Windows.Forms.ColumnHeader();
            COL_NUMERO_HABITACION = new System.Windows.Forms.ColumnHeader();
            COL_PERSONAS_HOSPEDADAS = new System.Windows.Forms.ColumnHeader();
            COL_CODIGO_RESERVACION = new System.Windows.Forms.ColumnHeader();
            COL_FECHA_RESERVACION = new System.Windows.Forms.ColumnHeader();
            COL_FECHA_CHECKIN = new System.Windows.Forms.ColumnHeader();
            COL_FECHA_CHECKOUT = new System.Windows.Forms.ColumnHeader();
            COL_ESTATUS_RESERVACION = new System.Windows.Forms.ColumnHeader();
            COL_ANTICIPO = new System.Windows.Forms.ColumnHeader();
            COL_MONTO_HOSPEDAJE = new System.Windows.Forms.ColumnHeader();
            COL_MONTO_SERVICIOS = new System.Windows.Forms.ColumnHeader();
            COL_TOTAL_FACTURA = new System.Windows.Forms.ColumnHeader();
            BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(12, 359);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(102, 34);
            BTN_REGRESAR.TabIndex = 0;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(1125, 359);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(102, 34);
            BTN_SALIR.TabIndex = 1;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_FILTROANO
            // 
            BTN_FILTROANO.Location = new System.Drawing.Point(986, 32);
            BTN_FILTROANO.Name = "BTN_FILTROANO";
            BTN_FILTROANO.Size = new System.Drawing.Size(75, 23);
            BTN_FILTROANO.TabIndex = 12;
            BTN_FILTROANO.Text = "AÑO";
            BTN_FILTROANO.UseVisualStyleBackColor = true;
            // 
            // BTN_FILTRORFC
            // 
            BTN_FILTRORFC.Location = new System.Drawing.Point(416, 32);
            BTN_FILTRORFC.Name = "BTN_FILTRORFC";
            BTN_FILTRORFC.Size = new System.Drawing.Size(75, 23);
            BTN_FILTRORFC.TabIndex = 11;
            BTN_FILTRORFC.Text = "RFC";
            BTN_FILTRORFC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 15);
            label1.TabIndex = 10;
            label1.Text = "Filtrar por:";
            // 
            // TXT_FILTRO
            // 
            TXT_FILTRO.Location = new System.Drawing.Point(136, 32);
            TXT_FILTRO.Name = "TXT_FILTRO";
            TXT_FILTRO.Size = new System.Drawing.Size(274, 23);
            TXT_FILTRO.TabIndex = 87;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 15);
            label2.TabIndex = 86;
            label2.Text = "Ingrese un RFC aqui:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(12, 58);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(1142, 15);
            label22.TabIndex = 85;
            label22.Text = resources.GetString("label22.Text");
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(438, 72);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(329, 21);
            label17.TabIndex = 84;
            label17.Text = "AQUÍ SE MUESTRA EL REPORTE DE CLIENTES!";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(706, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(274, 23);
            textBox1.TabIndex = 89;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(581, 36);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 15);
            label3.TabIndex = 88;
            label3.Text = "Ingrese un Anio aqui:";
            // 
            // LV_HISTORIALCLIENTE
            // 
            LV_HISTORIALCLIENTE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { COL_RFC, COL_ANIO, COL_NOMBRE_CLIENTE, COL_CIUDAD, COL_NOMBRE_HOTEL, COL_TIPO_HABITACION, COL_NUMERO_HABITACION, COL_PERSONAS_HOSPEDADAS, COL_CODIGO_RESERVACION, COL_FECHA_RESERVACION, COL_FECHA_CHECKIN, COL_FECHA_CHECKOUT, COL_ESTATUS_RESERVACION, COL_ANTICIPO, COL_MONTO_HOSPEDAJE, COL_MONTO_SERVICIOS, COL_TOTAL_FACTURA });
            LV_HISTORIALCLIENTE.GridLines = true;
            listViewGroup2.FooterAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Header = "Reporte Clientes";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "LV_CLIENTES";
            LV_HISTORIALCLIENTE.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup2 });
            LV_HISTORIALCLIENTE.HideSelection = false;
            LV_HISTORIALCLIENTE.Location = new System.Drawing.Point(4, 109);
            LV_HISTORIALCLIENTE.Name = "LV_HISTORIALCLIENTE";
            LV_HISTORIALCLIENTE.Size = new System.Drawing.Size(1230, 229);
            LV_HISTORIALCLIENTE.TabIndex = 90;
            LV_HISTORIALCLIENTE.UseCompatibleStateImageBehavior = false;
            LV_HISTORIALCLIENTE.View = System.Windows.Forms.View.Details;
            // 
            // COL_RFC
            // 
            COL_RFC.Text = "RFC";
            // 
            // COL_ANIO
            // 
            COL_ANIO.Text = "Anio";
            COL_ANIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_NOMBRE_CLIENTE
            // 
            COL_NOMBRE_CLIENTE.Text = "Nombre Cliente";
            COL_NOMBRE_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_NOMBRE_CLIENTE.Width = 120;
            // 
            // COL_CIUDAD
            // 
            COL_CIUDAD.Text = "Ciudad";
            COL_CIUDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_NOMBRE_HOTEL
            // 
            COL_NOMBRE_HOTEL.Text = "Nombre Hotel";
            COL_NOMBRE_HOTEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_NOMBRE_HOTEL.Width = 120;
            // 
            // COL_TIPO_HABITACION
            // 
            COL_TIPO_HABITACION.Text = "Tipo Habitacion";
            COL_TIPO_HABITACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_TIPO_HABITACION.Width = 80;
            // 
            // COL_NUMERO_HABITACION
            // 
            COL_NUMERO_HABITACION.Text = "Numero Habitacion";
            COL_NUMERO_HABITACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_PERSONAS_HOSPEDADAS
            // 
            COL_PERSONAS_HOSPEDADAS.Text = "Personas Hospedadas";
            COL_PERSONAS_HOSPEDADAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_CODIGO_RESERVACION
            // 
            COL_CODIGO_RESERVACION.Text = "Codigo Reservacion";
            COL_CODIGO_RESERVACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_CODIGO_RESERVACION.Width = 120;
            // 
            // COL_FECHA_RESERVACION
            // 
            COL_FECHA_RESERVACION.Text = "Fecha Reservacion";
            COL_FECHA_RESERVACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_FECHA_CHECKIN
            // 
            COL_FECHA_CHECKIN.Text = "Fecha CheckIn";
            COL_FECHA_CHECKIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_FECHA_CHECKOUT
            // 
            COL_FECHA_CHECKOUT.Text = "Fecha CheckOut";
            COL_FECHA_CHECKOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_ESTATUS_RESERVACION
            // 
            COL_ESTATUS_RESERVACION.Text = "Estatus Reservacion";
            COL_ESTATUS_RESERVACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_ANTICIPO
            // 
            COL_ANTICIPO.Text = "Anticipo";
            COL_ANTICIPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_MONTO_HOSPEDAJE
            // 
            COL_MONTO_HOSPEDAJE.Text = "Monto Hospedaje";
            COL_MONTO_HOSPEDAJE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_MONTO_SERVICIOS
            // 
            COL_MONTO_SERVICIOS.Text = "Monto Servicios";
            COL_MONTO_SERVICIOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COL_TOTAL_FACTURA
            // 
            COL_TOTAL_FACTURA.Text = "Total Factura";
            COL_TOTAL_FACTURA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_ACTUALIZAR
            // 
            BTN_ACTUALIZAR.Location = new System.Drawing.Point(416, 359);
            BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            BTN_ACTUALIZAR.Size = new System.Drawing.Size(339, 34);
            BTN_ACTUALIZAR.TabIndex = 91;
            BTN_ACTUALIZAR.Text = "ACTUALIZAR REPORTE";
            BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            BTN_ACTUALIZAR.Click += BTN_ACTUALIZAR_Click;
            // 
            // FORM_REPORTE_CLIENTE
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1239, 405);
            ControlBox = false;
            Controls.Add(BTN_ACTUALIZAR);
            Controls.Add(LV_HISTORIALCLIENTE);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(TXT_FILTRO);
            Controls.Add(label2);
            Controls.Add(label22);
            Controls.Add(label17);
            Controls.Add(BTN_FILTROANO);
            Controls.Add(BTN_FILTRORFC);
            Controls.Add(label1);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_REGRESAR);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REPORTE_CLIENTE";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Reporte de Clientes!";
            Load += FORM_REPORTE_CLIENTE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_FILTROANO;
        private System.Windows.Forms.Button BTN_FILTRORFC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_FILTRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView LV_HISTORIALCLIENTE;
        private System.Windows.Forms.ColumnHeader COL_RFC;
        private System.Windows.Forms.ColumnHeader COL_ANIO;
        private System.Windows.Forms.ColumnHeader COL_NOMBRE_CLIENTE;
        private System.Windows.Forms.ColumnHeader COL_CIUDAD;
        private System.Windows.Forms.ColumnHeader COL_NOMBRE_HOTEL;
        private System.Windows.Forms.ColumnHeader COL_TIPO_HABITACION;
        private System.Windows.Forms.ColumnHeader COL_NUMERO_HABITACION;
        private System.Windows.Forms.ColumnHeader COL_PERSONAS_HOSPEDADAS;
        private System.Windows.Forms.ColumnHeader COL_CODIGO_RESERVACION;
        private System.Windows.Forms.ColumnHeader COL_FECHA_RESERVACION;
        private System.Windows.Forms.ColumnHeader COL_FECHA_CHECKIN;
        private System.Windows.Forms.ColumnHeader COL_FECHA_CHECKOUT;
        private System.Windows.Forms.ColumnHeader COL_ESTATUS_RESERVACION;
        private System.Windows.Forms.ColumnHeader COL_ANTICIPO;
        private System.Windows.Forms.ColumnHeader COL_MONTO_HOSPEDAJE;
        private System.Windows.Forms.ColumnHeader COL_MONTO_SERVICIOS;
        private System.Windows.Forms.ColumnHeader COL_TOTAL_FACTURA;
        private System.Windows.Forms.Button BTN_ACTUALIZAR;
    }
}