
namespace PROYECTO_ADADAT
{
    partial class FORM_REGISTRO_CHECKIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REGISTRO_CHECKIN));
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_HACERCHECKIN = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            TXT_RESERVACION = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(392, 122);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 85;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_HACERCHECKIN
            // 
            BTN_HACERCHECKIN.Location = new System.Drawing.Point(165, 122);
            BTN_HACERCHECKIN.Name = "BTN_HACERCHECKIN";
            BTN_HACERCHECKIN.Size = new System.Drawing.Size(173, 35);
            BTN_HACERCHECKIN.TabIndex = 84;
            BTN_HACERCHECKIN.Text = "HACER EL CHECK IN";
            BTN_HACERCHECKIN.UseVisualStyleBackColor = true;
            BTN_HACERCHECKIN.Click += BTN_HACERCHECKIN_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(12, 122);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 83;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(141, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(304, 21);
            label1.TabIndex = 80;
            label1.Text = "ESTE ES EL APARTADO PARA EL CHECK IN!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(191, 15);
            label2.TabIndex = 86;
            label2.Text = "Ingrese el codigo de la reservación:";
            // 
            // TXT_RESERVACION
            // 
            TXT_RESERVACION.Location = new System.Drawing.Point(226, 61);
            TXT_RESERVACION.Name = "TXT_RESERVACION";
            TXT_RESERVACION.Size = new System.Drawing.Size(314, 23);
            TXT_RESERVACION.TabIndex = 87;
            // 
            // FORM_REGISTRO_CHECKIN
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(556, 169);
            ControlBox = false;
            Controls.Add(TXT_RESERVACION);
            Controls.Add(label2);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_HACERCHECKIN);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REGISTRO_CHECKIN";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Check In de las Reservaciones!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_HACERCHECKIN;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_RESERVACION;
    }
}