
namespace PROYECTO_ADADAT
{
    partial class FORM_REPORTE_OCUPACION
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Reporte Clientes", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Reporte Clientes", System.Windows.Forms.HorizontalAlignment.Center);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REPORTE_OCUPACION));
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            label17 = new System.Windows.Forms.Label();
            BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            LV_OCUPACION = new System.Windows.Forms.ListView();
            COL_PAIS = new System.Windows.Forms.ColumnHeader();
            COL_ANIO = new System.Windows.Forms.ColumnHeader();
            COL_CIUDAD = new System.Windows.Forms.ColumnHeader();
            COL_NOMBRE_HOTEL = new System.Windows.Forms.ColumnHeader();
            COL_ANIOMES = new System.Windows.Forms.ColumnHeader();
            COL_TIPO_HABITACION = new System.Windows.Forms.ColumnHeader();
            COL_CANTIDAD_HABITACIONES = new System.Windows.Forms.ColumnHeader();
            COL_PERSONAS_HOSPEDADAS = new System.Windows.Forms.ColumnHeader();
            COL_PORCOCUPACION = new System.Windows.Forms.ColumnHeader();
            LV_RESUMENOCUPACION = new System.Windows.Forms.ListView();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(1140, 354);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(102, 34);
            BTN_SALIR.TabIndex = 3;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(12, 354);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(102, 34);
            BTN_REGRESAR.TabIndex = 2;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(360, 16);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(473, 21);
            label17.TabIndex = 80;
            label17.Text = "AQUÍ SE MUESTRA EL REPORTE DE OCUPACIÓN DE LOS HOTELES!";
            // 
            // BTN_ACTUALIZAR
            // 
            BTN_ACTUALIZAR.Location = new System.Drawing.Point(234, 354);
            BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            BTN_ACTUALIZAR.Size = new System.Drawing.Size(821, 34);
            BTN_ACTUALIZAR.TabIndex = 93;
            BTN_ACTUALIZAR.Text = "ACTUALIZAR REPORTES";
            BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            BTN_ACTUALIZAR.Click += BTN_ACTUALIZAR_Click;
            // 
            // LV_OCUPACION
            // 
            LV_OCUPACION.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { COL_PAIS, COL_ANIO, COL_CIUDAD, COL_NOMBRE_HOTEL, COL_ANIOMES, COL_TIPO_HABITACION, COL_CANTIDAD_HABITACIONES, COL_PERSONAS_HOSPEDADAS, COL_PORCOCUPACION });
            LV_OCUPACION.GridLines = true;
            listViewGroup1.FooterAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Header = "Reporte Clientes";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "LV_CLIENTES";
            LV_OCUPACION.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup1 });
            LV_OCUPACION.HideSelection = false;
            LV_OCUPACION.Location = new System.Drawing.Point(12, 40);
            LV_OCUPACION.Name = "LV_OCUPACION";
            LV_OCUPACION.Size = new System.Drawing.Size(1230, 185);
            LV_OCUPACION.TabIndex = 92;
            LV_OCUPACION.UseCompatibleStateImageBehavior = false;
            LV_OCUPACION.View = System.Windows.Forms.View.Details;
            // 
            // COL_PAIS
            // 
            COL_PAIS.Text = "Pais";
            COL_PAIS.Width = 95;
            // 
            // COL_ANIO
            // 
            COL_ANIO.Text = "Anio";
            COL_ANIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_ANIO.Width = 80;
            // 
            // COL_CIUDAD
            // 
            COL_CIUDAD.Text = "Ciudad";
            COL_CIUDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_CIUDAD.Width = 95;
            // 
            // COL_NOMBRE_HOTEL
            // 
            COL_NOMBRE_HOTEL.Text = "Nombre Hotel";
            COL_NOMBRE_HOTEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_NOMBRE_HOTEL.Width = 300;
            // 
            // COL_ANIOMES
            // 
            COL_ANIOMES.Text = "Mes/Anio";
            COL_ANIOMES.Width = 95;
            // 
            // COL_TIPO_HABITACION
            // 
            COL_TIPO_HABITACION.Text = "Tipo Habitacion";
            COL_TIPO_HABITACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_TIPO_HABITACION.Width = 105;
            // 
            // COL_CANTIDAD_HABITACIONES
            // 
            COL_CANTIDAD_HABITACIONES.Text = "Cantidad Habitaciones";
            COL_CANTIDAD_HABITACIONES.Width = 120;
            // 
            // COL_PERSONAS_HOSPEDADAS
            // 
            COL_PERSONAS_HOSPEDADAS.Text = "Personas Hospedadas";
            COL_PERSONAS_HOSPEDADAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_PERSONAS_HOSPEDADAS.Width = 90;
            // 
            // COL_PORCOCUPACION
            // 
            COL_PORCOCUPACION.Text = "% Ocupacion";
            COL_PORCOCUPACION.Width = 100;
            // 
            // LV_RESUMENOCUPACION
            // 
            LV_RESUMENOCUPACION.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader8 });
            LV_RESUMENOCUPACION.GridLines = true;
            listViewGroup2.FooterAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Header = "Reporte Clientes";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "LV_CLIENTES";
            LV_RESUMENOCUPACION.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup2 });
            LV_RESUMENOCUPACION.HideSelection = false;
            LV_RESUMENOCUPACION.Location = new System.Drawing.Point(234, 231);
            LV_RESUMENOCUPACION.Name = "LV_RESUMENOCUPACION";
            LV_RESUMENOCUPACION.Size = new System.Drawing.Size(821, 117);
            LV_RESUMENOCUPACION.TabIndex = 94;
            LV_RESUMENOCUPACION.UseCompatibleStateImageBehavior = false;
            LV_RESUMENOCUPACION.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ciudad";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nombre Hotel";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mes/Anio";
            columnHeader5.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "% Ocupacion";
            columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader8.Width = 90;
            // 
            // FORM_REPORTE_OCUPACION
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1254, 398);
            ControlBox = false;
            Controls.Add(LV_RESUMENOCUPACION);
            Controls.Add(BTN_ACTUALIZAR);
            Controls.Add(LV_OCUPACION);
            Controls.Add(label17);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_REGRESAR);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REPORTE_OCUPACION";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Reporte de Ocupación de los Hoteles!";
            Load += FORM_REPORTE_OCUPACION_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BTN_ACTUALIZAR;
        private System.Windows.Forms.ListView LV_OCUPACION;
        private System.Windows.Forms.ColumnHeader COL_PAIS;
        private System.Windows.Forms.ColumnHeader COL_ANIO;
        private System.Windows.Forms.ColumnHeader COL_CIUDAD;
        private System.Windows.Forms.ColumnHeader COL_NOMBRE_HOTEL;
        private System.Windows.Forms.ColumnHeader COL_TIPO_HABITACION;
        private System.Windows.Forms.ColumnHeader COL_PERSONAS_HOSPEDADAS;
        private System.Windows.Forms.ColumnHeader COL_ANIOMES;
        private System.Windows.Forms.ColumnHeader COL_CANTIDAD_HABITACIONES;
        private System.Windows.Forms.ColumnHeader COL_PORCOCUPACION;
        private System.Windows.Forms.ListView LV_RESUMENOCUPACION;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}