
namespace PROYECTO_ADADAT
{
    partial class FORM_REGISTRO_CHECKOUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REGISTRO_CHECKOUT));
            TXT_RESERVACION = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_HACERCHECKOUT = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            DTP_FECHACHECKOUT = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // TXT_RESERVACION
            // 
            TXT_RESERVACION.Location = new System.Drawing.Point(209, 80);
            TXT_RESERVACION.Name = "TXT_RESERVACION";
            TXT_RESERVACION.Size = new System.Drawing.Size(274, 23);
            TXT_RESERVACION.TabIndex = 95;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(191, 15);
            label2.TabIndex = 94;
            label2.Text = "Ingrese el codigo de la reservación:";
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(335, 170);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 93;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_HACERCHECKOUT
            // 
            BTN_HACERCHECKOUT.Location = new System.Drawing.Point(111, 170);
            BTN_HACERCHECKOUT.Name = "BTN_HACERCHECKOUT";
            BTN_HACERCHECKOUT.Size = new System.Drawing.Size(204, 35);
            BTN_HACERCHECKOUT.TabIndex = 92;
            BTN_HACERCHECKOUT.Text = "HACER EL CHECK OUT Y COBRAR";
            BTN_HACERCHECKOUT.UseVisualStyleBackColor = true;
            BTN_HACERCHECKOUT.Click += BTN_GUARDAR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(12, 170);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 91;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(111, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(319, 21);
            label1.TabIndex = 88;
            label1.Text = "ESTE ES EL APARTADO PARA EL CHECK OUT!";
            // 
            // DTP_FECHACHECKOUT
            // 
            DTP_FECHACHECKOUT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTP_FECHACHECKOUT.Location = new System.Drawing.Point(292, 115);
            DTP_FECHACHECKOUT.Name = "DTP_FECHACHECKOUT";
            DTP_FECHACHECKOUT.Size = new System.Drawing.Size(115, 23);
            DTP_FECHACHECKOUT.TabIndex = 96;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(111, 121);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(166, 15);
            label3.TabIndex = 97;
            label3.Text = "Ingrese la fecha del check out:";
            // 
            // FORM_REGISTRO_CHECKOUT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(515, 217);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(DTP_FECHACHECKOUT);
            Controls.Add(TXT_RESERVACION);
            Controls.Add(label2);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_HACERCHECKOUT);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REGISTRO_CHECKOUT";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Check Out de las Reservaciones!";
            Load += FORM_REGISTRO_CHECKOUT_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox TXT_RESERVACION;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_HACERCHECKOUT;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_FECHACHECKOUT;
        private System.Windows.Forms.Label label3;
    }
}