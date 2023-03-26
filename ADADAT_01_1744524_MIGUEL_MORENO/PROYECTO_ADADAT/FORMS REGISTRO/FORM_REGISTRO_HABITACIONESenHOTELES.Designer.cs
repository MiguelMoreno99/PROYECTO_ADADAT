
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
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_ELIMINAR = new System.Windows.Forms.Button();
            BTN_EDITAR = new System.Windows.Forms.Button();
            BTN_GUARDAR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            CB_HABITACIONES = new System.Windows.Forms.ComboBox();
            TXT_CARACTERISTICAS = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            TXT_AMENIDADES = new System.Windows.Forms.TextBox();
            TXT_DATOS = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(995, 514);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 79;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new System.Drawing.Point(452, 514);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new System.Drawing.Size(173, 35);
            BTN_ELIMINAR.TabIndex = 78;
            BTN_ELIMINAR.Text = "ELIMINAR HABITACION";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTN_EDITAR
            // 
            BTN_EDITAR.Location = new System.Drawing.Point(273, 514);
            BTN_EDITAR.Name = "BTN_EDITAR";
            BTN_EDITAR.Size = new System.Drawing.Size(173, 35);
            BTN_EDITAR.TabIndex = 77;
            BTN_EDITAR.Text = "EDITAR HABITACION";
            BTN_EDITAR.UseVisualStyleBackColor = true;
            // 
            // BTN_GUARDAR
            // 
            BTN_GUARDAR.Location = new System.Drawing.Point(94, 514);
            BTN_GUARDAR.Name = "BTN_GUARDAR";
            BTN_GUARDAR.Size = new System.Drawing.Size(173, 35);
            BTN_GUARDAR.TabIndex = 76;
            BTN_GUARDAR.Text = "GUARDAR HABITACION";
            BTN_GUARDAR.UseVisualStyleBackColor = true;
            BTN_GUARDAR.Click += BTN_GUARDAR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(17, 514);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 75;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // CB_HABITACIONES
            // 
            CB_HABITACIONES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_HABITACIONES.FormattingEnabled = true;
            CB_HABITACIONES.Items.AddRange(new object[] { "STANDART", "MEDIUM", "PREMIUM", "PREMIUM PLUS" });
            CB_HABITACIONES.Location = new System.Drawing.Point(172, 91);
            CB_HABITACIONES.Name = "CB_HABITACIONES";
            CB_HABITACIONES.Size = new System.Drawing.Size(263, 23);
            CB_HABITACIONES.TabIndex = 74;
            // 
            // TXT_CARACTERISTICAS
            // 
            TXT_CARACTERISTICAS.Location = new System.Drawing.Point(767, 180);
            TXT_CARACTERISTICAS.Multiline = true;
            TXT_CARACTERISTICAS.Name = "TXT_CARACTERISTICAS";
            TXT_CARACTERISTICAS.Size = new System.Drawing.Size(375, 112);
            TXT_CARACTERISTICAS.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(612, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(149, 30);
            label3.TabIndex = 72;
            label3.Text = "Caracteristicas que tendrá \r\nla habitación seleccionada:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_AMENIDADES
            // 
            TXT_AMENIDADES.Location = new System.Drawing.Point(670, 72);
            TXT_AMENIDADES.Multiline = true;
            TXT_AMENIDADES.Name = "TXT_AMENIDADES";
            TXT_AMENIDADES.Size = new System.Drawing.Size(472, 84);
            TXT_AMENIDADES.TabIndex = 71;
            // 
            // TXT_DATOS
            // 
            TXT_DATOS.Location = new System.Drawing.Point(148, 142);
            TXT_DATOS.Multiline = true;
            TXT_DATOS.Name = "TXT_DATOS";
            TXT_DATOS.ReadOnly = true;
            TXT_DATOS.Size = new System.Drawing.Size(438, 112);
            TXT_DATOS.TabIndex = 70;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(469, 72);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(195, 30);
            label12.TabIndex = 69;
            label12.Text = "Amenidades que estarán disponible\r\nen este tipo de habitaciones:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(18, 142);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(124, 30);
            label11.TabIndex = 68;
            label11.Text = "Datos de la habitación\r\nseleccionada:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(152, 45);
            label2.TabIndex = 67;
            label2.Text = "Selecione el nombre de la\r\nhabitación que se agregará \r\nal hotel:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(0, 324);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(1157, 15);
            label22.TabIndex = 66;
            label22.Text = resources.GetString("label22.Text");
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(270, 352);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(633, 21);
            label17.TabIndex = 65;
            label17.Text = "AQUÍ SE MUESTRAN LAS HABITACIONES DEL HOTEL INGRESADAS HASTA EL MOMENTO!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(337, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(631, 21);
            label1.TabIndex = 64;
            label1.Text = "ESTE ES EL APARTADO PARA EL REGISTRO Y EDICION DE LAS HABITACIONES DEL HOTEL!";
            // 
            // FORM_REGISTRO_HABITACIONESenHOTELES
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1155, 561);
            ControlBox = false;
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_EDITAR);
            Controls.Add(BTN_GUARDAR);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(CB_HABITACIONES);
            Controls.Add(TXT_CARACTERISTICAS);
            Controls.Add(label3);
            Controls.Add(TXT_AMENIDADES);
            Controls.Add(TXT_DATOS);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label22);
            Controls.Add(label17);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REGISTRO_HABITACIONESenHOTELES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido Registro de Habitaciones en Hoteles!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.ComboBox CB_HABITACIONES;
        private System.Windows.Forms.TextBox TXT_CARACTERISTICAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_AMENIDADES;
        private System.Windows.Forms.TextBox TXT_DATOS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
    }
}