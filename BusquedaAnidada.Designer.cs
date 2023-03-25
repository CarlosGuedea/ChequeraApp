namespace SistemaControlChequesRev2
{
    partial class BusquedaAnidada
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
            lblNombre = new Label();
            comboBox1 = new ComboBox();
            lblFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblConcepto = new Label();
            comboBox2 = new ComboBox();
            btn = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(53, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(128, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(53, 76);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(128, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Location = new Point(53, 120);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(59, 15);
            lblConcepto.TabIndex = 4;
            lblConcepto.Text = "Concepto";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(128, 112);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 5;
            // 
            // btn
            // 
            btn.Location = new Point(158, 158);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 6;
            btn.Text = "Aceptar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(253, 158);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BusquedaAnidada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(376, 207);
            Controls.Add(btnCancelar);
            Controls.Add(btn);
            Controls.Add(comboBox2);
            Controls.Add(lblConcepto);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFecha);
            Controls.Add(comboBox1);
            Controls.Add(lblNombre);
            Name = "BusquedaAnidada";
            Text = "BusquedaAnidada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private ComboBox comboBox1;
        private Label lblFecha;
        private DateTimePicker dateTimePicker1;
        private Label lblConcepto;
        private ComboBox comboBox2;
        private Button btn;
        private Button btnCancelar;
    }
}