
namespace PROYECTO_ADADAT
{
    partial class FORM_LOGIN_ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_LOGIN_ADMIN));
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.TXTB_USUARIO = new System.Windows.Forms.TextBox();
            this.TXTB_CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(13, 253);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(209, 79);
            this.BTN_REGRESAR.TabIndex = 0;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(228, 253);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(227, 79);
            this.BTN_SALIR.TabIndex = 1;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Location = new System.Drawing.Point(13, 165);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(442, 82);
            this.BTN_INGRESAR.TabIndex = 2;
            this.BTN_INGRESAR.Text = "INGRESAR";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click);
            // 
            // TXTB_USUARIO
            // 
            this.TXTB_USUARIO.Location = new System.Drawing.Point(122, 87);
            this.TXTB_USUARIO.Name = "TXTB_USUARIO";
            this.TXTB_USUARIO.Size = new System.Drawing.Size(333, 23);
            this.TXTB_USUARIO.TabIndex = 3;
            // 
            // TXTB_CONTRASEÑA
            // 
            this.TXTB_CONTRASEÑA.Location = new System.Drawing.Point(122, 123);
            this.TXTB_CONTRASEÑA.Name = "TXTB_CONTRASEÑA";
            this.TXTB_CONTRASEÑA.PasswordChar = '*';
            this.TXTB_CONTRASEÑA.Size = new System.Drawing.Size(333, 23);
            this.TXTB_CONTRASEÑA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Correo Electronico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "BIENVENIDO AL MENU DE INICIO DE SESIÓN DE ADMINISTRADOR!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "POR FAVOR, INGRESE SUS CREDENCIALES";
            // 
            // FORM_LOGIN_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 347);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTB_CONTRASEÑA);
            this.Controls.Add(this.TXTB_USUARIO);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_LOGIN_ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola, Administrador!";
            this.Load += new System.EventHandler(this.FORM_LOGIN_ADMIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.TextBox TXTB_USUARIO;
        private System.Windows.Forms.TextBox TXTB_CONTRASEÑA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}