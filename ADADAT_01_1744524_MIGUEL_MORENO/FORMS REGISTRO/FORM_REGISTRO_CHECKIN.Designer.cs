
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
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_HACERCHECKIN = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_RESERVACION = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(392, 122);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            this.BTN_SALIR.TabIndex = 85;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_HACERCHECKIN
            // 
            this.BTN_HACERCHECKIN.Location = new System.Drawing.Point(165, 122);
            this.BTN_HACERCHECKIN.Name = "BTN_HACERCHECKIN";
            this.BTN_HACERCHECKIN.Size = new System.Drawing.Size(173, 35);
            this.BTN_HACERCHECKIN.TabIndex = 84;
            this.BTN_HACERCHECKIN.Text = "HACER EL CHECK IN";
            this.BTN_HACERCHECKIN.UseVisualStyleBackColor = true;
            this.BTN_HACERCHECKIN.Click += new System.EventHandler(this.BTN_HACERCHECKIN_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(12, 122);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            this.BTN_REGRESAR.TabIndex = 83;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "ESTE ES EL APARTADO PARA EL CHECK IN!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 86;
            this.label2.Text = "Ingrese el codigo de la reservación:";
            // 
            // TXT_RESERVACION
            // 
            this.TXT_RESERVACION.Location = new System.Drawing.Point(226, 61);
            this.TXT_RESERVACION.Name = "TXT_RESERVACION";
            this.TXT_RESERVACION.Size = new System.Drawing.Size(314, 23);
            this.TXT_RESERVACION.TabIndex = 87;
            // 
            // FORM_REGISTRO_CHECKIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 169);
            this.ControlBox = false;
            this.Controls.Add(this.TXT_RESERVACION);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_HACERCHECKIN);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REGISTRO_CHECKIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Check In de las Reservaciones!";
            this.ResumeLayout(false);
            this.PerformLayout();

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