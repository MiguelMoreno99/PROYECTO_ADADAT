
namespace PROYECTO_ADADAT
{
    partial class FORM_REGISTRO_CANCELACIONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REGISTRO_CANCELACIONES));
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_CANCELARRESERVACION = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_RESERVACION = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(668, 456);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(148, 42);
            this.BTN_SALIR.TabIndex = 89;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_CANCELARRESERVACION
            // 
            this.BTN_CANCELARRESERVACION.Location = new System.Drawing.Point(221, 456);
            this.BTN_CANCELARRESERVACION.Name = "BTN_CANCELARRESERVACION";
            this.BTN_CANCELARRESERVACION.Size = new System.Drawing.Size(173, 42);
            this.BTN_CANCELARRESERVACION.TabIndex = 88;
            this.BTN_CANCELARRESERVACION.Text = "CANCELAR RESERVACIÓN";
            this.BTN_CANCELARRESERVACION.UseVisualStyleBackColor = true;
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(9, 456);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(71, 42);
            this.BTN_REGRESAR.TabIndex = 87;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(817, 15);
            this.label22.TabIndex = 86;
            this.label22.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(221, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(385, 21);
            this.label17.TabIndex = 85;
            this.label17.Text = "AQUÍ SE MUESTRAN LAS RESERVACIONES CREADAS!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(175, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 21);
            this.label2.TabIndex = 84;
            this.label2.Text = "ESTE ES EL APARTADO PARA LA CANCELACIÓN DE RESERVACIONES!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 15);
            this.label1.TabIndex = 90;
            this.label1.Text = "Ingrese el codigo de la reservación:";
            // 
            // TXT_RESERVACION
            // 
            this.TXT_RESERVACION.Location = new System.Drawing.Point(400, 71);
            this.TXT_RESERVACION.Name = "TXT_RESERVACION";
            this.TXT_RESERVACION.Size = new System.Drawing.Size(212, 23);
            this.TXT_RESERVACION.TabIndex = 91;
            // 
            // FORM_REGISTRO_CANCELACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 510);
            this.ControlBox = false;
            this.Controls.Add(this.TXT_RESERVACION);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_CANCELARRESERVACION);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REGISTRO_CANCELACIONES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Apartado de Cancelaciones!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_CANCELARRESERVACION;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_RESERVACION;
    }
}