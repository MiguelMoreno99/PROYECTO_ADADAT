
namespace PROYECTO_ADADAT
{
    partial class FORM_REGISTRO_HABITACIONESenHOTELES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REGISTRO_HABITACIONESenHOTELES));
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR = new System.Windows.Forms.Button();
            this.BTN_EDITAR = new System.Windows.Forms.Button();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.CB_HABITACIONES = new System.Windows.Forms.ComboBox();
            this.TXT_DATOS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_CARACTERISTICAS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_AMENIDADES = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_PRECIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(995, 514);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            this.BTN_SALIR.TabIndex = 79;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(452, 514);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_ELIMINAR.TabIndex = 78;
            this.BTN_ELIMINAR.Text = "ELIMINAR HABITACION";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.Location = new System.Drawing.Point(273, 514);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_EDITAR.TabIndex = 77;
            this.BTN_EDITAR.Text = "EDITAR HABITACION";
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            this.BTN_EDITAR.Click += new System.EventHandler(this.BTN_EDITAR_Click);
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.Location = new System.Drawing.Point(94, 514);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_GUARDAR.TabIndex = 76;
            this.BTN_GUARDAR.Text = "GUARDAR HABITACION";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(17, 514);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            this.BTN_REGRESAR.TabIndex = 75;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // CB_HABITACIONES
            // 
            this.CB_HABITACIONES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_HABITACIONES.FormattingEnabled = true;
            this.CB_HABITACIONES.Items.AddRange(new object[] {
            "STANDART",
            "MEDIUM",
            "PREMIUM",
            "PREMIUM PLUS"});
            this.CB_HABITACIONES.Location = new System.Drawing.Point(183, 74);
            this.CB_HABITACIONES.Name = "CB_HABITACIONES";
            this.CB_HABITACIONES.Size = new System.Drawing.Size(263, 23);
            this.CB_HABITACIONES.TabIndex = 74;
            // 
            // TXT_DATOS
            // 
            this.TXT_DATOS.Location = new System.Drawing.Point(631, 55);
            this.TXT_DATOS.Multiline = true;
            this.TXT_DATOS.Name = "TXT_DATOS";
            this.TXT_DATOS.ReadOnly = true;
            this.TXT_DATOS.Size = new System.Drawing.Size(438, 67);
            this.TXT_DATOS.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 30);
            this.label11.TabIndex = 68;
            this.label11.Text = "Datos de la habitación\r\nseleccionada:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 45);
            this.label2.TabIndex = 67;
            this.label2.Text = "Selecione el nombre de la\r\nhabitación que se agregará \r\nal hotel:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(-1, 233);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1157, 15);
            this.label22.TabIndex = 66;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(273, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(633, 21);
            this.label17.TabIndex = 65;
            this.label17.Text = "AQUÍ SE MUESTRAN LAS HABITACIONES DEL HOTEL INGRESADAS HASTA EL MOMENTO!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(337, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 21);
            this.label1.TabIndex = 64;
            this.label1.Text = "ESTE ES EL APARTADO PARA EL REGISTRO Y EDICION DE LAS HABITACIONES DEL HOTEL!";
            // 
            // TXT_CARACTERISTICAS
            // 
            this.TXT_CARACTERISTICAS.Location = new System.Drawing.Point(213, 162);
            this.TXT_CARACTERISTICAS.Multiline = true;
            this.TXT_CARACTERISTICAS.Name = "TXT_CARACTERISTICAS";
            this.TXT_CARACTERISTICAS.Size = new System.Drawing.Size(856, 30);
            this.TXT_CARACTERISTICAS.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 30);
            this.label10.TabIndex = 97;
            this.label10.Text = "Caracteristicas que tendrá \r\nla habitación:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_AMENIDADES
            // 
            this.TXT_AMENIDADES.Location = new System.Drawing.Point(213, 126);
            this.TXT_AMENIDADES.Multiline = true;
            this.TXT_AMENIDADES.Name = "TXT_AMENIDADES";
            this.TXT_AMENIDADES.Size = new System.Drawing.Size(856, 30);
            this.TXT_AMENIDADES.TabIndex = 96;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 30);
            this.label12.TabIndex = 95;
            this.label12.Text = "Amenidades que estarán disponible\r\nen este tipo de habitaciones:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 101;
            this.label8.Text = "$ MXN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_PRECIO
            // 
            this.TXT_PRECIO.Location = new System.Drawing.Point(213, 199);
            this.TXT_PRECIO.Name = "TXT_PRECIO";
            this.TXT_PRECIO.Size = new System.Drawing.Size(137, 23);
            this.TXT_PRECIO.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 99;
            this.label5.Text = "Precio por noche \r\nde la habitación:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FORM_REGISTRO_HABITACIONESenHOTELES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXT_PRECIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_CARACTERISTICAS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TXT_AMENIDADES);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_ELIMINAR);
            this.Controls.Add(this.BTN_EDITAR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.CB_HABITACIONES);
            this.Controls.Add(this.TXT_DATOS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REGISTRO_HABITACIONESenHOTELES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido Registro de Habitaciones en Hoteles!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.ComboBox CB_HABITACIONES;
        private System.Windows.Forms.TextBox TXT_DATOS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_CARACTERISTICAS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_AMENIDADES;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_PRECIO;
        private System.Windows.Forms.Label label5;
    }
}