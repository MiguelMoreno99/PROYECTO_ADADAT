
namespace PROYECTO_ADADAT
{
    partial class FORM_REPORTE_VENTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REPORTE_VENTAS));
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            BTN_FILTROHOTEL = new System.Windows.Forms.Button();
            BTN_FILTROCIUDAD = new System.Windows.Forms.Button();
            BTN_FILTROANO = new System.Windows.Forms.Button();
            BTN_FILTROPAIS = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            TXT_FILTRO = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(1058, 515);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(102, 34);
            BTN_SALIR.TabIndex = 3;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(6, 515);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(102, 34);
            BTN_REGRESAR.TabIndex = 2;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // BTN_FILTROHOTEL
            // 
            BTN_FILTROHOTEL.Location = new System.Drawing.Point(441, 521);
            BTN_FILTROHOTEL.Name = "BTN_FILTROHOTEL";
            BTN_FILTROHOTEL.Size = new System.Drawing.Size(75, 23);
            BTN_FILTROHOTEL.TabIndex = 11;
            BTN_FILTROHOTEL.Text = "HOTEL";
            BTN_FILTROHOTEL.UseVisualStyleBackColor = true;
            // 
            // BTN_FILTROCIUDAD
            // 
            BTN_FILTROCIUDAD.Location = new System.Drawing.Point(360, 521);
            BTN_FILTROCIUDAD.Name = "BTN_FILTROCIUDAD";
            BTN_FILTROCIUDAD.Size = new System.Drawing.Size(75, 23);
            BTN_FILTROCIUDAD.TabIndex = 10;
            BTN_FILTROCIUDAD.Text = "CIUDAD";
            BTN_FILTROCIUDAD.UseVisualStyleBackColor = true;
            // 
            // BTN_FILTROANO
            // 
            BTN_FILTROANO.Location = new System.Drawing.Point(279, 521);
            BTN_FILTROANO.Name = "BTN_FILTROANO";
            BTN_FILTROANO.Size = new System.Drawing.Size(75, 23);
            BTN_FILTROANO.TabIndex = 9;
            BTN_FILTROANO.Text = "AÑO";
            BTN_FILTROANO.UseVisualStyleBackColor = true;
            // 
            // BTN_FILTROPAIS
            // 
            BTN_FILTROPAIS.Location = new System.Drawing.Point(198, 521);
            BTN_FILTROPAIS.Name = "BTN_FILTROPAIS";
            BTN_FILTROPAIS.Size = new System.Drawing.Size(75, 23);
            BTN_FILTROPAIS.TabIndex = 8;
            BTN_FILTROPAIS.Text = "PAÍS";
            BTN_FILTROPAIS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(131, 525);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 15);
            label1.TabIndex = 7;
            label1.Text = "Filtrar por:";
            // 
            // TXT_FILTRO
            // 
            TXT_FILTRO.Location = new System.Drawing.Point(520, 29);
            TXT_FILTRO.Name = "TXT_FILTRO";
            TXT_FILTRO.Size = new System.Drawing.Size(274, 23);
            TXT_FILTRO.TabIndex = 87;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(400, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 15);
            label2.TabIndex = 86;
            label2.Text = "Ingrese el filtro aquí:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(18, 78);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(1142, 15);
            label22.TabIndex = 85;
            label22.Text = resources.GetString("label22.Text");
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(433, 106);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(318, 21);
            label17.TabIndex = 84;
            label17.Text = "AQUÍ SE MUESTRA EL REPORTE DE VENTAS!";
            // 
            // FORM_REPORTE_VENTAS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1178, 561);
            ControlBox = false;
            Controls.Add(TXT_FILTRO);
            Controls.Add(label2);
            Controls.Add(label22);
            Controls.Add(label17);
            Controls.Add(BTN_FILTROHOTEL);
            Controls.Add(BTN_FILTROCIUDAD);
            Controls.Add(BTN_FILTROANO);
            Controls.Add(BTN_FILTROPAIS);
            Controls.Add(label1);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_REGRESAR);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_REPORTE_VENTAS";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Reporte de Ventas!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Button BTN_FILTROHOTEL;
        private System.Windows.Forms.Button BTN_FILTROCIUDAD;
        private System.Windows.Forms.Button BTN_FILTROANO;
        private System.Windows.Forms.Button BTN_FILTROPAIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_FILTRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
    }
}