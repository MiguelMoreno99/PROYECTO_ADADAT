
namespace PROYECTO_ADADAT
{
    partial class FORM_REGISTRO_CLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REGISTRO_CLIENTES));
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_EDITAR = new System.Windows.Forms.Button();
            BTN_GUARDAR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
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
            TXT_NOMBRE = new System.Windows.Forms.TextBox();
            TXT_RFC = new System.Windows.Forms.TextBox();
            TXT_DOMICILIO = new System.Windows.Forms.TextBox();
            TXT_CORREO = new System.Windows.Forms.TextBox();
            TXT_TELEFONOCASA = new System.Windows.Forms.TextBox();
            TXT_TELEFONOCELULAR = new System.Windows.Forms.TextBox();
            TXT_REFERENCIA = new System.Windows.Forms.TextBox();
            CB_ESTADOCIVIL = new System.Windows.Forms.ComboBox();
            DTP_FECHANACIMIENTO = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(666, 514);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 83;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_EDITAR
            // 
            BTN_EDITAR.Location = new System.Drawing.Point(396, 514);
            BTN_EDITAR.Name = "BTN_EDITAR";
            BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            BTN_EDITAR.TabIndex = 81;
            BTN_EDITAR.Text = "EDITAR CLIENTE";
            BTN_EDITAR.UseVisualStyleBackColor = true;
            // 
            // BTN_GUARDAR
            // 
            BTN_GUARDAR.Location = new System.Drawing.Point(217, 514);
            BTN_GUARDAR.Name = "BTN_GUARDAR";
            BTN_GUARDAR.Size = new System.Drawing.Size(173, 35);
            BTN_GUARDAR.TabIndex = 80;
            BTN_GUARDAR.Text = "GUARDAR CLIENTE";
            BTN_GUARDAR.UseVisualStyleBackColor = true;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(12, 514);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 79;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(7, 372);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(817, 15);
            label22.TabIndex = 78;
            label22.Text = "__________________________________________________________________________________________________________________________________________________________________";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(155, 402);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(520, 21);
            label17.TabIndex = 77;
            label17.Text = "AQUÍ SE MUESTRAN LOS CLIENTES CAPTURADOS HASTA EL MOMENTO!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(217, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(402, 21);
            label2.TabIndex = 76;
            label2.Text = "ESTE ES EL APARTADO PARA EL REGISTRO DE CLIENTES!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 15);
            label1.TabIndex = 84;
            label1.Text = "Nombre completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(549, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 85;
            label3.Text = "RFC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(40, 115);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(115, 15);
            label4.TabIndex = 86;
            label4.Text = "Domicilio completo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(47, 178);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 15);
            label5.TabIndex = 87;
            label5.Text = "Correo electronico:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(365, 178);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(97, 15);
            label6.TabIndex = 88;
            label6.Text = "Telefono de casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(369, 216);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(93, 15);
            label7.TabIndex = 89;
            label7.Text = "Telefono celular:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(50, 256);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(112, 30);
            label8.TabIndex = 90;
            label8.Text = "Referencia de como\r\nconoció el hotel:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(412, 324);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(120, 15);
            label9.TabIndex = 91;
            label9.Text = "Fecha de nacimiento:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(50, 324);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(69, 15);
            label10.TabIndex = 92;
            label10.Text = "Estado civil:";
            // 
            // TXT_NOMBRE
            // 
            TXT_NOMBRE.Location = new System.Drawing.Point(161, 66);
            TXT_NOMBRE.Name = "TXT_NOMBRE";
            TXT_NOMBRE.Size = new System.Drawing.Size(371, 23);
            TXT_NOMBRE.TabIndex = 94;
            // 
            // TXT_RFC
            // 
            TXT_RFC.Location = new System.Drawing.Point(586, 66);
            TXT_RFC.Name = "TXT_RFC";
            TXT_RFC.Size = new System.Drawing.Size(181, 23);
            TXT_RFC.TabIndex = 95;
            // 
            // TXT_DOMICILIO
            // 
            TXT_DOMICILIO.Location = new System.Drawing.Point(161, 112);
            TXT_DOMICILIO.Multiline = true;
            TXT_DOMICILIO.Name = "TXT_DOMICILIO";
            TXT_DOMICILIO.Size = new System.Drawing.Size(606, 40);
            TXT_DOMICILIO.TabIndex = 96;
            // 
            // TXT_CORREO
            // 
            TXT_CORREO.Location = new System.Drawing.Point(161, 175);
            TXT_CORREO.Name = "TXT_CORREO";
            TXT_CORREO.Size = new System.Drawing.Size(192, 23);
            TXT_CORREO.TabIndex = 97;
            // 
            // TXT_TELEFONOCASA
            // 
            TXT_TELEFONOCASA.Location = new System.Drawing.Point(468, 175);
            TXT_TELEFONOCASA.Name = "TXT_TELEFONOCASA";
            TXT_TELEFONOCASA.Size = new System.Drawing.Size(195, 23);
            TXT_TELEFONOCASA.TabIndex = 98;
            // 
            // TXT_TELEFONOCELULAR
            // 
            TXT_TELEFONOCELULAR.Location = new System.Drawing.Point(468, 213);
            TXT_TELEFONOCELULAR.Name = "TXT_TELEFONOCELULAR";
            TXT_TELEFONOCELULAR.Size = new System.Drawing.Size(195, 23);
            TXT_TELEFONOCELULAR.TabIndex = 99;
            // 
            // TXT_REFERENCIA
            // 
            TXT_REFERENCIA.Location = new System.Drawing.Point(168, 261);
            TXT_REFERENCIA.Name = "TXT_REFERENCIA";
            TXT_REFERENCIA.Size = new System.Drawing.Size(599, 23);
            TXT_REFERENCIA.TabIndex = 100;
            // 
            // CB_ESTADOCIVIL
            // 
            CB_ESTADOCIVIL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_ESTADOCIVIL.FormattingEnabled = true;
            CB_ESTADOCIVIL.Items.AddRange(new object[] { "SOLTERO(A)", "CASADO(A)", "DIVORICIADO(A)", "VIUDO(A)", "UNION LIBRE" });
            CB_ESTADOCIVIL.Location = new System.Drawing.Point(125, 321);
            CB_ESTADOCIVIL.Name = "CB_ESTADOCIVIL";
            CB_ESTADOCIVIL.Size = new System.Drawing.Size(196, 23);
            CB_ESTADOCIVIL.TabIndex = 101;
            // 
            // DTP_FECHANACIMIENTO
            // 
            DTP_FECHANACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTP_FECHANACIMIENTO.Location = new System.Drawing.Point(538, 318);
            DTP_FECHANACIMIENTO.Name = "DTP_FECHANACIMIENTO";
            DTP_FECHANACIMIENTO.Size = new System.Drawing.Size(137, 23);
            DTP_FECHANACIMIENTO.TabIndex = 102;
            // 
            // FORM_REGISTRO_CLIENTES
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(826, 561);
            ControlBox = false;
            Controls.Add(DTP_FECHANACIMIENTO);
            Controls.Add(CB_ESTADOCIVIL);
            Controls.Add(TXT_REFERENCIA);
            Controls.Add(TXT_TELEFONOCELULAR);
            Controls.Add(TXT_TELEFONOCASA);
            Controls.Add(TXT_CORREO);
            Controls.Add(TXT_DOMICILIO);
            Controls.Add(TXT_RFC);
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
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_EDITAR);
            Controls.Add(BTN_GUARDAR);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(label22);
            Controls.Add(label17);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REGISTRO_CLIENTES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Registro de Clientes!";
            Load += FORM_REGISTRO_CLIENTES_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_REGRESAR;
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
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.TextBox TXT_RFC;
        private System.Windows.Forms.TextBox TXT_DOMICILIO;
        private System.Windows.Forms.TextBox TXT_CORREO;
        private System.Windows.Forms.TextBox TXT_TELEFONOCASA;
        private System.Windows.Forms.TextBox TXT_TELEFONOCELULAR;
        private System.Windows.Forms.TextBox TXT_REFERENCIA;
        private System.Windows.Forms.ComboBox CB_ESTADOCIVIL;
        private System.Windows.Forms.DateTimePicker DTP_FECHANACIMIENTO;
    }
}