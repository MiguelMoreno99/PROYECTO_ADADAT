
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
            this.TXT_RESERVACION = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_HACERCHECKOUT = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_FECHACHECKOUT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_RESERVACION
            // 
            this.TXT_RESERVACION.Location = new System.Drawing.Point(372, 81);
            this.TXT_RESERVACION.Name = "TXT_RESERVACION";
            this.TXT_RESERVACION.Size = new System.Drawing.Size(177, 23);
            this.TXT_RESERVACION.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "Ingrese el codigo de la reservación:";
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(556, 480);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            this.BTN_SALIR.TabIndex = 93;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_HACERCHECKOUT
            // 
            this.BTN_HACERCHECKOUT.Location = new System.Drawing.Point(175, 480);
            this.BTN_HACERCHECKOUT.Name = "BTN_HACERCHECKOUT";
            this.BTN_HACERCHECKOUT.Size = new System.Drawing.Size(204, 35);
            this.BTN_HACERCHECKOUT.TabIndex = 92;
            this.BTN_HACERCHECKOUT.Text = "HACER EL CHECK OUT Y COBRAR";
            this.BTN_HACERCHECKOUT.UseVisualStyleBackColor = true;
            this.BTN_HACERCHECKOUT.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(12, 480);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            this.BTN_REGRESAR.TabIndex = 91;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 139);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(697, 15);
            this.label22.TabIndex = 90;
            this.label22.Text = "_________________________________________________________________________________" +
    "_________________________________________________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(150, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(423, 21);
            this.label17.TabIndex = 89;
            this.label17.Text = "AQUÍ SE MUESTRAN LAS RESERVACIONES CON CHECK IN!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 21);
            this.label1.TabIndex = 88;
            this.label1.Text = "ESTE ES EL APARTADO PARA EL CHECK OUT!";
            // 
            // DTP_FECHACHECKOUT
            // 
            this.DTP_FECHACHECKOUT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FECHACHECKOUT.Location = new System.Drawing.Point(372, 111);
            this.DTP_FECHACHECKOUT.Name = "DTP_FECHACHECKOUT";
            this.DTP_FECHACHECKOUT.Size = new System.Drawing.Size(115, 23);
            this.DTP_FECHACHECKOUT.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "Ingrese la fecha del check out:";
            // 
            // FORM_REGISTRO_CHECKOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 529);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTP_FECHACHECKOUT);
            this.Controls.Add(this.TXT_RESERVACION);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_HACERCHECKOUT);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REGISTRO_CHECKOUT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Check Out de las Reservaciones!";
            this.Load += new System.EventHandler(this.FORM_REGISTRO_CHECKOUT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_RESERVACION;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_HACERCHECKOUT;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_FECHACHECKOUT;
        private System.Windows.Forms.Label label3;
    }
}