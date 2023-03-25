namespace SistemaControlChequesRev2
{
    partial class ExpedirCheque
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
            button1 = new Button();
            button2 = new Button();
            Monto = new TextBox();
            lblNombreBenef = new Label();
            lblFecha = new Label();
            lblMonto = new Label();
            lblConcepto = new Label();
            lblFolio = new Label();
            dateTimePicker1 = new DateTimePicker();
            btn = new Button();
            combConcepto = new ComboBox();
            lblFolioIncrementable = new Label();
            combNombre = new ComboBox();
            btbNuevoBeneficiario = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(365, 223);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(465, 223);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Monto
            // 
            Monto.Location = new Point(189, 96);
            Monto.Name = "Monto";
            Monto.Size = new Size(351, 23);
            Monto.TabIndex = 6;
            // 
            // lblNombreBenef
            // 
            lblNombreBenef.AutoSize = true;
            lblNombreBenef.Location = new Point(32, 20);
            lblNombreBenef.Name = "lblNombreBenef";
            lblNombreBenef.Size = new Size(135, 15);
            lblNombreBenef.TabIndex = 9;
            lblNombreBenef.Text = "Nombre del beneficiario";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(32, 63);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 10;
            lblFecha.Text = "Fecha";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(32, 104);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 11;
            lblMonto.Text = "Monto";
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Location = new Point(32, 140);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(59, 15);
            lblConcepto.TabIndex = 12;
            lblConcepto.Text = "Concepto";
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.Location = new Point(32, 184);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(33, 15);
            lblFolio.TabIndex = 13;
            lblFolio.Text = "Folio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(189, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // btn
            // 
            btn.Location = new Point(414, 141);
            btn.Name = "btn";
            btn.Size = new Size(126, 23);
            btn.TabIndex = 15;
            btn.Text = "Agregar Concepto";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // combConcepto
            // 
            combConcepto.FormattingEnabled = true;
            combConcepto.Location = new Point(189, 141);
            combConcepto.Name = "combConcepto";
            combConcepto.Size = new Size(219, 23);
            combConcepto.TabIndex = 16;
            // 
            // lblFolioIncrementable
            // 
            lblFolioIncrementable.AutoSize = true;
            lblFolioIncrementable.Location = new Point(189, 184);
            lblFolioIncrementable.Name = "lblFolioIncrementable";
            lblFolioIncrementable.Size = new Size(107, 15);
            lblFolioIncrementable.TabIndex = 17;
            lblFolioIncrementable.Text = "autoincrementable";
            // 
            // combNombre
            // 
            combNombre.FormattingEnabled = true;
            combNombre.Location = new Point(189, 17);
            combNombre.Name = "combNombre";
            combNombre.Size = new Size(221, 23);
            combNombre.TabIndex = 18;
            combNombre.SelectedIndexChanged += combNombre_SelectedIndexChanged;
            // 
            // btbNuevoBeneficiario
            // 
            btbNuevoBeneficiario.Location = new Point(416, 17);
            btbNuevoBeneficiario.Name = "btbNuevoBeneficiario";
            btbNuevoBeneficiario.Size = new Size(124, 23);
            btbNuevoBeneficiario.TabIndex = 19;
            btbNuevoBeneficiario.Text = "Agregar Beneficiario";
            btbNuevoBeneficiario.UseVisualStyleBackColor = true;
            btbNuevoBeneficiario.Click += btbNuevoBeneficiario_Click;
            // 
            // ExpedirCheque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(570, 273);
            Controls.Add(btbNuevoBeneficiario);
            Controls.Add(combNombre);
            Controls.Add(lblFolioIncrementable);
            Controls.Add(combConcepto);
            Controls.Add(btn);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFolio);
            Controls.Add(lblConcepto);
            Controls.Add(lblMonto);
            Controls.Add(lblFecha);
            Controls.Add(lblNombreBenef);
            Controls.Add(Monto);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ExpedirCheque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpedirCheque";
            Load += ExpedirCheque_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox Monto;
        private Label lblNombreBenef;
        private Label lblFecha;
        private Label lblMonto;
        private Label lblConcepto;
        private Label lblFolio;
        private DateTimePicker dateTimePicker1;
        private Button btn;
        private ComboBox combConcepto;
        private Label lblFolioIncrementable;
        private ComboBox combNombre;
        private Button btbNuevoBeneficiario;
    }
}