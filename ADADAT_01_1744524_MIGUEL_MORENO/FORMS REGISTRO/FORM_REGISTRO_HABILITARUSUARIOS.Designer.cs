
namespace PROYECTO_ADADAT
{
    partial class FORM_REGISTRO_HABILITARUSUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REGISTRO_HABILITARUSUARIOS));
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_HABILITARUSUARIO = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(270, 419);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(135, 35);
            this.BTN_SALIR.TabIndex = 89;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_HABILITARUSUARIO
            // 
            this.BTN_HABILITARUSUARIO.Location = new System.Drawing.Point(109, 419);
            this.BTN_HABILITARUSUARIO.Name = "BTN_HABILITARUSUARIO";
            this.BTN_HABILITARUSUARIO.Size = new System.Drawing.Size(145, 35);
            this.BTN_HABILITARUSUARIO.TabIndex = 88;
            this.BTN_HABILITARUSUARIO.Text = "HABILITAR USUARIO";
            this.BTN_HABILITARUSUARIO.UseVisualStyleBackColor = true;
            this.BTN_HABILITARUSUARIO.Click += new System.EventHandler(this.BTN_HABILITARUSUARIO_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(12, 419);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            this.BTN_REGRESAR.TabIndex = 87;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 144);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(402, 15);
            this.label22.TabIndex = 86;
            this.label22.Text = "_______________________________________________________________________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(14, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(386, 21);
            this.label17.TabIndex = 85;
            this.label17.Text = "AQUÍ SE MUESTRAN LOS USUARIOS INHABILITADOS!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 21);
            this.label2.TabIndex = 84;
            this.label2.Text = "ESTE ES EL APARTADO PARA HABILITAR USUARIOS!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 90;
            this.label1.Text = "Ingrese el nombre de usuario a habilitar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(64, 71);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(288, 23);
            this.TXT_USUARIO.TabIndex = 91;
            // 
            // FORM_REGISTRO_HABILITARUSUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 466);
            this.ControlBox = false;
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_HABILITARUSUARIO);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REGISTRO_HABILITARUSUARIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a Habilitar Usuarios!";
            this.Load += new System.EventHandler(this.FORM_REGISTRO_HABILITARUSUARIOS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_HABILITARUSUARIO;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_USUARIO;
    }
}