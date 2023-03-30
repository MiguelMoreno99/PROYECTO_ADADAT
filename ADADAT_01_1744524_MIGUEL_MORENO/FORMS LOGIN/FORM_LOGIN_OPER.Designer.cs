
namespace PROYECTO_ADADAT
{
    partial class FORM_LOGIN_OPER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_LOGIN_OPER));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_CONTRASENA = new System.Windows.Forms.TextBox();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "POR FAVOR, INGRESE SUS CREDENCIALES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "BIENVENIDO AL MENU DE INICIO DE SESIÓN DE OPERADOR!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Correo Electronico:";
            // 
            // TXT_CONTRASENA
            // 
            this.TXT_CONTRASENA.Location = new System.Drawing.Point(124, 126);
            this.TXT_CONTRASENA.Name = "TXT_CONTRASENA";
            this.TXT_CONTRASENA.PasswordChar = '*';
            this.TXT_CONTRASENA.Size = new System.Drawing.Size(333, 23);
            this.TXT_CONTRASENA.TabIndex = 13;
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(124, 90);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(333, 23);
            this.TXT_USUARIO.TabIndex = 12;
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Location = new System.Drawing.Point(15, 168);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(442, 82);
            this.BTN_INGRESAR.TabIndex = 11;
            this.BTN_INGRESAR.Text = "INGRESAR";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(230, 256);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(227, 79);
            this.BTN_SALIR.TabIndex = 10;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(15, 256);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(209, 79);
            this.BTN_REGRESAR.TabIndex = 9;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // FORM_LOGIN_OPER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 349);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_CONTRASENA);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_LOGIN_OPER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola, Operador!";
            this.Load += new System.EventHandler(this.FORM_LOGIN_OPER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_CONTRASENA;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_REGRESAR;
    }
}