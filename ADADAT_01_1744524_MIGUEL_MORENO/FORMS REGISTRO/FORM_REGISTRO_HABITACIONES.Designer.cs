
namespace PROYECTO_ADADAT
{
    partial class FORM_REGISTRO_HABITACIONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REGISTRO_HABITACIONES));
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_TIPOCAMAS = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR = new System.Windows.Forms.Button();
            this.BTN_EDITAR = new System.Windows.Forms.Button();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_PERSONAS = new System.Windows.Forms.ComboBox();
            this.CB_NIVEL = new System.Windows.Forms.ComboBox();
            this.CB_NUMEROCAMAS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(651, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 89;
            this.label9.Text = "Personas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_TIPOCAMAS
            // 
            this.TXT_TIPOCAMAS.Location = new System.Drawing.Point(443, 116);
            this.TXT_TIPOCAMAS.Multiline = true;
            this.TXT_TIPOCAMAS.Name = "TXT_TIPOCAMAS";
            this.TXT_TIPOCAMAS.Size = new System.Drawing.Size(345, 69);
            this.TXT_TIPOCAMAS.TabIndex = 83;
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Location = new System.Drawing.Point(498, 58);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(290, 23);
            this.TXT_NOMBRE.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 81;
            this.label7.Text = "Nivel de la habitación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 30);
            this.label6.TabIndex = 80;
            this.label6.Text = "Cantidad máxima de personas \r\npor habitación:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 78;
            this.label4.Text = "Numero de camas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tipo de camas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "Nombre de la habitación:";
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(1044, 514);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            this.BTN_SALIR.TabIndex = 75;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(502, 514);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_ELIMINAR.TabIndex = 74;
            this.BTN_ELIMINAR.Text = "ELIMINAR HABITACION";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.Location = new System.Drawing.Point(268, 883);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_EDITAR.TabIndex = 73;
            this.BTN_EDITAR.Text = "EDITAR HABITACION";
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.Location = new System.Drawing.Point(89, 514);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_GUARDAR.TabIndex = 72;
            this.BTN_GUARDAR.Text = "GUARDAR HABITACION";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(12, 514);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            this.BTN_REGRESAR.TabIndex = 71;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 267);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1187, 15);
            this.label22.TabIndex = 70;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(310, 298);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(556, 21);
            this.label17.TabIndex = 69;
            this.label17.Text = "AQUÍ SE MUESTRAN LAS HABITACIONES CAPTURADAS HASTA EL MOMENTO!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(316, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "ESTE ES EL APARTADO PARA EL REGISTRO Y EDICION DE LAS HABITACIONES!";
            // 
            // CB_PERSONAS
            // 
            this.CB_PERSONAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PERSONAS.FormattingEnabled = true;
            this.CB_PERSONAS.Items.AddRange(new object[] {
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
            "12"});
            this.CB_PERSONAS.Location = new System.Drawing.Point(524, 236);
            this.CB_PERSONAS.Name = "CB_PERSONAS";
            this.CB_PERSONAS.Size = new System.Drawing.Size(121, 23);
            this.CB_PERSONAS.TabIndex = 90;
            // 
            // CB_NIVEL
            // 
            this.CB_NIVEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NIVEL.FormattingEnabled = true;
            this.CB_NIVEL.Items.AddRange(new object[] {
            "01-HABITACION BASICA",
            "02-HABITACION MEDIA",
            "03-HABITACION PLUS",
            "04-HABITACION DELUXE",
            "05-HABITACION LUXURY"});
            this.CB_NIVEL.Location = new System.Drawing.Point(481, 87);
            this.CB_NIVEL.Name = "CB_NIVEL";
            this.CB_NIVEL.Size = new System.Drawing.Size(307, 23);
            this.CB_NIVEL.TabIndex = 91;
            // 
            // CB_NUMEROCAMAS
            // 
            this.CB_NUMEROCAMAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NUMEROCAMAS.FormattingEnabled = true;
            this.CB_NUMEROCAMAS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CB_NUMEROCAMAS.Location = new System.Drawing.Point(524, 191);
            this.CB_NUMEROCAMAS.Name = "CB_NUMEROCAMAS";
            this.CB_NUMEROCAMAS.Size = new System.Drawing.Size(121, 23);
            this.CB_NUMEROCAMAS.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 93;
            this.label5.Text = "Camas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FORM_REGISTRO_HABITACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_NUMEROCAMAS);
            this.Controls.Add(this.CB_NIVEL);
            this.Controls.Add(this.CB_PERSONAS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TXT_TIPOCAMAS);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_ELIMINAR);
            this.Controls.Add(this.BTN_EDITAR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REGISTRO_HABITACIONES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Registro de Habitaciones!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_TIPOCAMAS;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_PERSONAS;
        private System.Windows.Forms.ComboBox CB_NIVEL;
        private System.Windows.Forms.ComboBox CB_NUMEROCAMAS;
        private System.Windows.Forms.Label label5;
    }
}