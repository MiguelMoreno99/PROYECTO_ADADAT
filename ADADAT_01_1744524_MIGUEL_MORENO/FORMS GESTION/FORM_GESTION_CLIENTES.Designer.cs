namespace PROYECTO_ADADAT
{
    partial class FORM_GESTION_CLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_GESTION_CLIENTES));
            label12 = new System.Windows.Forms.Label();
            TXT_MATERNO = new System.Windows.Forms.TextBox();
            TXT_PATERNO = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            DTP_FECHANACIMIENTO = new System.Windows.Forms.DateTimePicker();
            CB_ESTADOCIVIL = new System.Windows.Forms.ComboBox();
            TXT_REFERENCIA = new System.Windows.Forms.TextBox();
            TXT_TELEFONOCELULAR = new System.Windows.Forms.TextBox();
            TXT_TELEFONOCASA = new System.Windows.Forms.TextBox();
            TXT_CORREO = new System.Windows.Forms.TextBox();
            TXT_DOMICILIO = new System.Windows.Forms.TextBox();
            TXT_NOMBRE = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            BTN_EDITAR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_ELIMINAR = new System.Windows.Forms.Button();
            BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            LB_RFC = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(35, 61);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(107, 15);
            label12.TabIndex = 130;
            label12.Text = "Seleccione un RFC:";
            // 
            // TXT_MATERNO
            // 
            TXT_MATERNO.Location = new System.Drawing.Point(523, 147);
            TXT_MATERNO.Name = "TXT_MATERNO";
            TXT_MATERNO.Size = new System.Drawing.Size(181, 23);
            TXT_MATERNO.TabIndex = 128;
            // 
            // TXT_PATERNO
            // 
            TXT_PATERNO.Location = new System.Drawing.Point(278, 147);
            TXT_PATERNO.Name = "TXT_PATERNO";
            TXT_PATERNO.Size = new System.Drawing.Size(181, 23);
            TXT_PATERNO.TabIndex = 127;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(587, 173);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(52, 15);
            label11.TabIndex = 126;
            label11.Text = "Materno";
            // 
            // DTP_FECHANACIMIENTO
            // 
            DTP_FECHANACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTP_FECHANACIMIENTO.Location = new System.Drawing.Point(523, 331);
            DTP_FECHANACIMIENTO.Name = "DTP_FECHANACIMIENTO";
            DTP_FECHANACIMIENTO.Size = new System.Drawing.Size(137, 23);
            DTP_FECHANACIMIENTO.TabIndex = 125;
            // 
            // CB_ESTADOCIVIL
            // 
            CB_ESTADOCIVIL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_ESTADOCIVIL.FormattingEnabled = true;
            CB_ESTADOCIVIL.Items.AddRange(new object[] { "SOLTERO(A)", "CASADO(A)", "DIVORICIADO(A)", "VIUDO(A)", "UNION LIBRE" });
            CB_ESTADOCIVIL.Location = new System.Drawing.Point(135, 331);
            CB_ESTADOCIVIL.Name = "CB_ESTADOCIVIL";
            CB_ESTADOCIVIL.Size = new System.Drawing.Size(196, 23);
            CB_ESTADOCIVIL.TabIndex = 124;
            // 
            // TXT_REFERENCIA
            // 
            TXT_REFERENCIA.Location = new System.Drawing.Point(135, 302);
            TXT_REFERENCIA.Name = "TXT_REFERENCIA";
            TXT_REFERENCIA.Size = new System.Drawing.Size(606, 23);
            TXT_REFERENCIA.TabIndex = 123;
            // 
            // TXT_TELEFONOCELULAR
            // 
            TXT_TELEFONOCELULAR.Location = new System.Drawing.Point(546, 273);
            TXT_TELEFONOCELULAR.Name = "TXT_TELEFONOCELULAR";
            TXT_TELEFONOCELULAR.Size = new System.Drawing.Size(195, 23);
            TXT_TELEFONOCELULAR.TabIndex = 122;
            // 
            // TXT_TELEFONOCASA
            // 
            TXT_TELEFONOCASA.Location = new System.Drawing.Point(546, 244);
            TXT_TELEFONOCASA.Name = "TXT_TELEFONOCASA";
            TXT_TELEFONOCASA.Size = new System.Drawing.Size(195, 23);
            TXT_TELEFONOCASA.TabIndex = 121;
            // 
            // TXT_CORREO
            // 
            TXT_CORREO.Location = new System.Drawing.Point(135, 244);
            TXT_CORREO.Name = "TXT_CORREO";
            TXT_CORREO.Size = new System.Drawing.Size(302, 23);
            TXT_CORREO.TabIndex = 120;
            // 
            // TXT_DOMICILIO
            // 
            TXT_DOMICILIO.Location = new System.Drawing.Point(135, 198);
            TXT_DOMICILIO.Multiline = true;
            TXT_DOMICILIO.Name = "TXT_DOMICILIO";
            TXT_DOMICILIO.Size = new System.Drawing.Size(606, 40);
            TXT_DOMICILIO.TabIndex = 119;
            // 
            // TXT_NOMBRE
            // 
            TXT_NOMBRE.Location = new System.Drawing.Point(60, 147);
            TXT_NOMBRE.Name = "TXT_NOMBRE";
            TXT_NOMBRE.Size = new System.Drawing.Size(181, 23);
            TXT_NOMBRE.TabIndex = 118;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(60, 334);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(69, 15);
            label10.TabIndex = 117;
            label10.Text = "Estado civil:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(397, 337);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(120, 15);
            label9.TabIndex = 116;
            label9.Text = "Fecha de nacimiento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(17, 297);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(112, 30);
            label8.TabIndex = 115;
            label8.Text = "Referencia de como\r\nconoció el hotel:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(447, 276);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(93, 15);
            label7.TabIndex = 114;
            label7.Text = "Telefono celular:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(443, 247);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(97, 15);
            label6.TabIndex = 113;
            label6.Text = "Telefono de casa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 247);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 15);
            label5.TabIndex = 112;
            label5.Text = "Correo electronico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 201);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(115, 15);
            label4.TabIndex = 111;
            label4.Text = "Domicilio completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(337, 173);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 15);
            label3.TabIndex = 110;
            label3.Text = "Paterno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(114, 173);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 15);
            label1.TabIndex = 109;
            label1.Text = "Nombre(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(181, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(428, 21);
            label2.TabIndex = 108;
            label2.Text = "ESTE ES EL APARTADO PARA LA GESTION DE LOS CLIENTES!";
            // 
            // BTN_EDITAR
            // 
            BTN_EDITAR.Location = new System.Drawing.Point(181, 381);
            BTN_EDITAR.Name = "BTN_EDITAR";
            BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            BTN_EDITAR.TabIndex = 131;
            BTN_EDITAR.Text = "EDITAR CLIENTE";
            BTN_EDITAR.UseVisualStyleBackColor = true;
            BTN_EDITAR.Click += BTN_EDITAR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(12, 381);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 132;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(608, 381);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 133;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new System.Drawing.Point(360, 381);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new System.Drawing.Size(173, 35);
            BTN_ELIMINAR.TabIndex = 134;
            BTN_ELIMINAR.Text = "ELIMINAR CLIENTE";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            BTN_ELIMINAR.Click += BTN_ELIMINAR_Click;
            // 
            // BTN_ACTUALIZAR
            // 
            BTN_ACTUALIZAR.Location = new System.Drawing.Point(613, 51);
            BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            BTN_ACTUALIZAR.Size = new System.Drawing.Size(128, 74);
            BTN_ACTUALIZAR.TabIndex = 135;
            BTN_ACTUALIZAR.Text = "ACTUALIZAR LISTA";
            BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            BTN_ACTUALIZAR.Click += BTN_ACTUALIZAR_Click;
            // 
            // LB_RFC
            // 
            LB_RFC.DisplayMember = "rfc";
            LB_RFC.FormattingEnabled = true;
            LB_RFC.ItemHeight = 15;
            LB_RFC.Location = new System.Drawing.Point(148, 61);
            LB_RFC.Name = "LB_RFC";
            LB_RFC.Size = new System.Drawing.Size(403, 64);
            LB_RFC.TabIndex = 136;
            LB_RFC.ValueMember = "rfc";
            LB_RFC.SelectedIndexChanged += LB_RFC_SelectedIndexChanged;
            // 
            // FORM_GESTION_CLIENTES
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(772, 428);
            ControlBox = false;
            Controls.Add(LB_RFC);
            Controls.Add(BTN_ACTUALIZAR);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(BTN_EDITAR);
            Controls.Add(label12);
            Controls.Add(TXT_MATERNO);
            Controls.Add(TXT_PATERNO);
            Controls.Add(label11);
            Controls.Add(DTP_FECHANACIMIENTO);
            Controls.Add(CB_ESTADOCIVIL);
            Controls.Add(TXT_REFERENCIA);
            Controls.Add(TXT_TELEFONOCELULAR);
            Controls.Add(TXT_TELEFONOCASA);
            Controls.Add(TXT_CORREO);
            Controls.Add(TXT_DOMICILIO);
            Controls.Add(TXT_NOMBRE);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_GESTION_CLIENTES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Apartado de Gestion de Clientes!";
            Load += FORM_GESTION_CLIENTES_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXT_MATERNO;
        private System.Windows.Forms.TextBox TXT_PATERNO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DTP_FECHANACIMIENTO;
        private System.Windows.Forms.ComboBox CB_ESTADOCIVIL;
        private System.Windows.Forms.TextBox TXT_REFERENCIA;
        private System.Windows.Forms.TextBox TXT_TELEFONOCELULAR;
        private System.Windows.Forms.TextBox TXT_TELEFONOCASA;
        private System.Windows.Forms.TextBox TXT_CORREO;
        private System.Windows.Forms.TextBox TXT_DOMICILIO;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.Button BTN_ACTUALIZAR;
        private System.Windows.Forms.ListBox LB_RFC;
    }
}