
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
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_EDITAR = new System.Windows.Forms.Button();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.TXT_RFC = new System.Windows.Forms.TextBox();
            this.TXT_DOMICILIO = new System.Windows.Forms.TextBox();
            this.TXT_CORREO = new System.Windows.Forms.TextBox();
            this.TXT_TELEFONOCASA = new System.Windows.Forms.TextBox();
            this.TXT_TELEFONOCELULAR = new System.Windows.Forms.TextBox();
            this.TXT_REFERENCIA = new System.Windows.Forms.TextBox();
            this.CB_ESTADOCIVIL = new System.Windows.Forms.ComboBox();
            this.DTP_FECHANACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(666, 833);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            this.BTN_SALIR.TabIndex = 83;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.Location = new System.Drawing.Point(396, 833);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_EDITAR.TabIndex = 81;
            this.BTN_EDITAR.Text = "EDITAR CLIENTE";
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.Location = new System.Drawing.Point(217, 833);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_GUARDAR.TabIndex = 80;
            this.BTN_GUARDAR.Text = "GUARDAR CLIENTE";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(12, 833);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            this.BTN_REGRESAR.TabIndex = 79;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 372);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(817, 15);
            this.label22.TabIndex = 78;
            this.label22.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(155, 402);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(520, 21);
            this.label17.TabIndex = 77;
            this.label17.Text = "AQUÍ SE MUESTRAN LOS CLIENTES CAPTURADOS HASTA EL MOMENTO!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "ESTE ES EL APARTADO PARA EL REGISTRO DE CLIENTES!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 84;
            this.label1.Text = "Nombre completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 85;
            this.label3.Text = "RFC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 86;
            this.label4.Text = "Domicilio completo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 87;
            this.label5.Text = "Correo electronico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 88;
            this.label6.Text = "Telefono de casa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 89;
            this.label7.Text = "Telefono celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 30);
            this.label8.TabIndex = 90;
            this.label8.Text = "Referencia de como\r\nconoció el hotel:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 15);
            this.label9.TabIndex = 91;
            this.label9.Text = "Fecha de nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 92;
            this.label10.Text = "Estado civil:";
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Location = new System.Drawing.Point(161, 66);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(371, 23);
            this.TXT_NOMBRE.TabIndex = 94;
            // 
            // TXT_RFC
            // 
            this.TXT_RFC.Location = new System.Drawing.Point(586, 66);
            this.TXT_RFC.Name = "TXT_RFC";
            this.TXT_RFC.Size = new System.Drawing.Size(181, 23);
            this.TXT_RFC.TabIndex = 95;
            // 
            // TXT_DOMICILIO
            // 
            this.TXT_DOMICILIO.Location = new System.Drawing.Point(161, 112);
            this.TXT_DOMICILIO.Multiline = true;
            this.TXT_DOMICILIO.Name = "TXT_DOMICILIO";
            this.TXT_DOMICILIO.Size = new System.Drawing.Size(606, 40);
            this.TXT_DOMICILIO.TabIndex = 96;
            // 
            // TXT_CORREO
            // 
            this.TXT_CORREO.Location = new System.Drawing.Point(161, 175);
            this.TXT_CORREO.Name = "TXT_CORREO";
            this.TXT_CORREO.Size = new System.Drawing.Size(192, 23);
            this.TXT_CORREO.TabIndex = 97;
            // 
            // TXT_TELEFONOCASA
            // 
            this.TXT_TELEFONOCASA.Location = new System.Drawing.Point(468, 175);
            this.TXT_TELEFONOCASA.Name = "TXT_TELEFONOCASA";
            this.TXT_TELEFONOCASA.Size = new System.Drawing.Size(195, 23);
            this.TXT_TELEFONOCASA.TabIndex = 98;
            // 
            // TXT_TELEFONOCELULAR
            // 
            this.TXT_TELEFONOCELULAR.Location = new System.Drawing.Point(468, 213);
            this.TXT_TELEFONOCELULAR.Name = "TXT_TELEFONOCELULAR";
            this.TXT_TELEFONOCELULAR.Size = new System.Drawing.Size(195, 23);
            this.TXT_TELEFONOCELULAR.TabIndex = 99;
            // 
            // TXT_REFERENCIA
            // 
            this.TXT_REFERENCIA.Location = new System.Drawing.Point(168, 261);
            this.TXT_REFERENCIA.Name = "TXT_REFERENCIA";
            this.TXT_REFERENCIA.Size = new System.Drawing.Size(599, 23);
            this.TXT_REFERENCIA.TabIndex = 100;
            // 
            // CB_ESTADOCIVIL
            // 
            this.CB_ESTADOCIVIL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ESTADOCIVIL.FormattingEnabled = true;
            this.CB_ESTADOCIVIL.Items.AddRange(new object[] {
            "SOLTERO(A)",
            "CASADO(A)",
            "DIVORICIADO(A)",
            "VIUDO(A)",
            "UNION LIBRE"});
            this.CB_ESTADOCIVIL.Location = new System.Drawing.Point(125, 321);
            this.CB_ESTADOCIVIL.Name = "CB_ESTADOCIVIL";
            this.CB_ESTADOCIVIL.Size = new System.Drawing.Size(196, 23);
            this.CB_ESTADOCIVIL.TabIndex = 101;
            // 
            // DTP_FECHANACIMIENTO
            // 
            this.DTP_FECHANACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FECHANACIMIENTO.Location = new System.Drawing.Point(538, 318);
            this.DTP_FECHANACIMIENTO.Name = "DTP_FECHANACIMIENTO";
            this.DTP_FECHANACIMIENTO.Size = new System.Drawing.Size(137, 23);
            this.DTP_FECHANACIMIENTO.TabIndex = 102;
            // 
            // FORM_REGISTRO_CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 880);
            this.ControlBox = false;
            this.Controls.Add(this.DTP_FECHANACIMIENTO);
            this.Controls.Add(this.CB_ESTADOCIVIL);
            this.Controls.Add(this.TXT_REFERENCIA);
            this.Controls.Add(this.TXT_TELEFONOCELULAR);
            this.Controls.Add(this.TXT_TELEFONOCASA);
            this.Controls.Add(this.TXT_CORREO);
            this.Controls.Add(this.TXT_DOMICILIO);
            this.Controls.Add(this.TXT_RFC);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_EDITAR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REGISTRO_CLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Registro de Clientes!";
            this.Load += new System.EventHandler(this.FORM_REGISTRO_CLIENTES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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