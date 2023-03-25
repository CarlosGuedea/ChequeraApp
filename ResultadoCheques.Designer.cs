namespace SistemaControlChequesRev2
{
    partial class ResultadoCheques
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            Folio = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Fecha_Emision = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Folio, Nombre, Monto, Fecha_Emision, Detalle });
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 370);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(591, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "PDF";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(672, 22);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 2;
            button2.Text = "<-- Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Folio
            // 
            Folio.HeaderText = "Folio";
            Folio.Name = "Folio";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Fecha_Emision
            // 
            Fecha_Emision.HeaderText = "Fecha_Emision";
            Fecha_Emision.Name = "Fecha_Emision";
            // 
            // Detalle
            // 
            Detalle.HeaderText = "Detalle";
            Detalle.Name = "Detalle";
            // 
            // ResultadoCheques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ResultadoCheques";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultadoCheques";
            Load += ResultadoCheques_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Folio;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Fecha_Emision;
        private DataGridViewTextBoxColumn Detalle;
    }
}