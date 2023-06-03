namespace PROYECTO_ADADAT
{
    partial class FORM_GESTION_HABITACIONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_GESTION_HABITACIONES));
            BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            BTN_ELIMINAR = new System.Windows.Forms.Button();
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            BTN_EDITAR = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            CB_NUMEROCAMAS = new System.Windows.Forms.ComboBox();
            CB_NIVEL = new System.Windows.Forms.ComboBox();
            CB_PERSONAS = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            TXT_TIPOCAMAS = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            LB_NOMBRE_HABITACION = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // BTN_ACTUALIZAR
            // 
            BTN_ACTUALIZAR.Location = new System.Drawing.Point(474, 57);
            BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            BTN_ACTUALIZAR.Size = new System.Drawing.Size(128, 74);
            BTN_ACTUALIZAR.TabIndex = 141;
            BTN_ACTUALIZAR.Text = "ACTUALIZAR LISTA";
            BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            BTN_ACTUALIZAR.Click += BTN_ACTUALIZAR_Click;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new System.Drawing.Point(280, 368);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new System.Drawing.Size(173, 35);
            BTN_ELIMINAR.TabIndex = 140;
            BTN_ELIMINAR.Text = "ELIMINAR HABITACION";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            BTN_ELIMINAR.Click += BTN_ELIMINAR_Click;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(459, 368);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 139;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(24, 368);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 138;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // BTN_EDITAR
            // 
            BTN_EDITAR.Location = new System.Drawing.Point(101, 368);
            BTN_EDITAR.Name = "BTN_EDITAR";
            BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            BTN_EDITAR.TabIndex = 137;
            BTN_EDITAR.Text = "EDITAR HABITACION";
            BTN_EDITAR.UseVisualStyleBackColor = true;
            BTN_EDITAR.Click += BTN_EDITAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(74, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(466, 21);
            label2.TabIndex = 136;
            label2.Text = "ESTE ES EL APARTADO PARA LA GESTION DE LAS HABITACIONES!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(324, 255);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 15);
            label5.TabIndex = 153;
            label5.Text = "Camas";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CB_NUMEROCAMAS
            // 
            CB_NUMEROCAMAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_NUMEROCAMAS.FormattingEnabled = true;
            CB_NUMEROCAMAS.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            CB_NUMEROCAMAS.Location = new System.Drawing.Point(197, 252);
            CB_NUMEROCAMAS.Name = "CB_NUMEROCAMAS";
            CB_NUMEROCAMAS.Size = new System.Drawing.Size(121, 23);
            CB_NUMEROCAMAS.TabIndex = 152;
            // 
            // CB_NIVEL
            // 
            CB_NIVEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_NIVEL.FormattingEnabled = true;
            CB_NIVEL.Items.AddRange(new object[] { "01-HABITACION BASICA", "02-HABITACION MEDIA", "03-HABITACION PLUS", "04-HABITACION DELUXE", "05-HABITACION LUXURY" });
            CB_NIVEL.Location = new System.Drawing.Point(154, 148);
            CB_NIVEL.Name = "CB_NIVEL";
            CB_NIVEL.Size = new System.Drawing.Size(307, 23);
            CB_NIVEL.TabIndex = 151;
            // 
            // CB_PERSONAS
            // 
            CB_PERSONAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_PERSONAS.FormattingEnabled = true;
            CB_PERSONAS.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            CB_PERSONAS.Location = new System.Drawing.Point(197, 297);
            CB_PERSONAS.Name = "CB_PERSONAS";
            CB_PERSONAS.Size = new System.Drawing.Size(121, 23);
            CB_PERSONAS.TabIndex = 150;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(324, 300);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(54, 15);
            label9.TabIndex = 149;
            label9.Text = "Personas";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_TIPOCAMAS
            // 
            TXT_TIPOCAMAS.Location = new System.Drawing.Point(116, 177);
            TXT_TIPOCAMAS.Multiline = true;
            TXT_TIPOCAMAS.Name = "TXT_TIPOCAMAS";
            TXT_TIPOCAMAS.Size = new System.Drawing.Size(345, 69);
            TXT_TIPOCAMAS.TabIndex = 148;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(24, 151);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(124, 15);
            label7.TabIndex = 146;
            label7.Text = "Nivel de la habitación:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(24, 292);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(170, 30);
            label6.TabIndex = 145;
            label6.Text = "Cantidad máxima de personas \r\npor habitación:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(84, 255);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(107, 15);
            label4.TabIndex = 144;
            label4.Text = "Numero de camas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(24, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 15);
            label3.TabIndex = 143;
            label3.Text = "Tipo de camas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 30);
            label1.TabIndex = 142;
            label1.Text = "Seleccione un Nombre \r\nde la habitación:";
            // 
            // LB_NOMBRE_HABITACION
            // 
            LB_NOMBRE_HABITACION.DisplayMember = "nombre";
            LB_NOMBRE_HABITACION.FormattingEnabled = true;
            LB_NOMBRE_HABITACION.ItemHeight = 15;
            LB_NOMBRE_HABITACION.Location = new System.Drawing.Point(162, 57);
            LB_NOMBRE_HABITACION.Name = "LB_NOMBRE_HABITACION";
            LB_NOMBRE_HABITACION.Size = new System.Drawing.Size(299, 64);
            LB_NOMBRE_HABITACION.TabIndex = 154;
            LB_NOMBRE_HABITACION.ValueMember = "nombre";
            LB_NOMBRE_HABITACION.SelectedIndexChanged += LB_NOMBRE_HABITACION_SelectedIndexChanged;
            // 
            // FORM_GESTION_HABITACIONES
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(614, 414);
            ControlBox = false;
            Controls.Add(LB_NOMBRE_HABITACION);
            Controls.Add(label5);
            Controls.Add(CB_NUMEROCAMAS);
            Controls.Add(CB_NIVEL);
            Controls.Add(CB_PERSONAS);
            Controls.Add(label9);
            Controls.Add(TXT_TIPOCAMAS);
            Controls.Add(label7);
            Controls.Add(label6);
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
            Name = "FORM_GESTION_HABITACIONES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Apartado de Gestion de Habitaciones!";
            Load += FORM_GESTION_HABITACIONES_Load;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_NUMEROCAMAS;
        private System.Windows.Forms.ComboBox CB_NIVEL;
        private System.Windows.Forms.ComboBox CB_PERSONAS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_TIPOCAMAS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_NOMBRE_HABITACION;
    }
}