
namespace PROYECTO_ADADAT
{
    partial class FORM_MAIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MAIN));
            this.BTN_ADMINISTRADOR = new System.Windows.Forms.Button();
            this.BTN_OPERADOR = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_FECHASISTEMA = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BTN_ADMINISTRADOR
            // 
            this.BTN_ADMINISTRADOR.Location = new System.Drawing.Point(12, 46);
            this.BTN_ADMINISTRADOR.Name = "BTN_ADMINISTRADOR";
            this.BTN_ADMINISTRADOR.Size = new System.Drawing.Size(255, 101);
            this.BTN_ADMINISTRADOR.TabIndex = 0;
            this.BTN_ADMINISTRADOR.Text = "INGRESAR COMO ADMINISTRADOR";
            this.BTN_ADMINISTRADOR.UseVisualStyleBackColor = true;
            this.BTN_ADMINISTRADOR.Click += new System.EventHandler(this.BTN_ADMIN_Click);
            // 
            // BTN_OPERADOR
            // 
            this.BTN_OPERADOR.Location = new System.Drawing.Point(273, 46);
            this.BTN_OPERADOR.Name = "BTN_OPERADOR";
            this.BTN_OPERADOR.Size = new System.Drawing.Size(255, 101);
            this.BTN_OPERADOR.TabIndex = 1;
            this.BTN_OPERADOR.Text = "INGRESAR COMO OPERADOR";
            this.BTN_OPERADOR.UseVisualStyleBackColor = true;
            this.BTN_OPERADOR.Click += new System.EventHandler(this.BTN_OPER_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(12, 153);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(516, 91);
            this.BTN_SALIR.TabIndex = 2;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "FECHA DEL SISTEMA PARA CHECK IN Y CHECK OUT:";
            // 
            // DTP_FECHASISTEMA
            // 
            this.DTP_FECHASISTEMA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FECHASISTEMA.Location = new System.Drawing.Point(363, 14);
            this.DTP_FECHASISTEMA.Name = "DTP_FECHASISTEMA";
            this.DTP_FECHASISTEMA.Size = new System.Drawing.Size(96, 23);
            this.DTP_FECHASISTEMA.TabIndex = 4;
            // 
            // FORM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 255);
            this.Controls.Add(this.DTP_FECHASISTEMA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_OPERADOR);
            this.Controls.Add(this.BTN_ADMINISTRADOR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Programa de Hoteles!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ADMINISTRADOR;
        private System.Windows.Forms.Button BTN_OPERADOR;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_FECHASISTEMA;
    }
}

