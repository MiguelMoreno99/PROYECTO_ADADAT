
namespace PROYECTO_ADADAT
{
    partial class FORM_REGISTRO_PAGORESERVACION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REGISTRO_PAGORESERVACION));
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_COBRAR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            TXT_SERVICIOSADICIONALES = new System.Windows.Forms.TextBox();
            TXT_SERVICIOSUTILIZADOS = new System.Windows.Forms.TextBox();
            CB_NUMEROSERVICIOSUTILIZADOS = new System.Windows.Forms.ComboBox();
            BTN_EXTENDERESTANCIA = new System.Windows.Forms.Button();
            TXT_COSTOHOTEL = new System.Windows.Forms.TextBox();
            TXT_COSTOSERVICIOSADICIONALES = new System.Windows.Forms.TextBox();
            TXT_ANTICIPO = new System.Windows.Forms.TextBox();
            TXT_DESCUENTODADO = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            TXT_TOTALPAGAR = new System.Windows.Forms.TextBox();
            label18 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            CB_DESCUENTO = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(495, 514);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 97;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_COBRAR
            // 
            BTN_COBRAR.Location = new System.Drawing.Point(102, 514);
            BTN_COBRAR.Name = "BTN_COBRAR";
            BTN_COBRAR.Size = new System.Drawing.Size(228, 35);
            BTN_COBRAR.TabIndex = 96;
            BTN_COBRAR.Text = "HACER EL COBRO Y GENERAR FACTURA ";
            BTN_COBRAR.UseVisualStyleBackColor = true;
            BTN_COBRAR.Click += BTN_GUARDAR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(12, 514);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 95;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(91, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(496, 21);
            label1.TabIndex = 94;
            label1.Text = "ESTE ES EL APARTADO PARA EL COBRO Y GENERACIÓN DE FACTURA!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(53, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 45);
            label2.TabIndex = 98;
            label2.Text = "Servicios adicionales de la\r\nhabitacion en la que se\r\nhospedó:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(204, 255);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(237, 15);
            label3.TabIndex = 99;
            label3.Text = "*Costo por cada servicio utilizado:   350.00 $";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(54, 189);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(138, 30);
            label4.TabIndex = 100;
            label4.Text = "Resumen de los servicios\r\nutilizados:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(54, 282);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(118, 30);
            label5.TabIndex = 101;
            label5.Text = "Numero de servicios \r\nutilizados:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(297, 290);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(186, 15);
            label6.TabIndex = 102;
            label6.Text = "Descuento aplicado (si es el caso):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(136, 345);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(111, 15);
            label7.TabIndex = 103;
            label7.Text = "+   Costo por Hotel:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(136, 401);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(99, 15);
            label8.TabIndex = 104;
            label8.Text = "-   Anticipo dado:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(136, 429);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(110, 15);
            label9.TabIndex = 105;
            label9.Text = "-   Descuento dado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(593, 290);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(17, 15);
            label10.TabIndex = 106;
            label10.Text = "%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(138, 373);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(192, 15);
            label11.TabIndex = 107;
            label11.Text = "+   Costo por Servicios Adicionales:";
            // 
            // TXT_SERVICIOSADICIONALES
            // 
            TXT_SERVICIOSADICIONALES.Location = new System.Drawing.Point(202, 120);
            TXT_SERVICIOSADICIONALES.Multiline = true;
            TXT_SERVICIOSADICIONALES.Name = "TXT_SERVICIOSADICIONALES";
            TXT_SERVICIOSADICIONALES.ReadOnly = true;
            TXT_SERVICIOSADICIONALES.Size = new System.Drawing.Size(422, 63);
            TXT_SERVICIOSADICIONALES.TabIndex = 108;
            // 
            // TXT_SERVICIOSUTILIZADOS
            // 
            TXT_SERVICIOSUTILIZADOS.Location = new System.Drawing.Point(202, 189);
            TXT_SERVICIOSUTILIZADOS.Multiline = true;
            TXT_SERVICIOSUTILIZADOS.Name = "TXT_SERVICIOSUTILIZADOS";
            TXT_SERVICIOSUTILIZADOS.Size = new System.Drawing.Size(422, 63);
            TXT_SERVICIOSUTILIZADOS.TabIndex = 109;
            // 
            // CB_NUMEROSERVICIOSUTILIZADOS
            // 
            CB_NUMEROSERVICIOSUTILIZADOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_NUMEROSERVICIOSUTILIZADOS.FormattingEnabled = true;
            CB_NUMEROSERVICIOSUTILIZADOS.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            CB_NUMEROSERVICIOSUTILIZADOS.Location = new System.Drawing.Point(180, 287);
            CB_NUMEROSERVICIOSUTILIZADOS.Name = "CB_NUMEROSERVICIOSUTILIZADOS";
            CB_NUMEROSERVICIOSUTILIZADOS.Size = new System.Drawing.Size(102, 23);
            CB_NUMEROSERVICIOSUTILIZADOS.TabIndex = 110;
            CB_NUMEROSERVICIOSUTILIZADOS.SelectedIndexChanged += CB_NUMEROSERVICIOSUTILIZADOS_SelectedIndexChanged;
            // 
            // BTN_EXTENDERESTANCIA
            // 
            BTN_EXTENDERESTANCIA.Enabled = false;
            BTN_EXTENDERESTANCIA.Location = new System.Drawing.Point(336, 514);
            BTN_EXTENDERESTANCIA.Name = "BTN_EXTENDERESTANCIA";
            BTN_EXTENDERESTANCIA.Size = new System.Drawing.Size(131, 35);
            BTN_EXTENDERESTANCIA.TabIndex = 112;
            BTN_EXTENDERESTANCIA.Text = "EXTENDER ESTANCIA";
            BTN_EXTENDERESTANCIA.UseVisualStyleBackColor = true;
            BTN_EXTENDERESTANCIA.Click += button1_Click;
            // 
            // TXT_COSTOHOTEL
            // 
            TXT_COSTOHOTEL.Location = new System.Drawing.Point(253, 341);
            TXT_COSTOHOTEL.Name = "TXT_COSTOHOTEL";
            TXT_COSTOHOTEL.ReadOnly = true;
            TXT_COSTOHOTEL.Size = new System.Drawing.Size(134, 23);
            TXT_COSTOHOTEL.TabIndex = 113;
            TXT_COSTOHOTEL.Text = "0";
            TXT_COSTOHOTEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            TXT_COSTOHOTEL.TextChanged += TXT_COSTOHOTEL_TextChanged;
            // 
            // TXT_COSTOSERVICIOSADICIONALES
            // 
            TXT_COSTOSERVICIOSADICIONALES.Location = new System.Drawing.Point(336, 370);
            TXT_COSTOSERVICIOSADICIONALES.Name = "TXT_COSTOSERVICIOSADICIONALES";
            TXT_COSTOSERVICIOSADICIONALES.ReadOnly = true;
            TXT_COSTOSERVICIOSADICIONALES.Size = new System.Drawing.Size(134, 23);
            TXT_COSTOSERVICIOSADICIONALES.TabIndex = 114;
            TXT_COSTOSERVICIOSADICIONALES.Text = "0";
            TXT_COSTOSERVICIOSADICIONALES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            TXT_COSTOSERVICIOSADICIONALES.TextChanged += TXT_COSTOSERVICIOSADICIONALES_TextChanged;
            // 
            // TXT_ANTICIPO
            // 
            TXT_ANTICIPO.Location = new System.Drawing.Point(241, 398);
            TXT_ANTICIPO.Name = "TXT_ANTICIPO";
            TXT_ANTICIPO.ReadOnly = true;
            TXT_ANTICIPO.Size = new System.Drawing.Size(134, 23);
            TXT_ANTICIPO.TabIndex = 115;
            TXT_ANTICIPO.Text = "0";
            TXT_ANTICIPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            TXT_ANTICIPO.TextChanged += TXT_ANTICIPO_TextChanged;
            // 
            // TXT_DESCUENTODADO
            // 
            TXT_DESCUENTODADO.Location = new System.Drawing.Point(252, 426);
            TXT_DESCUENTODADO.Name = "TXT_DESCUENTODADO";
            TXT_DESCUENTODADO.ReadOnly = true;
            TXT_DESCUENTODADO.Size = new System.Drawing.Size(134, 23);
            TXT_DESCUENTODADO.TabIndex = 116;
            TXT_DESCUENTODADO.Text = "0";
            TXT_DESCUENTODADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            TXT_DESCUENTODADO.TextChanged += TXT_DESCUENTODADO_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(393, 345);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(13, 15);
            label12.TabIndex = 117;
            label12.Text = "$";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(476, 373);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(13, 15);
            label13.TabIndex = 118;
            label13.Text = "$";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(381, 401);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(13, 15);
            label14.TabIndex = 119;
            label14.Text = "$";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(392, 429);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(13, 15);
            label15.TabIndex = 120;
            label15.Text = "$";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(154, 449);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(237, 15);
            label16.TabIndex = 121;
            label16.Text = "______________________________________________";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(158, 474);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(77, 15);
            label17.TabIndex = 122;
            label17.Text = "Total a pagar:";
            // 
            // TXT_TOTALPAGAR
            // 
            TXT_TOTALPAGAR.Location = new System.Drawing.Point(241, 471);
            TXT_TOTALPAGAR.Name = "TXT_TOTALPAGAR";
            TXT_TOTALPAGAR.ReadOnly = true;
            TXT_TOTALPAGAR.Size = new System.Drawing.Size(134, 23);
            TXT_TOTALPAGAR.TabIndex = 123;
            TXT_TOTALPAGAR.Text = "0";
            TXT_TOTALPAGAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(381, 474);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(13, 15);
            label18.TabIndex = 124;
            label18.Text = "$";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(180, 46);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(331, 49);
            button1.TabIndex = 125;
            button1.Text = "CARGAR INFORMACION";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // CB_DESCUENTO
            // 
            CB_DESCUENTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_DESCUENTO.FormattingEnabled = true;
            CB_DESCUENTO.Items.AddRange(new object[] { "0", "5", "10", "15" });
            CB_DESCUENTO.Location = new System.Drawing.Point(497, 287);
            CB_DESCUENTO.Name = "CB_DESCUENTO";
            CB_DESCUENTO.Size = new System.Drawing.Size(90, 23);
            CB_DESCUENTO.TabIndex = 126;
            CB_DESCUENTO.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FORM_REGISTRO_PAGORESERVACION
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(655, 561);
            ControlBox = false;
            Controls.Add(CB_DESCUENTO);
            Controls.Add(button1);
            Controls.Add(label18);
            Controls.Add(TXT_TOTALPAGAR);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(TXT_DESCUENTODADO);
            Controls.Add(TXT_ANTICIPO);
            Controls.Add(TXT_COSTOSERVICIOSADICIONALES);
            Controls.Add(TXT_COSTOHOTEL);
            Controls.Add(BTN_EXTENDERESTANCIA);
            Controls.Add(CB_NUMEROSERVICIOSUTILIZADOS);
            Controls.Add(TXT_SERVICIOSUTILIZADOS);
            Controls.Add(TXT_SERVICIOSADICIONALES);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_COBRAR);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REGISTRO_PAGORESERVACION";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al apartado de Cobro y Generacion de Factura!";
            Load += FORM_REGISTRO_PAGORESERVACION_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_COBRAR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_SERVICIOSADICIONALES;
        private System.Windows.Forms.TextBox TXT_SERVICIOSUTILIZADOS;
        private System.Windows.Forms.ComboBox CB_NUMEROSERVICIOSUTILIZADOS;
        private System.Windows.Forms.Button BTN_EXTENDERESTANCIA;
        private System.Windows.Forms.TextBox TXT_COSTOHOTEL;
        private System.Windows.Forms.TextBox TXT_COSTOSERVICIOSADICIONALES;
        private System.Windows.Forms.TextBox TXT_ANTICIPO;
        private System.Windows.Forms.TextBox TXT_DESCUENTODADO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXT_TOTALPAGAR;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_DESCUENTO;
    }
}