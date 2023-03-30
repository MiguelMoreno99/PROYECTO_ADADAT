
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
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_CANCELARRESERVACION = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            label22 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            TXT_RESERVACION = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(668, 507);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 42);
            BTN_SALIR.TabIndex = 89;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_CANCELARRESERVACION
            // 
            BTN_CANCELARRESERVACION.Location = new System.Drawing.Point(221, 507);
            BTN_CANCELARRESERVACION.Name = "BTN_CANCELARRESERVACION";
            BTN_CANCELARRESERVACION.Size = new System.Drawing.Size(173, 42);
            BTN_CANCELARRESERVACION.TabIndex = 88;
            BTN_CANCELARRESERVACION.Text = "CANCELAR RESERVACIÓN";
            BTN_CANCELARRESERVACION.UseVisualStyleBackColor = true;
            BTN_CANCELARRESERVACION.Click += BTN_CANCELARRESERVACION_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(9, 507);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 42);
            BTN_REGRESAR.TabIndex = 87;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(9, 126);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(817, 15);
            label22.TabIndex = 86;
            label22.Text = "__________________________________________________________________________________________________________________________________________________________________";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(221, 155);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(385, 21);
            label17.TabIndex = 85;
            label17.Text = "AQUÍ SE MUESTRAN LAS RESERVACIONES CREADAS!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(175, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(490, 21);
            label2.TabIndex = 84;
            label2.Text = "ESTE ES EL APARTADO PARA LA CANCELACIÓN DE RESERVACIONES!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(203, 74);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(191, 15);
            label1.TabIndex = 90;
            label1.Text = "Ingrese el codigo de la reservación:";
            // 
            // TXT_RESERVACION
            // 
            TXT_RESERVACION.Location = new System.Drawing.Point(400, 71);
            TXT_RESERVACION.Name = "TXT_RESERVACION";
            TXT_RESERVACION.Size = new System.Drawing.Size(212, 23);
            TXT_RESERVACION.TabIndex = 91;
            // 
            // FORM_REGISTRO_CANCELACIONES
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(828, 561);
            ControlBox = false;
            Controls.Add(TXT_RESERVACION);
            Controls.Add(label1);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_CANCELARRESERVACION);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(label22);
            Controls.Add(label17);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REGISTRO_CANCELACIONES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Apartado de Cancelaciones!";
            ResumeLayout(false);
            PerformLayout();
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