
namespace PROYECTO_ADADAT
{
    partial class FORM_REPORTE_VENTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REPORTE_VENTAS));
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            label17 = new System.Windows.Forms.Label();
            LV_VENTAS = new System.Windows.Forms.ListView();
            COL_PAIS = new System.Windows.Forms.ColumnHeader();
            COL_ANIO = new System.Windows.Forms.ColumnHeader();
            COL_CIUDAD = new System.Windows.Forms.ColumnHeader();
            COL_NOMBRE_HOTEL = new System.Windows.Forms.ColumnHeader();
            COL_ANIOMES = new System.Windows.Forms.ColumnHeader();
            COL_INGRESOS_HOSPEDAJE = new System.Windows.Forms.ColumnHeader();
            COL_INGRESOS_SERVADIC = new System.Windows.Forms.ColumnHeader();
            COL_INGRESOS_TOTALES = new System.Windows.Forms.ColumnHeader();
            BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(1146, 266);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(102, 34);
            BTN_SALIR.TabIndex = 3;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(18, 266);
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
            label17.Location = new System.Drawing.Point(433, 17);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(318, 21);
            label17.TabIndex = 84;
            label17.Text = "AQUÍ SE MUESTRA EL REPORTE DE VENTAS!";
            // 
            // LV_VENTAS
            // 
            LV_VENTAS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { COL_PAIS, COL_ANIO, COL_CIUDAD, COL_NOMBRE_HOTEL, COL_ANIOMES, COL_INGRESOS_HOSPEDAJE, COL_INGRESOS_SERVADIC, COL_INGRESOS_TOTALES });
            LV_VENTAS.GridLines = true;
            listViewGroup1.FooterAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Header = "Reporte Clientes";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "LV_CLIENTES";
            LV_VENTAS.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup1 });
            LV_VENTAS.HideSelection = false;
            LV_VENTAS.Location = new System.Drawing.Point(18, 54);
            LV_VENTAS.Name = "LV_VENTAS";
            LV_VENTAS.Size = new System.Drawing.Size(1230, 185);
            LV_VENTAS.TabIndex = 93;
            LV_VENTAS.UseCompatibleStateImageBehavior = false;
            LV_VENTAS.View = System.Windows.Forms.View.Details;
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
            // COL_INGRESOS_HOSPEDAJE
            // 
            COL_INGRESOS_HOSPEDAJE.Text = "Ingresos Hospedaje";
            COL_INGRESOS_HOSPEDAJE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            COL_INGRESOS_HOSPEDAJE.Width = 105;
            // 
            // COL_INGRESOS_SERVADIC
            // 
            COL_INGRESOS_SERVADIC.Text = "Ingresos Serv. Adic.";
            COL_INGRESOS_SERVADIC.Width = 120;
            // 
            // COL_INGRESOS_TOTALES
            // 
            COL_INGRESOS_TOTALES.Text = "Ingresos Totales";
            COL_INGRESOS_TOTALES.Width = 100;
            // 
            // BTN_ACTUALIZAR
            // 
            BTN_ACTUALIZAR.Location = new System.Drawing.Point(455, 266);
            BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            BTN_ACTUALIZAR.Size = new System.Drawing.Size(339, 34);
            BTN_ACTUALIZAR.TabIndex = 94;
            BTN_ACTUALIZAR.Text = "ACTUALIZAR REPORTES";
            BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            BTN_ACTUALIZAR.Click += BTN_ACTUALIZAR_Click;
            // 
            // FORM_REPORTE_VENTAS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1262, 314);
            ControlBox = false;
            Controls.Add(BTN_ACTUALIZAR);
            Controls.Add(LV_VENTAS);
            Controls.Add(label17);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_REGRESAR);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REPORTE_VENTAS";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Reporte de Ventas!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView LV_VENTAS;
        private System.Windows.Forms.ColumnHeader COL_PAIS;
        private System.Windows.Forms.ColumnHeader COL_ANIO;
        private System.Windows.Forms.ColumnHeader COL_CIUDAD;
        private System.Windows.Forms.ColumnHeader COL_NOMBRE_HOTEL;
        private System.Windows.Forms.ColumnHeader COL_ANIOMES;
        private System.Windows.Forms.ColumnHeader COL_INGRESOS_HOSPEDAJE;
        private System.Windows.Forms.ColumnHeader COL_INGRESOS_SERVADIC;
        private System.Windows.Forms.ColumnHeader COL_INGRESOS_TOTALES;
        private System.Windows.Forms.Button BTN_ACTUALIZAR;
    }
}