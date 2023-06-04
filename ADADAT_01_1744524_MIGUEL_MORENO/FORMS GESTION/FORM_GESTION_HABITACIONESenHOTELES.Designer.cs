namespace PROYECTO_ADADAT
{
    partial class FORM_GESTION_HABITACIONESenHOTELES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_GESTION_HABITACIONESenHOTELES));
            BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            BTN_ELIMINAR = new System.Windows.Forms.Button();
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            BTN_EDITAR = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            LB_HOTELES = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            LB_HABITACIONES = new System.Windows.Forms.ListBox();
            label8 = new System.Windows.Forms.Label();
            TXT_PRECIO = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            TXT_CARACTERISTICAS = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            TXT_AMENIDADES = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // BTN_ACTUALIZAR
            // 
            BTN_ACTUALIZAR.Location = new System.Drawing.Point(992, 45);
            BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            BTN_ACTUALIZAR.Size = new System.Drawing.Size(128, 74);
            BTN_ACTUALIZAR.TabIndex = 141;
            BTN_ACTUALIZAR.Text = "ACTUALIZAR LISTA";
            BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            BTN_ACTUALIZAR.Click += BTN_ACTUALIZAR_Click;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new System.Drawing.Point(376, 277);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new System.Drawing.Size(203, 35);
            BTN_ELIMINAR.TabIndex = 140;
            BTN_ELIMINAR.Text = "ELIMINAR HABITACION EN HOTEL";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            BTN_ELIMINAR.Click += BTN_ELIMINAR_Click;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(624, 277);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 139;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(28, 277);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 138;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // BTN_EDITAR
            // 
            BTN_EDITAR.Location = new System.Drawing.Point(187, 277);
            BTN_EDITAR.Name = "BTN_EDITAR";
            BTN_EDITAR.Size = new System.Drawing.Size(183, 35);
            BTN_EDITAR.TabIndex = 137;
            BTN_EDITAR.Text = "EDITAR HABITACION EN HOTEL";
            BTN_EDITAR.UseVisualStyleBackColor = true;
            BTN_EDITAR.Click += BTN_EDITAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(314, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(557, 21);
            label2.TabIndex = 136;
            label2.Text = "ESTE ES EL APARTADO PARA LA GESTION DE LAS HABITACIONES EN HOTELES!";
            // 
            // LB_HOTELES
            // 
            LB_HOTELES.DisplayMember = "nombre";
            LB_HOTELES.FormattingEnabled = true;
            LB_HOTELES.ItemHeight = 15;
            LB_HOTELES.Location = new System.Drawing.Point(170, 60);
            LB_HOTELES.Name = "LB_HOTELES";
            LB_HOTELES.Size = new System.Drawing.Size(312, 49);
            LB_HOTELES.Sorted = true;
            LB_HOTELES.TabIndex = 156;
            LB_HOTELES.ValueMember = "nombre";
            LB_HOTELES.SelectedIndexChanged += LB_HOTELES_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label4.Location = new System.Drawing.Point(28, 60);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label4.Size = new System.Drawing.Size(136, 45);
            label4.TabIndex = 153;
            label4.Text = "Selecione el nombre del \r\nHotel al que le desea\r\neditar las habitaciones:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_HABITACIONES
            // 
            LB_HABITACIONES.DisplayMember = "nombre";
            LB_HABITACIONES.FormattingEnabled = true;
            LB_HABITACIONES.ItemHeight = 15;
            LB_HABITACIONES.Location = new System.Drawing.Point(663, 60);
            LB_HABITACIONES.Name = "LB_HABITACIONES";
            LB_HABITACIONES.Size = new System.Drawing.Size(312, 49);
            LB_HABITACIONES.Sorted = true;
            LB_HABITACIONES.TabIndex = 152;
            LB_HABITACIONES.ValueMember = "nombre";
            LB_HABITACIONES.SelectedIndexChanged += LB_HABITACIONES_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(376, 214);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(43, 15);
            label8.TabIndex = 151;
            label8.Text = "$ MXN";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_PRECIO
            // 
            TXT_PRECIO.Location = new System.Drawing.Point(233, 211);
            TXT_PRECIO.Name = "TXT_PRECIO";
            TXT_PRECIO.Size = new System.Drawing.Size(137, 23);
            TXT_PRECIO.TabIndex = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(127, 214);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 30);
            label5.TabIndex = 149;
            label5.Text = "Precio por noche \r\nde la habitación:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_CARACTERISTICAS
            // 
            TXT_CARACTERISTICAS.Location = new System.Drawing.Point(233, 174);
            TXT_CARACTERISTICAS.Multiline = true;
            TXT_CARACTERISTICAS.Name = "TXT_CARACTERISTICAS";
            TXT_CARACTERISTICAS.Size = new System.Drawing.Size(856, 30);
            TXT_CARACTERISTICAS.TabIndex = 148;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(81, 174);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(146, 30);
            label10.TabIndex = 147;
            label10.Text = "Caracteristicas que tendrá \r\nla habitación:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_AMENIDADES
            // 
            TXT_AMENIDADES.Location = new System.Drawing.Point(233, 138);
            TXT_AMENIDADES.Multiline = true;
            TXT_AMENIDADES.Name = "TXT_AMENIDADES";
            TXT_AMENIDADES.Size = new System.Drawing.Size(856, 30);
            TXT_AMENIDADES.TabIndex = 146;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(32, 138);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(195, 30);
            label12.TabIndex = 145;
            label12.Text = "Amenidades que estarán disponible\r\nen este tipo de habitaciones:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(529, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 45);
            label1.TabIndex = 142;
            label1.Text = "Selecione la habitacion\r\nque desea edidar del \r\nhotel:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FORM_GESTION_HABITACIONESenHOTELES
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1221, 330);
            ControlBox = false;
            Controls.Add(LB_HOTELES);
            Controls.Add(label4);
            Controls.Add(LB_HABITACIONES);
            Controls.Add(label8);
            Controls.Add(TXT_PRECIO);
            Controls.Add(label5);
            Controls.Add(TXT_CARACTERISTICAS);
            Controls.Add(label10);
            Controls.Add(TXT_AMENIDADES);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(BTN_ACTUALIZAR);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(BTN_EDITAR);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_GESTION_HABITACIONESenHOTELES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Apartado de Gestion de Habitaciones En Hoteles!";
            Load += FORM_GESTION_HABITACIONESenHOTELES_Load;
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
        private System.Windows.Forms.ListBox LB_HOTELES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LB_HABITACIONES;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_PRECIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_CARACTERISTICAS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_AMENIDADES;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
    }
}