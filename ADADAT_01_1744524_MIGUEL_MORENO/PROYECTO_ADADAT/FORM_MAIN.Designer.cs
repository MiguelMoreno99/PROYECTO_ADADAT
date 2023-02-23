
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
            this.BTN_ADMIN = new System.Windows.Forms.Button();
            this.BTN_OPER = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_ADMIN
            // 
            this.BTN_ADMIN.Location = new System.Drawing.Point(12, 12);
            this.BTN_ADMIN.Name = "BTN_ADMIN";
            this.BTN_ADMIN.Size = new System.Drawing.Size(255, 101);
            this.BTN_ADMIN.TabIndex = 0;
            this.BTN_ADMIN.Text = "INGRESAR COMO ADMINISTRADOR";
            this.BTN_ADMIN.UseVisualStyleBackColor = true;
            this.BTN_ADMIN.Click += new System.EventHandler(this.BTN_ADMIN_Click);
            // 
            // BTN_OPER
            // 
            this.BTN_OPER.Location = new System.Drawing.Point(273, 12);
            this.BTN_OPER.Name = "BTN_OPER";
            this.BTN_OPER.Size = new System.Drawing.Size(255, 101);
            this.BTN_OPER.TabIndex = 1;
            this.BTN_OPER.Text = "INGRESAR COMO OPERADOR";
            this.BTN_OPER.UseVisualStyleBackColor = true;
            this.BTN_OPER.Click += new System.EventHandler(this.BTN_OPER_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(12, 119);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(516, 91);
            this.BTN_SALIR.TabIndex = 2;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.button3_Click);
            // 
            // FORM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 224);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_OPER);
            this.Controls.Add(this.BTN_ADMIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Programa de Hoteles!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_ADMIN;
        private System.Windows.Forms.Button BTN_OPER;
        private System.Windows.Forms.Button BTN_SALIR;
    }
}

