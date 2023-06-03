namespace PROYECTO_ADADAT
{
    partial class FORM_GESTION_USUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_GESTION_USUARIOS));
            BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            BTN_ELIMINAR = new System.Windows.Forms.Button();
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            BTN_EDITAR = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            DTP_FECHANAC = new System.Windows.Forms.DateTimePicker();
            TXTB_TELCEL = new System.Windows.Forms.TextBox();
            TXTB_TELCASA = new System.Windows.Forms.TextBox();
            TXTB_DOMICILIO = new System.Windows.Forms.TextBox();
            TXTB_NOMINA = new System.Windows.Forms.TextBox();
            TXTB_NOMBRE = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            LB_CORREO = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // BTN_ACTUALIZAR
            // 
            BTN_ACTUALIZAR.Location = new System.Drawing.Point(445, 50);
            BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            BTN_ACTUALIZAR.Size = new System.Drawing.Size(128, 74);
            BTN_ACTUALIZAR.TabIndex = 141;
            BTN_ACTUALIZAR.Text = "ACTUALIZAR LISTA";
            BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            BTN_ACTUALIZAR.Click += BTN_ACTUALIZAR_Click;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new System.Drawing.Point(283, 358);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new System.Drawing.Size(173, 35);
            BTN_ELIMINAR.TabIndex = 140;
            BTN_ELIMINAR.Text = "ELIMINAR USUARIO";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            BTN_ELIMINAR.Click += BTN_ELIMINAR_Click;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(462, 358);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 139;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(23, 358);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 138;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // BTN_EDITAR
            // 
            BTN_EDITAR.Location = new System.Drawing.Point(104, 358);
            BTN_EDITAR.Name = "BTN_EDITAR";
            BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            BTN_EDITAR.TabIndex = 137;
            BTN_EDITAR.Text = "EDITAR USUARIO";
            BTN_EDITAR.UseVisualStyleBackColor = true;
            BTN_EDITAR.Click += BTN_EDITAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(109, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(437, 21);
            label2.TabIndex = 136;
            label2.Text = "ESTE ES EL APARTADO PARA LA GESTION DE LOS USUARIOS!";
            // 
            // DTP_FECHANAC
            // 
            DTP_FECHANAC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTP_FECHANAC.Location = new System.Drawing.Point(158, 197);
            DTP_FECHANAC.MaxDate = new System.DateTime(2023, 2, 23, 20, 33, 17, 0);
            DTP_FECHANAC.Name = "DTP_FECHANAC";
            DTP_FECHANAC.Size = new System.Drawing.Size(110, 23);
            DTP_FECHANAC.TabIndex = 157;
            DTP_FECHANAC.Value = new System.DateTime(2023, 2, 23, 0, 0, 0, 0);
            // 
            // TXTB_TELCEL
            // 
            TXTB_TELCEL.Location = new System.Drawing.Point(158, 311);
            TXTB_TELCEL.Name = "TXTB_TELCEL";
            TXTB_TELCEL.Size = new System.Drawing.Size(272, 23);
            TXTB_TELCEL.TabIndex = 156;
            // 
            // TXTB_TELCASA
            // 
            TXTB_TELCASA.Location = new System.Drawing.Point(158, 282);
            TXTB_TELCASA.Name = "TXTB_TELCASA";
            TXTB_TELCASA.Size = new System.Drawing.Size(272, 23);
            TXTB_TELCASA.TabIndex = 155;
            // 
            // TXTB_DOMICILIO
            // 
            TXTB_DOMICILIO.Location = new System.Drawing.Point(158, 226);
            TXTB_DOMICILIO.Multiline = true;
            TXTB_DOMICILIO.Name = "TXTB_DOMICILIO";
            TXTB_DOMICILIO.Size = new System.Drawing.Size(353, 50);
            TXTB_DOMICILIO.TabIndex = 154;
            // 
            // TXTB_NOMINA
            // 
            TXTB_NOMINA.Location = new System.Drawing.Point(158, 168);
            TXTB_NOMINA.Name = "TXTB_NOMINA";
            TXTB_NOMINA.Size = new System.Drawing.Size(272, 23);
            TXTB_NOMINA.TabIndex = 153;
            // 
            // TXTB_NOMBRE
            // 
            TXTB_NOMBRE.Location = new System.Drawing.Point(158, 139);
            TXTB_NOMBRE.Name = "TXTB_NOMBRE";
            TXTB_NOMBRE.Size = new System.Drawing.Size(272, 23);
            TXTB_NOMBRE.TabIndex = 152;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(57, 314);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(95, 15);
            label9.TabIndex = 149;
            label9.Text = "Telefono Celular:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(53, 285);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(99, 15);
            label8.TabIndex = 148;
            label8.Text = "Telefono de Casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(91, 229);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(61, 15);
            label7.TabIndex = 147;
            label7.Text = "Domicilio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(30, 200);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(122, 15);
            label6.TabIndex = 146;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(36, 171);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 15);
            label5.TabIndex = 145;
            label5.Text = "Numero de Nómina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(42, 142);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 15);
            label4.TabIndex = 144;
            label4.Text = "Nombre Completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 30);
            label1.TabIndex = 142;
            label1.Text = "Seleccione un \r\nCorreo Electronico:";
            // 
            // LB_CORREO
            // 
            LB_CORREO.DisplayMember = "correo_electronico";
            LB_CORREO.FormattingEnabled = true;
            LB_CORREO.ItemHeight = 15;
            LB_CORREO.Location = new System.Drawing.Point(158, 54);
            LB_CORREO.Name = "LB_CORREO";
            LB_CORREO.Size = new System.Drawing.Size(263, 64);
            LB_CORREO.TabIndex = 158;
            LB_CORREO.ValueMember = "correo_electronico";
            LB_CORREO.SelectedIndexChanged += LB_CORREO_SelectedIndexChanged;
            // 
            // FORM_GESTION_USUARIOS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(642, 427);
            ControlBox = false;
            Controls.Add(LB_CORREO);
            Controls.Add(DTP_FECHANAC);
            Controls.Add(TXTB_TELCEL);
            Controls.Add(TXTB_TELCASA);
            Controls.Add(TXTB_DOMICILIO);
            Controls.Add(TXTB_NOMINA);
            Controls.Add(TXTB_NOMBRE);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(BTN_ACTUALIZAR);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(BTN_EDITAR);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_GESTION_USUARIOS";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Apartado de Gestion de Usuarios!";
            Load += FORM_GESTION_USUARIOS_Load;
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
        private System.Windows.Forms.DateTimePicker DTP_FECHANAC;
        private System.Windows.Forms.TextBox TXTB_TELCEL;
        private System.Windows.Forms.TextBox TXTB_TELCASA;
        private System.Windows.Forms.TextBox TXTB_DOMICILIO;
        private System.Windows.Forms.TextBox TXTB_NOMINA;
        private System.Windows.Forms.TextBox TXTB_NOMBRE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_CORREO;
    }
}