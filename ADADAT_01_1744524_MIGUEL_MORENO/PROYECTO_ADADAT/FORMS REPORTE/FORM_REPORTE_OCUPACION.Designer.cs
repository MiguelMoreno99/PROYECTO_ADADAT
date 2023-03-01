
namespace PROYECTO_ADADAT
{
    partial class FORM_REPORTE_OCUPACION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_REPORTE_OCUPACION));
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.BTN_FILTROHOTEL = new System.Windows.Forms.Button();
            this.BTN_FILTROCIUDAD = new System.Windows.Forms.Button();
            this.BTN_FILTROANO = new System.Windows.Forms.Button();
            this.BTN_FILTROPAIS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_FILTRO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(1066, 584);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(102, 34);
            this.BTN_SALIR.TabIndex = 3;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(12, 584);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(102, 34);
            this.BTN_REGRESAR.TabIndex = 2;
            this.BTN_REGRESAR.Text = "REGRESAR";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // BTN_FILTROHOTEL
            // 
            this.BTN_FILTROHOTEL.Location = new System.Drawing.Point(441, 590);
            this.BTN_FILTROHOTEL.Name = "BTN_FILTROHOTEL";
            this.BTN_FILTROHOTEL.Size = new System.Drawing.Size(75, 23);
            this.BTN_FILTROHOTEL.TabIndex = 16;
            this.BTN_FILTROHOTEL.Text = "HOTEL";
            this.BTN_FILTROHOTEL.UseVisualStyleBackColor = true;
            // 
            // BTN_FILTROCIUDAD
            // 
            this.BTN_FILTROCIUDAD.Location = new System.Drawing.Point(360, 590);
            this.BTN_FILTROCIUDAD.Name = "BTN_FILTROCIUDAD";
            this.BTN_FILTROCIUDAD.Size = new System.Drawing.Size(75, 23);
            this.BTN_FILTROCIUDAD.TabIndex = 15;
            this.BTN_FILTROCIUDAD.Text = "CIUDAD";
            this.BTN_FILTROCIUDAD.UseVisualStyleBackColor = true;
            // 
            // BTN_FILTROANO
            // 
            this.BTN_FILTROANO.Location = new System.Drawing.Point(279, 590);
            this.BTN_FILTROANO.Name = "BTN_FILTROANO";
            this.BTN_FILTROANO.Size = new System.Drawing.Size(75, 23);
            this.BTN_FILTROANO.TabIndex = 14;
            this.BTN_FILTROANO.Text = "AÑO";
            this.BTN_FILTROANO.UseVisualStyleBackColor = true;
            // 
            // BTN_FILTROPAIS
            // 
            this.BTN_FILTROPAIS.Location = new System.Drawing.Point(198, 590);
            this.BTN_FILTROPAIS.Name = "BTN_FILTROPAIS";
            this.BTN_FILTROPAIS.Size = new System.Drawing.Size(75, 23);
            this.BTN_FILTROPAIS.TabIndex = 13;
            this.BTN_FILTROPAIS.Text = "PAÍS";
            this.BTN_FILTROPAIS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtrar por:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1142, 15);
            this.label22.TabIndex = 81;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(360, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(473, 21);
            this.label17.TabIndex = 80;
            this.label17.Text = "AQUÍ SE MUESTRA EL REPORTE DE OCUPACIÓN DE LOS HOTELES!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 82;
            this.label2.Text = "Ingrese el filtro aquí:";
            // 
            // TXT_FILTRO
            // 
            this.TXT_FILTRO.Location = new System.Drawing.Point(522, 44);
            this.TXT_FILTRO.Name = "TXT_FILTRO";
            this.TXT_FILTRO.Size = new System.Drawing.Size(274, 23);
            this.TXT_FILTRO.TabIndex = 83;
            // 
            // FORM_REPORTE_OCUPACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 630);
            this.ControlBox = false;
            this.Controls.Add(this.TXT_FILTRO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BTN_FILTROHOTEL);
            this.Controls.Add(this.BTN_FILTROCIUDAD);
            this.Controls.Add(this.BTN_FILTROANO);
            this.Controls.Add(this.BTN_FILTROPAIS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_REPORTE_OCUPACION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Reporte de Ocupación de los Hoteles!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Button BTN_FILTROHOTEL;
        private System.Windows.Forms.Button BTN_FILTROCIUDAD;
        private System.Windows.Forms.Button BTN_FILTROANO;
        private System.Windows.Forms.Button BTN_FILTROPAIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_FILTRO;
    }
}