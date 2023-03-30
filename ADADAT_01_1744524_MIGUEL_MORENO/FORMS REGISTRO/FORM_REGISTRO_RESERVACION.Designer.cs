
namespace PROYECTO_ADADAT
{
    partial class FORM_REGISTRO_RESERVACION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REGISTRO_RESERVACION));
            label22 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            TXT_RFC = new System.Windows.Forms.TextBox();
            TXT_NOMBRE = new System.Windows.Forms.TextBox();
            TXT_CARACTERISTICAHOTEL = new System.Windows.Forms.TextBox();
            TXT_CARACTERISTICASHABITACION = new System.Windows.Forms.TextBox();
            TXT_PRECIONOCHE = new System.Windows.Forms.TextBox();
            TXT_ANTICIPO = new System.Windows.Forms.TextBox();
            CB_NUMEROPERSONAS = new System.Windows.Forms.ComboBox();
            CB_HOTELESDISPONIBLES = new System.Windows.Forms.ComboBox();
            CB_HABITACIONESDISPONIBLES = new System.Windows.Forms.ComboBox();
            DTP_FECHAINICIAL = new System.Windows.Forms.DateTimePicker();
            DTP_FECHAFINAL = new System.Windows.Forms.DateTimePicker();
            CB_CIUDAD = new System.Windows.Forms.ComboBox();
            BTN_BUSCARRFC = new System.Windows.Forms.Button();
            BTN_BUSCARHOTEL = new System.Windows.Forms.Button();
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_COBRAR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(5, 427);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(1147, 15);
            label22.TabIndex = 73;
            label22.Text = resources.GetString("label22.Text");
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(306, 451);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(539, 21);
            label17.TabIndex = 72;
            label17.Text = "AQUÍ SE MUESTRAN LAS RESERVACIONES CREADAS HASTA EL MOMENTO!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(332, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(460, 21);
            label2.TabIndex = 71;
            label2.Text = "ESTE ES EL APARTADO PARA LA CREACIÓN DE RESERVACIONES!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(125, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 15);
            label1.TabIndex = 74;
            label1.Text = "RFC del Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(498, 108);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 15);
            label3.TabIndex = 75;
            label3.Text = "Ciudad a visitar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(611, 57);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 15);
            label4.TabIndex = 76;
            label4.Text = "Nombre del cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(611, 157);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(113, 15);
            label5.TabIndex = 77;
            label5.Text = "Hoteles disponibles:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(65, 108);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 15);
            label6.TabIndex = 78;
            label6.Text = "Fecha Inicial:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(255, 108);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(67, 15);
            label7.TabIndex = 79;
            label7.Text = "Fecha final:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(574, 236);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(184, 30);
            label8.TabIndex = 80;
            label8.Text = "Tipos de habitaciones disponibles\r\npara el hotel seleccionado:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(12, 269);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(173, 30);
            label9.TabIndex = 81;
            label9.Text = "Caracteristicas de la habitacion \r\nseleccionada:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(658, 367);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(100, 15);
            label10.TabIndex = 82;
            label10.Text = "Precio por noche:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(703, 396);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(55, 15);
            label11.TabIndex = 83;
            label11.Text = "Anticipo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(53, 157);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(132, 30);
            label12.TabIndex = 84;
            label12.Text = "Caracteristicas del hotel\r\nseleccionado:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(641, 304);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(117, 30);
            label13.TabIndex = 85;
            label13.Text = "Numero de Personas\r\na hospedar:";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(899, 396);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(13, 15);
            label14.TabIndex = 86;
            label14.Text = "$";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(899, 367);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(13, 15);
            label15.TabIndex = 87;
            label15.Text = "$";
            // 
            // TXT_RFC
            // 
            TXT_RFC.Location = new System.Drawing.Point(221, 54);
            TXT_RFC.Name = "TXT_RFC";
            TXT_RFC.Size = new System.Drawing.Size(192, 23);
            TXT_RFC.TabIndex = 88;
            // 
            // TXT_NOMBRE
            // 
            TXT_NOMBRE.Location = new System.Drawing.Point(725, 54);
            TXT_NOMBRE.Name = "TXT_NOMBRE";
            TXT_NOMBRE.ReadOnly = true;
            TXT_NOMBRE.Size = new System.Drawing.Size(384, 23);
            TXT_NOMBRE.TabIndex = 89;
            // 
            // TXT_CARACTERISTICAHOTEL
            // 
            TXT_CARACTERISTICAHOTEL.Location = new System.Drawing.Point(191, 157);
            TXT_CARACTERISTICAHOTEL.Multiline = true;
            TXT_CARACTERISTICAHOTEL.Name = "TXT_CARACTERISTICAHOTEL";
            TXT_CARACTERISTICAHOTEL.ReadOnly = true;
            TXT_CARACTERISTICAHOTEL.Size = new System.Drawing.Size(360, 80);
            TXT_CARACTERISTICAHOTEL.TabIndex = 90;
            // 
            // TXT_CARACTERISTICASHABITACION
            // 
            TXT_CARACTERISTICASHABITACION.Location = new System.Drawing.Point(191, 269);
            TXT_CARACTERISTICASHABITACION.Multiline = true;
            TXT_CARACTERISTICASHABITACION.Name = "TXT_CARACTERISTICASHABITACION";
            TXT_CARACTERISTICASHABITACION.ReadOnly = true;
            TXT_CARACTERISTICASHABITACION.Size = new System.Drawing.Size(360, 80);
            TXT_CARACTERISTICASHABITACION.TabIndex = 91;
            // 
            // TXT_PRECIONOCHE
            // 
            TXT_PRECIONOCHE.Location = new System.Drawing.Point(764, 364);
            TXT_PRECIONOCHE.Name = "TXT_PRECIONOCHE";
            TXT_PRECIONOCHE.ReadOnly = true;
            TXT_PRECIONOCHE.Size = new System.Drawing.Size(129, 23);
            TXT_PRECIONOCHE.TabIndex = 92;
            // 
            // TXT_ANTICIPO
            // 
            TXT_ANTICIPO.Location = new System.Drawing.Point(764, 393);
            TXT_ANTICIPO.Name = "TXT_ANTICIPO";
            TXT_ANTICIPO.ReadOnly = true;
            TXT_ANTICIPO.Size = new System.Drawing.Size(129, 23);
            TXT_ANTICIPO.TabIndex = 93;
            TXT_ANTICIPO.Text = "200.00";
            TXT_ANTICIPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CB_NUMEROPERSONAS
            // 
            CB_NUMEROPERSONAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_NUMEROPERSONAS.FormattingEnabled = true;
            CB_NUMEROPERSONAS.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            CB_NUMEROPERSONAS.Location = new System.Drawing.Point(764, 309);
            CB_NUMEROPERSONAS.Name = "CB_NUMEROPERSONAS";
            CB_NUMEROPERSONAS.Size = new System.Drawing.Size(121, 23);
            CB_NUMEROPERSONAS.TabIndex = 94;
            // 
            // CB_HOTELESDISPONIBLES
            // 
            CB_HOTELESDISPONIBLES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_HOTELESDISPONIBLES.FormattingEnabled = true;
            CB_HOTELESDISPONIBLES.Items.AddRange(new object[] { "GRAND HOTEL", "HOTEL MAGNUS", "HOTEL LA GAVIOTA" });
            CB_HOTELESDISPONIBLES.Location = new System.Drawing.Point(730, 154);
            CB_HOTELESDISPONIBLES.Name = "CB_HOTELESDISPONIBLES";
            CB_HOTELESDISPONIBLES.Size = new System.Drawing.Size(268, 23);
            CB_HOTELESDISPONIBLES.TabIndex = 95;
            // 
            // CB_HABITACIONESDISPONIBLES
            // 
            CB_HABITACIONESDISPONIBLES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_HABITACIONESDISPONIBLES.FormattingEnabled = true;
            CB_HABITACIONESDISPONIBLES.Items.AddRange(new object[] { "STANDART", "PREMIUM" });
            CB_HABITACIONESDISPONIBLES.Location = new System.Drawing.Point(764, 236);
            CB_HABITACIONESDISPONIBLES.Name = "CB_HABITACIONESDISPONIBLES";
            CB_HABITACIONESDISPONIBLES.Size = new System.Drawing.Size(313, 23);
            CB_HABITACIONESDISPONIBLES.TabIndex = 96;
            // 
            // DTP_FECHAINICIAL
            // 
            DTP_FECHAINICIAL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTP_FECHAINICIAL.Location = new System.Drawing.Point(146, 102);
            DTP_FECHAINICIAL.Name = "DTP_FECHAINICIAL";
            DTP_FECHAINICIAL.Size = new System.Drawing.Size(103, 23);
            DTP_FECHAINICIAL.TabIndex = 97;
            // 
            // DTP_FECHAFINAL
            // 
            DTP_FECHAFINAL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTP_FECHAFINAL.Location = new System.Drawing.Point(328, 102);
            DTP_FECHAFINAL.Name = "DTP_FECHAFINAL";
            DTP_FECHAFINAL.Size = new System.Drawing.Size(103, 23);
            DTP_FECHAFINAL.TabIndex = 98;
            // 
            // CB_CIUDAD
            // 
            CB_CIUDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_CIUDAD.FormattingEnabled = true;
            CB_CIUDAD.Items.AddRange(new object[] { "MONTERREY", "CANCUN", "MAZATLAN", "CIUDAD DE MEXICO" });
            CB_CIUDAD.Location = new System.Drawing.Point(595, 105);
            CB_CIUDAD.Name = "CB_CIUDAD";
            CB_CIUDAD.Size = new System.Drawing.Size(235, 23);
            CB_CIUDAD.TabIndex = 99;
            // 
            // BTN_BUSCARRFC
            // 
            BTN_BUSCARRFC.Location = new System.Drawing.Point(419, 47);
            BTN_BUSCARRFC.Name = "BTN_BUSCARRFC";
            BTN_BUSCARRFC.Size = new System.Drawing.Size(85, 35);
            BTN_BUSCARRFC.TabIndex = 100;
            BTN_BUSCARRFC.Text = "BUSCAR RFC";
            BTN_BUSCARRFC.UseVisualStyleBackColor = true;
            // 
            // BTN_BUSCARHOTEL
            // 
            BTN_BUSCARHOTEL.Location = new System.Drawing.Point(836, 98);
            BTN_BUSCARHOTEL.Name = "BTN_BUSCARHOTEL";
            BTN_BUSCARHOTEL.Size = new System.Drawing.Size(109, 35);
            BTN_BUSCARHOTEL.TabIndex = 101;
            BTN_BUSCARHOTEL.Text = "BUSCAR HOTELES";
            BTN_BUSCARHOTEL.UseVisualStyleBackColor = true;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(993, 514);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 106;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_COBRAR
            // 
            BTN_COBRAR.Location = new System.Drawing.Point(125, 514);
            BTN_COBRAR.Name = "BTN_COBRAR";
            BTN_COBRAR.Size = new System.Drawing.Size(270, 35);
            BTN_COBRAR.TabIndex = 103;
            BTN_COBRAR.Text = "COBRAR Y GENERAR CODIGO DE RESERVACION";
            BTN_COBRAR.UseVisualStyleBackColor = true;
            BTN_COBRAR.Click += BTN_GUARDAR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(12, 514);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 102;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // FORM_REGISTRO_RESERVACION
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1153, 561);
            ControlBox = false;
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_COBRAR);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(BTN_BUSCARHOTEL);
            Controls.Add(BTN_BUSCARRFC);
            Controls.Add(CB_CIUDAD);
            Controls.Add(DTP_FECHAFINAL);
            Controls.Add(DTP_FECHAINICIAL);
            Controls.Add(CB_HABITACIONESDISPONIBLES);
            Controls.Add(CB_HOTELESDISPONIBLES);
            Controls.Add(CB_NUMEROPERSONAS);
            Controls.Add(TXT_ANTICIPO);
            Controls.Add(TXT_PRECIONOCHE);
            Controls.Add(TXT_CARACTERISTICASHABITACION);
            Controls.Add(TXT_CARACTERISTICAHOTEL);
            Controls.Add(TXT_NOMBRE);
            Controls.Add(TXT_RFC);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label22);
            Controls.Add(label17);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REGISTRO_RESERVACION";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido a Creación de Reservaciones!";
            Load += FORM_REGISTRO_RESERVACION_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXT_RFC;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.TextBox TXT_CARACTERISTICAHOTEL;
        private System.Windows.Forms.TextBox TXT_CARACTERISTICASHABITACION;
        private System.Windows.Forms.TextBox TXT_PRECIONOCHE;
        private System.Windows.Forms.TextBox TXT_ANTICIPO;
        private System.Windows.Forms.ComboBox CB_NUMEROPERSONAS;
        private System.Windows.Forms.ComboBox CB_HOTELESDISPONIBLES;
        private System.Windows.Forms.ComboBox CB_HABITACIONESDISPONIBLES;
        private System.Windows.Forms.DateTimePicker DTP_FECHAINICIAL;
        private System.Windows.Forms.DateTimePicker DTP_FECHAFINAL;
        private System.Windows.Forms.ComboBox CB_CIUDAD;
        private System.Windows.Forms.Button BTN_BUSCARRFC;
        private System.Windows.Forms.Button BTN_BUSCARHOTEL;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_COBRAR;
        private System.Windows.Forms.Button BTN_REGRESAR;
    }
}