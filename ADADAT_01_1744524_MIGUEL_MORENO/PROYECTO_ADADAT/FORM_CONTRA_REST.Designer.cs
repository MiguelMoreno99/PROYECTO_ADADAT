
namespace PROYECTO_ADADAT
{
    partial class FORM_CONTRA_REST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_CONTRA_REST));
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTB_CONTRASENA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola!, usted entró con una contraseña temporal.\r\n\r\nGenere una contraseña nueva an" +
    "tes de ingresar al programa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Location = new System.Drawing.Point(12, 159);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(444, 54);
            this.BTN_INGRESAR.TabIndex = 1;
            this.BTN_INGRESAR.Text = "GUARDAR E INGRESAR";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(237, 219);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(219, 60);
            this.BTN_SALIR.TabIndex = 2;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(12, 219);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(219, 60);
            this.BTN_REGRESAR.TabIndex = 3;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // TXTB_CONTRASENA
            // 
            this.TXTB_CONTRASENA.Location = new System.Drawing.Point(160, 98);
            this.TXTB_CONTRASENA.Name = "TXTB_CONTRASENA";
            this.TXTB_CONTRASENA.PasswordChar = '*';
            this.TXTB_CONTRASENA.Size = new System.Drawing.Size(240, 23);
            this.TXTB_CONTRASENA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "*La nueva contraseña no deben de ser igual a las \r\núltimas dos contraseñas que ha" +
    "ya tenido este usuario.";
            // 
            // FORM_CONTRA_REST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 291);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTB_CONTRASENA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_CONTRA_REST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana de Generacion de Nueva Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTB_CONTRASENA;
        private System.Windows.Forms.Label label3;
    }
}