﻿namespace Sae_reseaux
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
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 20F);
            lblTitre.Location = new Point(255, 24);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(314, 37);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Calculateur de Checksum";
            lblTitre.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(188, 175);
            label1.TabIndex = 1;
            label1.Text = "Groupe F3\r\n\r\nLescot Oscar \r\nLe Callennec Julie\r\nLagouge Jeanne\r\nBourel Hecquet Scotty\r\nLeroux Lucas\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(12, 291);
            label2.Name = "label2";
            label2.Size = new Size(159, 100);
            label2.TabIndex = 2;
            label2.Text = "Année 2024/2025 \r\nIUT Amiens\r\nSAE 2.3\r\n\r\n";
            label2.Click += label2_Click;
            // 
            // Calcul
            // 
            Calcul.Cursor = Cursors.SizeNESW;
            Calcul.Font = new Font("Segoe UI", 13F);
            Calcul.Location = new Point(539, 246);
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
            Resultat.Location = new Point(471, 293);
            Resultat.Name = "Resultat";
            Resultat.Size = new Size(249, 86);
            Resultat.TabIndex = 5;
            Resultat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Saisie
            // 
            Saisie.Font = new Font("Segoe UI", 11F);
            Saisie.Location = new Point(471, 89);
            Saisie.Multiline = true;
            Saisie.Name = "Saisie";
            Saisie.Size = new Size(249, 138);
            Saisie.TabIndex = 6;
            // 
            // IPsource
            // 
            IPsource.AutoSize = true;
            IPsource.Location = new Point(471, 379);
            IPsource.Name = "IPsource";
            IPsource.Size = new Size(0, 15);
            IPsource.TabIndex = 7;
            // 
            // IPdest
            // 
            IPdest.AutoSize = true;
            IPdest.Location = new Point(471, 394);
            IPdest.Name = "IPdest";
            IPdest.Size = new Size(0, 15);
            IPdest.TabIndex = 8;
            // 
            // TTL
            // 
            TTL.AutoSize = true;
            TTL.Location = new Point(471, 409);
            TTL.Name = "TTL";
            TTL.Size = new Size(0, 15);
            TTL.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TTL);
            Controls.Add(IPdest);
            Controls.Add(IPsource);
            Controls.Add(Saisie);
            Controls.Add(Resultat);
            Controls.Add(Calcul);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
