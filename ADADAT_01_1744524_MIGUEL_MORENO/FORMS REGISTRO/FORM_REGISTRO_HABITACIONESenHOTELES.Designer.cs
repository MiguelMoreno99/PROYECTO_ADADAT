
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
            this.TXT_DATOS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_CARACTERISTICAS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_AMENIDADES = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_PRECIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_HABITACIONES = new System.Windows.Forms.ListBox();
            this.BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            this.LB_HOTELES = new System.Windows.Forms.ListBox();
            this.TXT_DATOS2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_NUMERO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(982, 344);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            this.BTN_SALIR.TabIndex = 79;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(439, 344);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_ELIMINAR.TabIndex = 78;
            this.BTN_ELIMINAR.Text = "ELIMINAR HABITACION";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.Location = new System.Drawing.Point(260, 344);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_EDITAR.TabIndex = 77;
            this.BTN_EDITAR.Text = "EDITAR HABITACION";
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            this.BTN_EDITAR.Click += new System.EventHandler(this.BTN_EDITAR_Click);
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.Location = new System.Drawing.Point(81, 344);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(173, 35);
            this.BTN_GUARDAR.TabIndex = 76;
            this.BTN_GUARDAR.Text = "GUARDAR HABITACION";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(4, 344);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            this.BTN_REGRESAR.TabIndex = 75;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // TXT_DATOS
            // 
            this.TXT_DATOS.Location = new System.Drawing.Point(641, 143);
            this.TXT_DATOS.Multiline = true;
            this.TXT_DATOS.Name = "TXT_DATOS";
            this.TXT_DATOS.ReadOnly = true;
            this.TXT_DATOS.Size = new System.Drawing.Size(438, 67);
            this.TXT_DATOS.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 30);
            this.label11.TabIndex = 68;
            this.label11.Text = "Datos de la habitación\r\nseleccionada:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 45);
            this.label2.TabIndex = 67;
            this.label2.Text = "Selecione el nombre de la\r\nhabitación que se agregará \r\nal hotel:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.TXT_CARACTERISTICAS.Location = new System.Drawing.Point(223, 249);
            this.TXT_CARACTERISTICAS.Multiline = true;
            this.TXT_CARACTERISTICAS.Name = "TXT_CARACTERISTICAS";
            this.TXT_CARACTERISTICAS.Size = new System.Drawing.Size(856, 30);
            this.TXT_CARACTERISTICAS.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 30);
            this.label10.TabIndex = 97;
            this.label10.Text = "Caracteristicas que tendrá \r\nla habitación:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_AMENIDADES
            // 
            this.TXT_AMENIDADES.Location = new System.Drawing.Point(223, 213);
            this.TXT_AMENIDADES.Multiline = true;
            this.TXT_AMENIDADES.Name = "TXT_AMENIDADES";
            this.TXT_AMENIDADES.Size = new System.Drawing.Size(856, 30);
            this.TXT_AMENIDADES.TabIndex = 96;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 30);
            this.label12.TabIndex = 95;
            this.label12.Text = "Amenidades que estarán disponible\r\nen este tipo de habitaciones:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 101;
            this.label8.Text = "$ MXN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_PRECIO
            // 
            this.TXT_PRECIO.Location = new System.Drawing.Point(223, 286);
            this.TXT_PRECIO.Name = "TXT_PRECIO";
            this.TXT_PRECIO.Size = new System.Drawing.Size(137, 23);
            this.TXT_PRECIO.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 99;
            this.label5.Text = "Precio por noche \r\nde la habitación:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_HABITACIONES
            // 
            this.LB_HABITACIONES.DisplayMember = "nombre";
            this.LB_HABITACIONES.FormattingEnabled = true;
            this.LB_HABITACIONES.ItemHeight = 15;
            this.LB_HABITACIONES.Location = new System.Drawing.Point(193, 151);
            this.LB_HABITACIONES.Name = "LB_HABITACIONES";
            this.LB_HABITACIONES.Size = new System.Drawing.Size(312, 49);
            this.LB_HABITACIONES.Sorted = true;
            this.LB_HABITACIONES.TabIndex = 103;
            this.LB_HABITACIONES.ValueMember = "nombre";
            this.LB_HABITACIONES.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BTN_ACTUALIZAR
            // 
            this.BTN_ACTUALIZAR.Location = new System.Drawing.Point(193, 125);
            this.BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            this.BTN_ACTUALIZAR.Size = new System.Drawing.Size(312, 23);
            this.BTN_ACTUALIZAR.TabIndex = 109;
            this.BTN_ACTUALIZAR.Text = "ACTUALIZAR";
            this.BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTN_ACTUALIZAR.Click += new System.EventHandler(this.BTN_ACTUALIZAR_Click);
            // 
            // LB_HOTELES
            // 
            this.LB_HOTELES.DisplayMember = "nombre";
            this.LB_HOTELES.FormattingEnabled = true;
            this.LB_HOTELES.ItemHeight = 15;
            this.LB_HOTELES.Location = new System.Drawing.Point(193, 74);
            this.LB_HOTELES.Name = "LB_HOTELES";
            this.LB_HOTELES.Size = new System.Drawing.Size(312, 49);
            this.LB_HOTELES.Sorted = true;
            this.LB_HOTELES.TabIndex = 108;
            this.LB_HOTELES.ValueMember = "nombre";
            this.LB_HOTELES.SelectedIndexChanged += new System.EventHandler(this.LB_HOTELES_SelectedIndexChanged);
            // 
            // TXT_DATOS2
            // 
            this.TXT_DATOS2.Location = new System.Drawing.Point(641, 66);
            this.TXT_DATOS2.Multiline = true;
            this.TXT_DATOS2.Name = "TXT_DATOS2";
            this.TXT_DATOS2.ReadOnly = true;
            this.TXT_DATOS2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_DATOS2.Size = new System.Drawing.Size(438, 67);
            this.TXT_DATOS2.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 106;
            this.label3.Text = "Datos del Hotel\r\nseleccionado:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(51, 74);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(136, 45);
            this.label4.TabIndex = 105;
            this.label4.Text = "Selecione el nombre del \r\nHotel al que le desea\r\nagregar habitaciones:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 110;
            this.label6.Text = "No. de Habitacion:";
            // 
            // TXT_NUMERO
            // 
            this.TXT_NUMERO.Location = new System.Drawing.Point(631, 285);
            this.TXT_NUMERO.Name = "TXT_NUMERO";
            this.TXT_NUMERO.Size = new System.Drawing.Size(144, 23);
            this.TXT_NUMERO.TabIndex = 111;
            // 
            // FORM_REGISTRO_HABITACIONESenHOTELES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 397);
            this.ControlBox = false;
            this.Controls.Add(this.TXT_NUMERO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTN_ACTUALIZAR);
            this.Controls.Add(this.LB_HOTELES);
            this.Controls.Add(this.TXT_DATOS2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_HABITACIONES);
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
            this.Controls.Add(this.TXT_DATOS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REGISTRO_HABITACIONESenHOTELES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido Registro de Habitaciones en Hoteles!";
            this.Load += new System.EventHandler(this.FORM_REGISTRO_HABITACIONESenHOTELES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.TextBox TXT_DATOS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_CARACTERISTICAS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_AMENIDADES;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_PRECIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LB_HABITACIONES;
        private System.Windows.Forms.Button BTN_ACTUALIZAR;
        private System.Windows.Forms.ListBox LB_HOTELES;
        private System.Windows.Forms.TextBox TXT_DATOS2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_NUMERO;
    }
}