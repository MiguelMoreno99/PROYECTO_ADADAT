namespace PROYECTO_ADADAT
{
    partial class FORM_GESTION_HOTELES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_GESTION_HOTELES));
            BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            BTN_ELIMINAR = new System.Windows.Forms.Button();
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            BTN_EDITAR = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            TXT_NUMEROPISOS = new System.Windows.Forms.TextBox();
            TXT_DOMICILIO = new System.Windows.Forms.TextBox();
            TXT_PAIS = new System.Windows.Forms.TextBox();
            TXT_ESTADO = new System.Windows.Forms.TextBox();
            TXT_CIUDAD = new System.Windows.Forms.TextBox();
            TXT_SERVICIOSADICIONALES = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            TXT_CARACERISTICASHOTEL = new System.Windows.Forms.TextBox();
            TXT_ZONATURISTICA = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            LB_NOMBRE_HOTEL = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // BTN_ACTUALIZAR
            // 
            BTN_ACTUALIZAR.Location = new System.Drawing.Point(700, 61);
            BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            BTN_ACTUALIZAR.Size = new System.Drawing.Size(147, 76);
            BTN_ACTUALIZAR.TabIndex = 141;
            BTN_ACTUALIZAR.Text = "ACTUALIZAR LISTA";
            BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            BTN_ACTUALIZAR.Click += BTN_ACTUALIZAR_Click;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new System.Drawing.Point(376, 348);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new System.Drawing.Size(173, 35);
            BTN_ELIMINAR.TabIndex = 140;
            BTN_ELIMINAR.Text = "ELIMINAR HOTEL";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            BTN_ELIMINAR.Click += BTN_ELIMINAR_Click;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(624, 348);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 139;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(28, 348);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 138;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // BTN_EDITAR
            // 
            BTN_EDITAR.Location = new System.Drawing.Point(197, 348);
            BTN_EDITAR.Name = "BTN_EDITAR";
            BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            BTN_EDITAR.TabIndex = 137;
            BTN_EDITAR.Text = "EDITAR HOTEL";
            BTN_EDITAR.UseVisualStyleBackColor = true;
            BTN_EDITAR.Click += BTN_EDITAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(389, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(424, 21);
            label2.TabIndex = 136;
            label2.Text = "ESTE ES EL APARTADO PARA LA GESTION DE LOS HOTELES!";
            // 
            // TXT_NUMEROPISOS
            // 
            TXT_NUMEROPISOS.Location = new System.Drawing.Point(123, 242);
            TXT_NUMEROPISOS.Name = "TXT_NUMEROPISOS";
            TXT_NUMEROPISOS.Size = new System.Drawing.Size(150, 23);
            TXT_NUMEROPISOS.TabIndex = 162;
            // 
            // TXT_DOMICILIO
            // 
            TXT_DOMICILIO.Location = new System.Drawing.Point(332, 197);
            TXT_DOMICILIO.Multiline = true;
            TXT_DOMICILIO.Name = "TXT_DOMICILIO";
            TXT_DOMICILIO.Size = new System.Drawing.Size(414, 68);
            TXT_DOMICILIO.TabIndex = 161;
            // 
            // TXT_PAIS
            // 
            TXT_PAIS.Location = new System.Drawing.Point(74, 197);
            TXT_PAIS.Name = "TXT_PAIS";
            TXT_PAIS.Size = new System.Drawing.Size(179, 23);
            TXT_PAIS.TabIndex = 160;
            // 
            // TXT_ESTADO
            // 
            TXT_ESTADO.Location = new System.Drawing.Point(322, 158);
            TXT_ESTADO.Name = "TXT_ESTADO";
            TXT_ESTADO.Size = new System.Drawing.Size(242, 23);
            TXT_ESTADO.TabIndex = 159;
            // 
            // TXT_CIUDAD
            // 
            TXT_CIUDAD.Location = new System.Drawing.Point(87, 158);
            TXT_CIUDAD.Name = "TXT_CIUDAD";
            TXT_CIUDAD.Size = new System.Drawing.Size(166, 23);
            TXT_CIUDAD.TabIndex = 158;
            // 
            // TXT_SERVICIOSADICIONALES
            // 
            TXT_SERVICIOSADICIONALES.Location = new System.Drawing.Point(852, 163);
            TXT_SERVICIOSADICIONALES.Multiline = true;
            TXT_SERVICIOSADICIONALES.Name = "TXT_SERVICIOSADICIONALES";
            TXT_SERVICIOSADICIONALES.Size = new System.Drawing.Size(364, 80);
            TXT_SERVICIOSADICIONALES.TabIndex = 156;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(761, 259);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(86, 30);
            label16.TabIndex = 155;
            label16.Text = "Caracteristicas \r\ndel hotel:";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_CARACERISTICASHOTEL
            // 
            TXT_CARACERISTICASHOTEL.Location = new System.Drawing.Point(853, 259);
            TXT_CARACERISTICASHOTEL.Multiline = true;
            TXT_CARACERISTICASHOTEL.Name = "TXT_CARACERISTICASHOTEL";
            TXT_CARACERISTICASHOTEL.Size = new System.Drawing.Size(363, 84);
            TXT_CARACERISTICASHOTEL.TabIndex = 154;
            // 
            // TXT_ZONATURISTICA
            // 
            TXT_ZONATURISTICA.Location = new System.Drawing.Point(366, 271);
            TXT_ZONATURISTICA.Multiline = true;
            TXT_ZONATURISTICA.Name = "TXT_ZONATURISTICA";
            TXT_ZONATURISTICA.Size = new System.Drawing.Size(380, 59);
            TXT_ZONATURISTICA.TabIndex = 153;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(728, 166);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(118, 15);
            label14.TabIndex = 150;
            label14.Text = "Servicios adicionales:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(276, 274);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(84, 15);
            label13.TabIndex = 149;
            label13.Text = "Zona Turistica:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(17, 245);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(100, 15);
            label8.TabIndex = 148;
            label8.Text = "Numero de pisos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(271, 200);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(55, 15);
            label7.TabIndex = 147;
            label7.Text = "Domicio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(38, 200);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(31, 15);
            label6.TabIndex = 146;
            label6.Text = "Pais:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(271, 161);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 15);
            label5.TabIndex = 145;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(38, 161);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 15);
            label4.TabIndex = 144;
            label4.Text = "Ciudad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(33, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 15);
            label3.TabIndex = 143;
            label3.Text = "Ubicación...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 30);
            label1.TabIndex = 142;
            label1.Text = "Seleccione un Nombre \r\nde Hotel:";
            // 
            // LB_NOMBRE_HOTEL
            // 
            LB_NOMBRE_HOTEL.DisplayMember = "nombre";
            LB_NOMBRE_HOTEL.FormattingEnabled = true;
            LB_NOMBRE_HOTEL.ItemHeight = 15;
            LB_NOMBRE_HOTEL.Location = new System.Drawing.Point(164, 58);
            LB_NOMBRE_HOTEL.Name = "LB_NOMBRE_HOTEL";
            LB_NOMBRE_HOTEL.Size = new System.Drawing.Size(506, 79);
            LB_NOMBRE_HOTEL.TabIndex = 163;
            LB_NOMBRE_HOTEL.ValueMember = "nombre";
            LB_NOMBRE_HOTEL.SelectedIndexChanged += LB_NOMBRE_HOTEL_SelectedIndexChanged;
            // 
            // FORM_GESTION_HOTELES
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1228, 394);
            ControlBox = false;
            Controls.Add(LB_NOMBRE_HOTEL);
            Controls.Add(TXT_NUMEROPISOS);
            Controls.Add(TXT_DOMICILIO);
            Controls.Add(TXT_PAIS);
            Controls.Add(TXT_ESTADO);
            Controls.Add(TXT_CIUDAD);
            Controls.Add(TXT_SERVICIOSADICIONALES);
            Controls.Add(label16);
            Controls.Add(TXT_CARACERISTICASHOTEL);
            Controls.Add(TXT_ZONATURISTICA);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(BTN_ACTUALIZAR);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(BTN_EDITAR);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_GESTION_HOTELES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Apartado de Gestion de Hoteles!";
            Load += FORM_GESTION_HOTELES_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_ACTUALIZAR;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_NUMEROPISOS;
        private System.Windows.Forms.TextBox TXT_DOMICILIO;
        private System.Windows.Forms.TextBox TXT_PAIS;
        private System.Windows.Forms.TextBox TXT_ESTADO;
        private System.Windows.Forms.TextBox TXT_CIUDAD;
        private System.Windows.Forms.TextBox TXT_SERVICIOSADICIONALES;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXT_CARACERISTICASHOTEL;
        private System.Windows.Forms.TextBox TXT_ZONATURISTICA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_NOMBRE_HOTEL;
    }
}