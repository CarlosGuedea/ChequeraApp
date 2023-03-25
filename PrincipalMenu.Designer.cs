namespace SistemaControlChequesRev2
{
    partial class PrincipalMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMenu));
            btnExpedirCheque = new Button();
            btnBuscar = new Button();
            btnDeposito = new Button();
            btnFolios = new Button();
            btnReportes = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExpedirCheque
            // 
            btnExpedirCheque.Location = new Point(36, 264);
            btnExpedirCheque.Name = "btnExpedirCheque";
            btnExpedirCheque.Size = new Size(146, 67);
            btnExpedirCheque.TabIndex = 0;
            btnExpedirCheque.Text = "Expedir cheque";
            btnExpedirCheque.UseVisualStyleBackColor = true;
            btnExpedirCheque.Click += btnExpedirCheque_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(188, 264);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 67);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(340, 264);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(146, 67);
            btnDeposito.TabIndex = 2;
            btnDeposito.Text = "Depositos";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnFolios
            // 
            btnFolios.Location = new Point(492, 264);
            btnFolios.Name = "btnFolios";
            btnFolios.Size = new Size(146, 67);
            btnFolios.TabIndex = 3;
            btnFolios.Text = "Folios";
            btnFolios.UseVisualStyleBackColor = true;
            btnFolios.Click += btnFolios_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(644, 264);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(146, 67);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(824, 272);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(66, 50);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(279, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 237);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // PrincipalMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(930, 346);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnReportes);
            Controls.Add(btnFolios);
            Controls.Add(btnDeposito);
            Controls.Add(btnBuscar);
            Controls.Add(btnExpedirCheque);
            Name = "PrincipalMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrincipalMenu";
            Load += PrincipalMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExpedirCheque;
        private Button btnBuscar;
        private Button btnDeposito;
        private Button btnFolios;
        private Button btnReportes;
        private Button btnLogout;
        private PictureBox pictureBox1;
    }
}