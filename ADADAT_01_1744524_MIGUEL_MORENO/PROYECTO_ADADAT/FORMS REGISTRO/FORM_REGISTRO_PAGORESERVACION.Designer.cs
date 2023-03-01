
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
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_COBRAR = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_SERVICIOSADICIONALES = new System.Windows.Forms.TextBox();
            this.TXT_SERVICIOSUTILIZADOS = new System.Windows.Forms.TextBox();
            this.CB_NUMEROSERVICIOSUTILIZADOS = new System.Windows.Forms.ComboBox();
            this.TXT_DESCUENTO = new System.Windows.Forms.TextBox();
            this.BTN_EXTENDERESTANCIA = new System.Windows.Forms.Button();
            this.TXT_COSTOHOTEL = new System.Windows.Forms.TextBox();
            this.TXT_COSTOSERVICIOSADICIONALES = new System.Windows.Forms.TextBox();
            this.TXT_ANTICIPO = new System.Windows.Forms.TextBox();
            this.TXT_DESCUENTODADO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_TOTALPAGAR = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(487, 542);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            this.BTN_SALIR.TabIndex = 97;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_COBRAR
            // 
            this.BTN_COBRAR.Location = new System.Drawing.Point(102, 542);
            this.BTN_COBRAR.Name = "BTN_COBRAR";
            this.BTN_COBRAR.Size = new System.Drawing.Size(228, 35);
            this.BTN_COBRAR.TabIndex = 96;
            this.BTN_COBRAR.Text = "HACER EL COBRO Y GENERAR FACTURA ";
            this.BTN_COBRAR.UseVisualStyleBackColor = true;
            this.BTN_COBRAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(12, 542);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            this.BTN_REGRESAR.TabIndex = 95;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 21);
            this.label1.TabIndex = 94;
            this.label1.Text = "ESTE ES EL APARTADO PARA EL COBRO Y GENERACIÓN DE FACTURA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 45);
            this.label2.TabIndex = 98;
            this.label2.Text = "Servicios adicionales de la\r\nhabitacion en la que se\r\nhospedó:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 15);
            this.label3.TabIndex = 99;
            this.label3.Text = "*Costo por cada servicio utilizado:   350.00 $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 100;
            this.label4.Text = "Resumen de los servicios\r\nutilizados:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 30);
            this.label5.TabIndex = 101;
            this.label5.Text = "Numero de servicios \r\nutilizados:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 15);
            this.label6.TabIndex = 102;
            this.label6.Text = "Descuento aplicado (si es el caso):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 103;
            this.label7.Text = "+   Costo por Hotel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 104;
            this.label8.Text = "-   Anticipo dado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 105;
            this.label9.Text = "-   Descuento dado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 106;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 15);
            this.label11.TabIndex = 107;
            this.label11.Text = "+   Costo por Servicios Adicionales:";
            // 
            // TXT_SERVICIOSADICIONALES
            // 
            this.TXT_SERVICIOSADICIONALES.Location = new System.Drawing.Point(203, 76);
            this.TXT_SERVICIOSADICIONALES.Multiline = true;
            this.TXT_SERVICIOSADICIONALES.Name = "TXT_SERVICIOSADICIONALES";
            this.TXT_SERVICIOSADICIONALES.ReadOnly = true;
            this.TXT_SERVICIOSADICIONALES.Size = new System.Drawing.Size(422, 63);
            this.TXT_SERVICIOSADICIONALES.TabIndex = 108;
            // 
            // TXT_SERVICIOSUTILIZADOS
            // 
            this.TXT_SERVICIOSUTILIZADOS.Location = new System.Drawing.Point(202, 189);
            this.TXT_SERVICIOSUTILIZADOS.Multiline = true;
            this.TXT_SERVICIOSUTILIZADOS.Name = "TXT_SERVICIOSUTILIZADOS";
            this.TXT_SERVICIOSUTILIZADOS.Size = new System.Drawing.Size(422, 63);
            this.TXT_SERVICIOSUTILIZADOS.TabIndex = 109;
            // 
            // CB_NUMEROSERVICIOSUTILIZADOS
            // 
            this.CB_NUMEROSERVICIOSUTILIZADOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NUMEROSERVICIOSUTILIZADOS.FormattingEnabled = true;
            this.CB_NUMEROSERVICIOSUTILIZADOS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.CB_NUMEROSERVICIOSUTILIZADOS.Location = new System.Drawing.Point(180, 287);
            this.CB_NUMEROSERVICIOSUTILIZADOS.Name = "CB_NUMEROSERVICIOSUTILIZADOS";
            this.CB_NUMEROSERVICIOSUTILIZADOS.Size = new System.Drawing.Size(102, 23);
            this.CB_NUMEROSERVICIOSUTILIZADOS.TabIndex = 110;
            // 
            // TXT_DESCUENTO
            // 
            this.TXT_DESCUENTO.Location = new System.Drawing.Point(487, 287);
            this.TXT_DESCUENTO.Name = "TXT_DESCUENTO";
            this.TXT_DESCUENTO.Size = new System.Drawing.Size(100, 23);
            this.TXT_DESCUENTO.TabIndex = 111;
            // 
            // BTN_EXTENDERESTANCIA
            // 
            this.BTN_EXTENDERESTANCIA.Enabled = false;
            this.BTN_EXTENDERESTANCIA.Location = new System.Drawing.Point(336, 542);
            this.BTN_EXTENDERESTANCIA.Name = "BTN_EXTENDERESTANCIA";
            this.BTN_EXTENDERESTANCIA.Size = new System.Drawing.Size(131, 35);
            this.BTN_EXTENDERESTANCIA.TabIndex = 112;
            this.BTN_EXTENDERESTANCIA.Text = "EXTENDER ESTANCIA";
            this.BTN_EXTENDERESTANCIA.UseVisualStyleBackColor = true;
            this.BTN_EXTENDERESTANCIA.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_COSTOHOTEL
            // 
            this.TXT_COSTOHOTEL.Location = new System.Drawing.Point(253, 360);
            this.TXT_COSTOHOTEL.Name = "TXT_COSTOHOTEL";
            this.TXT_COSTOHOTEL.ReadOnly = true;
            this.TXT_COSTOHOTEL.Size = new System.Drawing.Size(134, 23);
            this.TXT_COSTOHOTEL.TabIndex = 113;
            // 
            // TXT_COSTOSERVICIOSADICIONALES
            // 
            this.TXT_COSTOSERVICIOSADICIONALES.Location = new System.Drawing.Point(336, 389);
            this.TXT_COSTOSERVICIOSADICIONALES.Name = "TXT_COSTOSERVICIOSADICIONALES";
            this.TXT_COSTOSERVICIOSADICIONALES.ReadOnly = true;
            this.TXT_COSTOSERVICIOSADICIONALES.Size = new System.Drawing.Size(134, 23);
            this.TXT_COSTOSERVICIOSADICIONALES.TabIndex = 114;
            // 
            // TXT_ANTICIPO
            // 
            this.TXT_ANTICIPO.Location = new System.Drawing.Point(241, 417);
            this.TXT_ANTICIPO.Name = "TXT_ANTICIPO";
            this.TXT_ANTICIPO.ReadOnly = true;
            this.TXT_ANTICIPO.Size = new System.Drawing.Size(134, 23);
            this.TXT_ANTICIPO.TabIndex = 115;
            // 
            // TXT_DESCUENTODADO
            // 
            this.TXT_DESCUENTODADO.Location = new System.Drawing.Point(252, 445);
            this.TXT_DESCUENTODADO.Name = "TXT_DESCUENTODADO";
            this.TXT_DESCUENTODADO.ReadOnly = true;
            this.TXT_DESCUENTODADO.Size = new System.Drawing.Size(134, 23);
            this.TXT_DESCUENTODADO.TabIndex = 116;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(393, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 117;
            this.label12.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(476, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 15);
            this.label13.TabIndex = 118;
            this.label13.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 15);
            this.label14.TabIndex = 119;
            this.label14.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(392, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 120;
            this.label15.Text = "$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(154, 464);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(237, 15);
            this.label16.TabIndex = 121;
            this.label16.Text = "______________________________________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 493);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 15);
            this.label17.TabIndex = 122;
            this.label17.Text = "Total a pagar:";
            // 
            // TXT_TOTALPAGAR
            // 
            this.TXT_TOTALPAGAR.Location = new System.Drawing.Point(241, 490);
            this.TXT_TOTALPAGAR.Name = "TXT_TOTALPAGAR";
            this.TXT_TOTALPAGAR.ReadOnly = true;
            this.TXT_TOTALPAGAR.Size = new System.Drawing.Size(134, 23);
            this.TXT_TOTALPAGAR.TabIndex = 123;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(381, 493);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 15);
            this.label18.TabIndex = 124;
            this.label18.Text = "$";
            // 
            // FORM_REGISTRO_PAGORESERVACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 589);
            this.ControlBox = false;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TXT_TOTALPAGAR);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TXT_DESCUENTODADO);
            this.Controls.Add(this.TXT_ANTICIPO);
            this.Controls.Add(this.TXT_COSTOSERVICIOSADICIONALES);
            this.Controls.Add(this.TXT_COSTOHOTEL);
            this.Controls.Add(this.BTN_EXTENDERESTANCIA);
            this.Controls.Add(this.TXT_DESCUENTO);
            this.Controls.Add(this.CB_NUMEROSERVICIOSUTILIZADOS);
            this.Controls.Add(this.TXT_SERVICIOSUTILIZADOS);
            this.Controls.Add(this.TXT_SERVICIOSADICIONALES);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_COBRAR);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REGISTRO_PAGORESERVACION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al apartado de Cobro y Generacion de Factura!";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox TXT_DESCUENTO;
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
    }
}