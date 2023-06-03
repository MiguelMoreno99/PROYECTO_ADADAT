namespace PROYECTO_ADADAT
{
    partial class FORM_GESTION_RESERVACIONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_GESTION_RESERVACIONES));
            BTN_ACTUALIZAR = new System.Windows.Forms.Button();
            BTN_SALIR = new System.Windows.Forms.Button();
            BTN_REGRESAR = new System.Windows.Forms.Button();
            BTN_EDITAR = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            TXT_DIAS = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            DTP_FECHAFINAL = new System.Windows.Forms.DateTimePicker();
            DTP_FECHAINICIAL = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            CB_NUMEROPERSONAS = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            TXT_PRECIONOCHE = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            LB_ID_RESERVACION = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // BTN_ACTUALIZAR
            // 
            BTN_ACTUALIZAR.Location = new System.Drawing.Point(604, 52);
            BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR";
            BTN_ACTUALIZAR.Size = new System.Drawing.Size(128, 74);
            BTN_ACTUALIZAR.TabIndex = 141;
            BTN_ACTUALIZAR.Text = "ACTUALIZAR LISTA";
            BTN_ACTUALIZAR.UseVisualStyleBackColor = true;
            BTN_ACTUALIZAR.Click += BTN_ACTUALIZAR_Click;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.Location = new System.Drawing.Point(603, 227);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.Size = new System.Drawing.Size(148, 35);
            BTN_SALIR.TabIndex = 139;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.UseVisualStyleBackColor = true;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // BTN_REGRESAR
            // 
            BTN_REGRESAR.Location = new System.Drawing.Point(7, 227);
            BTN_REGRESAR.Name = "BTN_REGRESAR";
            BTN_REGRESAR.Size = new System.Drawing.Size(71, 35);
            BTN_REGRESAR.TabIndex = 138;
            BTN_REGRESAR.Text = "REGRESAR";
            BTN_REGRESAR.UseVisualStyleBackColor = true;
            BTN_REGRESAR.Click += BTN_REGRESAR_Click;
            // 
            // BTN_EDITAR
            // 
            BTN_EDITAR.Location = new System.Drawing.Point(232, 227);
            BTN_EDITAR.Name = "BTN_EDITAR";
            BTN_EDITAR.Size = new System.Drawing.Size(260, 35);
            BTN_EDITAR.TabIndex = 137;
            BTN_EDITAR.Text = "EDITAR RESERVACION";
            BTN_EDITAR.UseVisualStyleBackColor = true;
            BTN_EDITAR.Click += BTN_EDITAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(179, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(479, 21);
            label2.TabIndex = 136;
            label2.Text = "ESTE ES EL APARTADO PARA LA GESTION DE LAS RESERVACIONES!";
            // 
            // TXT_DIAS
            // 
            TXT_DIAS.Location = new System.Drawing.Point(425, 137);
            TXT_DIAS.Name = "TXT_DIAS";
            TXT_DIAS.ReadOnly = true;
            TXT_DIAS.Size = new System.Drawing.Size(80, 23);
            TXT_DIAS.TabIndex = 147;
            TXT_DIAS.TextChanged += TXT_DIAS_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(448, 162);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(32, 15);
            label16.TabIndex = 146;
            label16.Text = "DIAS";
            // 
            // DTP_FECHAFINAL
            // 
            DTP_FECHAFINAL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTP_FECHAFINAL.Location = new System.Drawing.Point(283, 137);
            DTP_FECHAFINAL.Name = "DTP_FECHAFINAL";
            DTP_FECHAFINAL.Size = new System.Drawing.Size(103, 23);
            DTP_FECHAFINAL.TabIndex = 145;
            DTP_FECHAFINAL.ValueChanged += DTP_FECHAFINAL_ValueChanged;
            // 
            // DTP_FECHAINICIAL
            // 
            DTP_FECHAINICIAL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTP_FECHAINICIAL.Location = new System.Drawing.Point(101, 137);
            DTP_FECHAINICIAL.Name = "DTP_FECHAINICIAL";
            DTP_FECHAINICIAL.Size = new System.Drawing.Size(103, 23);
            DTP_FECHAINICIAL.TabIndex = 144;
            DTP_FECHAINICIAL.ValueChanged += DTP_FECHAINICIAL_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(210, 143);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(67, 15);
            label7.TabIndex = 143;
            label7.Text = "Fecha final:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(20, 143);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 15);
            label6.TabIndex = 142;
            label6.Text = "Fecha Inicial:";
            // 
            // CB_NUMEROPERSONAS
            // 
            CB_NUMEROPERSONAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_NUMEROPERSONAS.FormattingEnabled = true;
            CB_NUMEROPERSONAS.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" });
            CB_NUMEROPERSONAS.Location = new System.Drawing.Point(240, 185);
            CB_NUMEROPERSONAS.Name = "CB_NUMEROPERSONAS";
            CB_NUMEROPERSONAS.Size = new System.Drawing.Size(121, 23);
            CB_NUMEROPERSONAS.TabIndex = 149;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(117, 180);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(117, 30);
            label13.TabIndex = 148;
            label13.Text = "Numero de Personas\r\na hospedar:";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_PRECIONOCHE
            // 
            TXT_PRECIONOCHE.Location = new System.Drawing.Point(489, 185);
            TXT_PRECIONOCHE.Name = "TXT_PRECIONOCHE";
            TXT_PRECIONOCHE.ReadOnly = true;
            TXT_PRECIONOCHE.Size = new System.Drawing.Size(129, 23);
            TXT_PRECIONOCHE.TabIndex = 154;
            TXT_PRECIONOCHE.Text = "0";
            TXT_PRECIONOCHE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(624, 188);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(13, 15);
            label15.TabIndex = 153;
            label15.Text = "$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(389, 188);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(94, 15);
            label10.TabIndex = 150;
            label10.Text = "Total Hospedaje:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 15);
            label1.TabIndex = 156;
            label1.Text = "Seleccione un ID de Reservacion:";
            // 
            // LB_ID_RESERVACION
            // 
            LB_ID_RESERVACION.DisplayMember = "id_reservacion";
            LB_ID_RESERVACION.FormattingEnabled = true;
            LB_ID_RESERVACION.ItemHeight = 15;
            LB_ID_RESERVACION.Location = new System.Drawing.Point(240, 47);
            LB_ID_RESERVACION.Name = "LB_ID_RESERVACION";
            LB_ID_RESERVACION.Size = new System.Drawing.Size(323, 79);
            LB_ID_RESERVACION.TabIndex = 157;
            LB_ID_RESERVACION.ValueMember = "id_reservacion";
            LB_ID_RESERVACION.SelectedIndexChanged += LB_ID_RESERVACION_SelectedIndexChanged;
            // 
            // FORM_GESTION_RESERVACIONES
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(763, 281);
            ControlBox = false;
            Controls.Add(LB_ID_RESERVACION);
            Controls.Add(label1);
            Controls.Add(TXT_PRECIONOCHE);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(CB_NUMEROPERSONAS);
            Controls.Add(label13);
            Controls.Add(TXT_DIAS);
            Controls.Add(label16);
            Controls.Add(DTP_FECHAFINAL);
            Controls.Add(DTP_FECHAINICIAL);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BTN_ACTUALIZAR);
            Controls.Add(BTN_SALIR);
            Controls.Add(BTN_REGRESAR);
            Controls.Add(BTN_EDITAR);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FORM_GESTION_RESERVACIONES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenido al Apartado de Gestion de Reservaciones!";
            Load += FORM_GESTION_RESERVACIONES_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_ACTUALIZAR;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_DIAS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker DTP_FECHAFINAL;
        private System.Windows.Forms.DateTimePicker DTP_FECHAINICIAL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_NUMEROPERSONAS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXT_PRECIONOCHE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_ID_RESERVACION;
    }
}