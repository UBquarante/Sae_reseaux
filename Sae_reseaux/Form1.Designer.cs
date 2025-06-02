namespace Sae_reseaux
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitre = new Label();
            label1 = new Label();
            label2 = new Label();
            Calcul = new Button();
            Resultat = new Label();
            Saisie = new TextBox();
            IPsource = new Label();
            IPdest = new Label();
            TTL = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            PanelAdditionalInformation = new Panel();
            lblIPSrc = new Label();
            lblIPDest = new Label();
            lblTTL = new Label();
            label4 = new Label();
            PanelChecksum = new Panel();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelAdditionalInformation.SuspendLayout();
            PanelChecksum.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(354, 19);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(325, 37);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Calculateur de Checksum";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 82);
            label1.Name = "label1";
            label1.Size = new Size(157, 140);
            label1.TabIndex = 1;
            label1.Text = "Groupe F3\r\n\r\nLescot Oscar \r\nLe Callennec Julie\r\nLagouge Jeanne\r\nBourel Hecquet Scotty\r\nLeroux Lucas\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MidnightBlue;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(872, 82);
            label2.Name = "label2";
            label2.Size = new Size(125, 80);
            label2.TabIndex = 2;
            label2.Text = "Année 2024/2025\r\nIUT Amiens\r\nSAE 2.3\r\n\r\n";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // Calcul
            // 
            Calcul.Cursor = Cursors.SizeNESW;
            Calcul.Enabled = false;
            Calcul.Font = new Font("Segoe UI", 13F);
            Calcul.Location = new Point(470, 248);
            Calcul.Name = "Calcul";
            Calcul.Size = new Size(113, 34);
            Calcul.TabIndex = 4;
            Calcul.Text = "Calculer";
            Calcul.UseVisualStyleBackColor = true;
            Calcul.Click += Calcul_Click;
            // 
            // Resultat
            // 
            Resultat.BackColor = SystemColors.ControlDark;
            Resultat.BorderStyle = BorderStyle.FixedSingle;
            Resultat.Font = new Font("Segoe UI", 18F);
            Resultat.Location = new Point(72, 76);
            Resultat.Name = "Resultat";
            Resultat.Size = new Size(211, 64);
            Resultat.TabIndex = 5;
            Resultat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Saisie
            // 
            Saisie.Font = new Font("Segoe UI", 11F);
            Saisie.Location = new Point(385, 100);
            Saisie.Multiline = true;
            Saisie.Name = "Saisie";
            Saisie.Size = new Size(281, 138);
            Saisie.TabIndex = 6;
            Saisie.TextChanged += Saisie_TextChanged;
            // 
            // IPsource
            // 
            IPsource.AutoSize = true;
            IPsource.Location = new Point(181, 124);
            IPsource.Name = "IPsource";
            IPsource.Size = new Size(0, 15);
            IPsource.TabIndex = 7;
            // 
            // IPdest
            // 
            IPdest.AutoSize = true;
            IPdest.Location = new Point(181, 87);
            IPdest.Name = "IPdest";
            IPdest.Size = new Size(0, 15);
            IPdest.TabIndex = 8;
            // 
            // TTL
            // 
            TTL.AutoSize = true;
            TTL.Location = new Point(181, 49);
            TTL.Name = "TTL";
            TTL.Size = new Size(0, 15);
            TTL.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MidnightBlue;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(365, 74);
            label3.Name = "label3";
            label3.Size = new Size(292, 20);
            label3.TabIndex = 10;
            label3.Text = "Veuillez renseigner votre trame ci dessous :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.Location = new Point(-2, 66);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1177, 242);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // PanelAdditionalInformation
            // 
            PanelAdditionalInformation.BackColor = SystemColors.ControlLightLight;
            PanelAdditionalInformation.Controls.Add(lblIPSrc);
            PanelAdditionalInformation.Controls.Add(lblIPDest);
            PanelAdditionalInformation.Controls.Add(TTL);
            PanelAdditionalInformation.Controls.Add(lblTTL);
            PanelAdditionalInformation.Controls.Add(IPdest);
            PanelAdditionalInformation.Controls.Add(label4);
            PanelAdditionalInformation.Controls.Add(IPsource);
            PanelAdditionalInformation.Location = new Point(620, 336);
            PanelAdditionalInformation.Margin = new Padding(3, 2, 3, 2);
            PanelAdditionalInformation.Name = "PanelAdditionalInformation";
            PanelAdditionalInformation.Size = new Size(360, 182);
            PanelAdditionalInformation.TabIndex = 12;
            // 
            // lblIPSrc
            // 
            lblIPSrc.AutoSize = true;
            lblIPSrc.Location = new Point(37, 124);
            lblIPSrc.Name = "lblIPSrc";
            lblIPSrc.Size = new Size(62, 15);
            lblIPSrc.TabIndex = 10;
            lblIPSrc.Text = "IP Source :";
            // 
            // lblIPDest
            // 
            lblIPDest.AutoSize = true;
            lblIPDest.Location = new Point(37, 87);
            lblIPDest.Name = "lblIPDest";
            lblIPDest.Size = new Size(88, 15);
            lblIPDest.TabIndex = 9;
            lblIPDest.Text = "IP Destinataire :";
            // 
            // lblTTL
            // 
            lblTTL.AutoSize = true;
            lblTTL.Location = new Point(37, 49);
            lblTTL.Name = "lblTTL";
            lblTTL.Size = new Size(111, 15);
            lblTTL.TabIndex = 8;
            lblTTL.Text = "TTL (Time To Live) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(76, 12);
            label4.Name = "label4";
            label4.Size = new Size(237, 21);
            label4.TabIndex = 0;
            label4.Text = "Informations Complémentaires\r\n";
            // 
            // PanelChecksum
            // 
            PanelChecksum.BackColor = SystemColors.ControlLightLight;
            PanelChecksum.Controls.Add(label13);
            PanelChecksum.Controls.Add(Resultat);
            PanelChecksum.Location = new Point(62, 336);
            PanelChecksum.Margin = new Padding(3, 2, 3, 2);
            PanelChecksum.Name = "PanelChecksum";
            PanelChecksum.Size = new Size(360, 182);
            PanelChecksum.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label13.Location = new Point(116, 30);
            label13.Name = "label13";
            label13.Size = new Size(113, 25);
            label13.TabIndex = 0;
            label13.Text = "CHECKSUM\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 562);
            Controls.Add(PanelChecksum);
            Controls.Add(PanelAdditionalInformation);
            Controls.Add(label3);
            Controls.Add(Saisie);
            Controls.Add(Calcul);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitre);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelAdditionalInformation.ResumeLayout(false);
            PanelAdditionalInformation.PerformLayout();
            PanelChecksum.ResumeLayout(false);
            PanelChecksum.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Label label1;
        private Label label2;
        private Button Calcul;
        private Label Resultat;
        private TextBox Saisie;
        private Label IPsource;
        private Label IPdest;
        private Label TTL;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel PanelAdditionalInformation;
        private Label label4;
        private Label lblTTL;
        private Label lblIPDest;
        private Label lblIPSrc;
        private Panel PanelChecksum;
        private Label label13;
    }
}
