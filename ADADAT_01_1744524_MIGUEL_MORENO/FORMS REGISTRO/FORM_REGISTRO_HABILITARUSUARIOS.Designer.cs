
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
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_HABILITARUSUARIO = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            TXT_USUARIO = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(270, 153);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(135, 35);
            BTN_SALIR.TabIndex = 89;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_HABILITARUSUARIO
            // 
            BTN_HABILITARUSUARIO.Location = new System.Drawing.Point(109, 153);
            BTN_HABILITARUSUARIO.Name = "BTN_HABILITARUSUARIO";
            BTN_HABILITARUSUARIO.Size = new System.Drawing.Size(145, 35);
            BTN_HABILITARUSUARIO.TabIndex = 88;
            BTN_HABILITARUSUARIO.Text = "HABILITAR USUARIO";
            BTN_HABILITARUSUARIO.UseVisualStyleBackColor = true;
            BTN_HABILITARUSUARIO.Click += BTN_HABILITARUSUARIO_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(12, 153);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 87;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(29, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(369, 21);
            label2.TabIndex = 84;
            label2.Text = "ESTE ES EL APARTADO PARA HABILITAR USUARIOS!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(98, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(215, 15);
            label1.TabIndex = 90;
            label1.Text = "Ingrese el nombre de usuario a habilitar";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_USUARIO
            // 
            TXT_USUARIO.Location = new System.Drawing.Point(64, 71);
            TXT_USUARIO.Name = "TXT_USUARIO";
            TXT_USUARIO.Size = new System.Drawing.Size(288, 23);
            TXT_USUARIO.TabIndex = 91;
            // 
            // FORM_REGISTRO_HABILITARUSUARIOS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(417, 206);
            ControlBox = false;
            Controls.Add(TXT_USUARIO);
            Controls.Add(label1);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_HABILITARUSUARIO);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REGISTRO_HABILITARUSUARIOS";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido a Habilitar Usuarios!";
            Load += FORM_REGISTRO_HABILITARUSUARIOS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_HABILITARUSUARIO;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_USUARIO;
    }
}