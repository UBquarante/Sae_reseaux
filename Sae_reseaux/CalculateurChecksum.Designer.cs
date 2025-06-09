namespace Sae_reseaux
{
    partial class CalculateurChecksum
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
            lblEquipe = new Label();
            lblAnnee = new Label();
            btnCalcul = new Button();
            lblResultat = new Label();
            txtSaisie = new TextBox();
            IPsource = new Label();
            IPdest = new Label();
            TTL = new Label();
            lblTrame = new Label();
            pbFond = new PictureBox();
            pnlAdditionalInformation = new Panel();
            lblIPSrc = new Label();
            lblIPDest = new Label();
            lblTTL = new Label();
            lblInfomationComplementaire = new Label();
            pnlChecksum = new Panel();
            lblTitrePanelChecksum = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFond).BeginInit();
            pnlAdditionalInformation.SuspendLayout();
            pnlChecksum.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(405, 25);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(408, 46);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Calculateur de Checksum";
            // 
            // lblEquipe
            // 
            lblEquipe.AutoSize = true;
            lblEquipe.BackColor = Color.MidnightBlue;
            lblEquipe.Font = new Font("Segoe UI", 11F);
            lblEquipe.ForeColor = SystemColors.ButtonHighlight;
            lblEquipe.Location = new Point(31, 109);
            lblEquipe.Name = "lblEquipe";
            lblEquipe.Size = new Size(198, 175);
            lblEquipe.TabIndex = 1;
            lblEquipe.Text = "Groupe F3\r\n\r\nLescot Oscar \r\nLe Callennec Julie\r\nLagouge Jeanne\r\nBourel Hecquet Scotty\r\nLeroux Lucas\r\n";
            // 
            // lblAnnee
            // 
            lblAnnee.AutoSize = true;
            lblAnnee.BackColor = Color.MidnightBlue;
            lblAnnee.Font = new Font("Segoe UI", 11F);
            lblAnnee.ForeColor = SystemColors.ButtonHighlight;
            lblAnnee.Location = new Point(997, 109);
            lblAnnee.Name = "lblAnnee";
            lblAnnee.Size = new Size(158, 100);
            lblAnnee.TabIndex = 2;
            lblAnnee.Text = "Année 2024/2025\r\nIUT Amiens\r\nSAE 2.3\r\n\r\n";
            lblAnnee.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCalcul
            // 
            btnCalcul.Cursor = Cursors.SizeNESW;
            btnCalcul.Enabled = false;
            btnCalcul.Font = new Font("Segoe UI", 13F);
            btnCalcul.Location = new Point(537, 331);
            btnCalcul.Margin = new Padding(3, 4, 3, 4);
            btnCalcul.Name = "btnCalcul";
            btnCalcul.Size = new Size(129, 45);
            btnCalcul.TabIndex = 4;
            btnCalcul.Text = "Calculer";
            btnCalcul.UseVisualStyleBackColor = true;
            btnCalcul.Click += Calcul_Click;
            // 
            // lblResultat
            // 
            lblResultat.BackColor = SystemColors.ControlDark;
            lblResultat.BorderStyle = BorderStyle.FixedSingle;
            lblResultat.Font = new Font("Segoe UI", 18F);
            lblResultat.Location = new Point(82, 101);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(241, 85);
            lblResultat.TabIndex = 5;
            lblResultat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSaisie
            // 
            txtSaisie.Font = new Font("Segoe UI", 11F);
            txtSaisie.Location = new Point(440, 133);
            txtSaisie.Margin = new Padding(3, 4, 3, 4);
            txtSaisie.Multiline = true;
            txtSaisie.Name = "txtSaisie";
            txtSaisie.Size = new Size(321, 183);
            txtSaisie.TabIndex = 6;
            txtSaisie.TextChanged += Saisie_TextChanged;
            // 
            // IPsource
            // 
            IPsource.AutoSize = true;
            IPsource.Location = new Point(207, 165);
            IPsource.Name = "IPsource";
            IPsource.Size = new Size(0, 20);
            IPsource.TabIndex = 7;
            // 
            // IPdest
            // 
            IPdest.AutoSize = true;
            IPdest.Location = new Point(207, 116);
            IPdest.Name = "IPdest";
            IPdest.Size = new Size(0, 20);
            IPdest.TabIndex = 8;
            // 
            // TTL
            // 
            TTL.AutoSize = true;
            TTL.Location = new Point(207, 65);
            TTL.Name = "TTL";
            TTL.Size = new Size(0, 20);
            TTL.TabIndex = 9;
            // 
            // lblTrame
            // 
            lblTrame.AutoSize = true;
            lblTrame.BackColor = Color.MidnightBlue;
            lblTrame.Font = new Font("Segoe UI", 11F);
            lblTrame.ForeColor = SystemColors.ButtonHighlight;
            lblTrame.Location = new Point(417, 99);
            lblTrame.Name = "lblTrame";
            lblTrame.Size = new Size(375, 25);
            lblTrame.TabIndex = 10;
            lblTrame.Text = "Veuillez renseigner votre trame ci dessous :";
            // 
            // pbFond
            // 
            pbFond.BackColor = Color.MidnightBlue;
            pbFond.Location = new Point(-2, 88);
            pbFond.Name = "pbFond";
            pbFond.Size = new Size(1345, 323);
            pbFond.TabIndex = 11;
            pbFond.TabStop = false;
            // 
            // pnlAdditionalInformation
            // 
            pnlAdditionalInformation.BackColor = SystemColors.ControlLightLight;
            pnlAdditionalInformation.Controls.Add(lblIPSrc);
            pnlAdditionalInformation.Controls.Add(lblIPDest);
            pnlAdditionalInformation.Controls.Add(TTL);
            pnlAdditionalInformation.Controls.Add(lblTTL);
            pnlAdditionalInformation.Controls.Add(IPdest);
            pnlAdditionalInformation.Controls.Add(lblInfomationComplementaire);
            pnlAdditionalInformation.Controls.Add(IPsource);
            pnlAdditionalInformation.Location = new Point(709, 448);
            pnlAdditionalInformation.Name = "pnlAdditionalInformation";
            pnlAdditionalInformation.Size = new Size(411, 243);
            pnlAdditionalInformation.TabIndex = 12;
            // 
            // lblIPSrc
            // 
            lblIPSrc.AutoSize = true;
            lblIPSrc.Location = new Point(42, 165);
            lblIPSrc.Name = "lblIPSrc";
            lblIPSrc.Size = new Size(77, 20);
            lblIPSrc.TabIndex = 10;
            lblIPSrc.Text = "IP Source :";
            // 
            // lblIPDest
            // 
            lblIPDest.AutoSize = true;
            lblIPDest.Location = new Point(42, 116);
            lblIPDest.Name = "lblIPDest";
            lblIPDest.Size = new Size(112, 20);
            lblIPDest.TabIndex = 9;
            lblIPDest.Text = "IP Destinataire :";
            // 
            // lblTTL
            // 
            lblTTL.AutoSize = true;
            lblTTL.Location = new Point(42, 65);
            lblTTL.Name = "lblTTL";
            lblTTL.Size = new Size(136, 20);
            lblTTL.TabIndex = 8;
            lblTTL.Text = "TTL (Time To Live) :";
            // 
            // lblInfomationComplementaire
            // 
            lblInfomationComplementaire.AutoSize = true;
            lblInfomationComplementaire.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInfomationComplementaire.Location = new Point(87, 16);
            lblInfomationComplementaire.Name = "lblInfomationComplementaire";
            lblInfomationComplementaire.Size = new Size(295, 28);
            lblInfomationComplementaire.TabIndex = 0;
            lblInfomationComplementaire.Text = "Informations Complémentaires\r\n";
            // 
            // pnlChecksum
            // 
            pnlChecksum.BackColor = SystemColors.ControlLightLight;
            pnlChecksum.Controls.Add(lblTitrePanelChecksum);
            pnlChecksum.Controls.Add(lblResultat);
            pnlChecksum.Location = new Point(71, 448);
            pnlChecksum.Name = "pnlChecksum";
            pnlChecksum.Size = new Size(411, 243);
            pnlChecksum.TabIndex = 13;
            // 
            // lblTitrePanelChecksum
            // 
            lblTitrePanelChecksum.AutoSize = true;
            lblTitrePanelChecksum.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitrePanelChecksum.Location = new Point(133, 40);
            lblTitrePanelChecksum.Name = "lblTitrePanelChecksum";
            lblTitrePanelChecksum.Size = new Size(141, 32);
            lblTitrePanelChecksum.TabIndex = 0;
            lblTitrePanelChecksum.Text = "CHECKSUM\r\n";
            // 
            // CalculateurChecksum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 749);
            Controls.Add(pnlChecksum);
            Controls.Add(pnlAdditionalInformation);
            Controls.Add(lblTrame);
            Controls.Add(txtSaisie);
            Controls.Add(btnCalcul);
            Controls.Add(lblAnnee);
            Controls.Add(lblEquipe);
            Controls.Add(lblTitre);
            Controls.Add(pbFond);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CalculateurChecksum";
            Text = "Calculateur de Checksum";
            ((System.ComponentModel.ISupportInitialize)pbFond).EndInit();
            pnlAdditionalInformation.ResumeLayout(false);
            pnlAdditionalInformation.PerformLayout();
            pnlChecksum.ResumeLayout(false);
            pnlChecksum.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Label lblEquipe;
        private Label lblAnnee;
        private Button btnCalcul;
        private Label lblResultat;
        private TextBox txtSaisie;
        private Label IPsource;
        private Label IPdest;
        private Label TTL;
        private Label lblTrame;
        private PictureBox pbFond;
        private Panel pnlAdditionalInformation;
        private Label lblInfomationComplementaire;
        private Label lblTTL;
        private Label lblIPDest;
        private Label lblIPSrc;
        private Panel pnlChecksum;
        private Label lblTitrePanelChecksum;
    }
}
