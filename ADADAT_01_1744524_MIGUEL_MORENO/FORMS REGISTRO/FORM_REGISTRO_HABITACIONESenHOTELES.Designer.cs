
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
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
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
            this.CB_HABITACIONES.Location = new System.Drawing.Point(172, 91);
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
            this.TXT_DATOS.Size = new System.Drawing.Size(438, 112);
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
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 45);
            this.label2.TabIndex = 67;
            this.label2.Text = "Selecione el nombre de la\r\nhabitación que se agregará \r\nal hotel:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(0, 182);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1157, 15);
            this.label22.TabIndex = 66;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(273, 210);
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
            // FORM_REGISTRO_HABITACIONESenHOTELES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 561);
            this.ControlBox = false;
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
    }
}