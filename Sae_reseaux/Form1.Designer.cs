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
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(423, 35);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(408, 46);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Calculateur de Checksum";
            lblTitre.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(36, 409);
            label1.Name = "label1";
            label1.Size = new Size(198, 175);
            label1.TabIndex = 1;
            label1.Text = "Groupe F3\r\n\r\nLescot Oscar \r\nLe Callennec Julie\r\nLagouge Jeanne\r\nBourel Hecquet Scotty\r\nLeroux Lucas\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(36, 591);
            label2.Name = "label2";
            label2.Size = new Size(163, 75);
            label2.TabIndex = 2;
            label2.Text = "Année 2024/2025 \r\nIUT Amiens\r\nSAE 2.3\r\n";
            label2.Click += label2_Click;
            // 
            // Calcul
            // 
            Calcul.Cursor = Cursors.SizeNESW;
            Calcul.Enabled = false;
            Calcul.Font = new Font("Segoe UI", 13F);
            Calcul.Location = new Point(559, 324);
            Calcul.Margin = new Padding(3, 4, 3, 4);
            Calcul.Name = "Calcul";
            Calcul.Size = new Size(129, 45);
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
            Resultat.Location = new Point(321, 602);
            Resultat.Name = "Resultat";
            Resultat.Size = new Size(284, 89);
            Resultat.TabIndex = 5;
            Resultat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Saisie
            // 
            Saisie.Font = new Font("Segoe UI", 11F);
            Saisie.Location = new Point(463, 133);
            Saisie.Margin = new Padding(3, 4, 3, 4);
            Saisie.Multiline = true;
            Saisie.Name = "Saisie";
            Saisie.Size = new Size(321, 183);
            Saisie.TabIndex = 6;
            Saisie.TextChanged += Saisie_TextChanged;
            // 
            // IPsource
            // 
            IPsource.AutoSize = true;
            IPsource.Location = new Point(207, 166);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MidnightBlue;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(439, 99);
            label3.Name = "label3";
            label3.Size = new Size(375, 25);
            label3.TabIndex = 10;
            label3.Text = "Veuillez renseigner votre trame ci dessous :";
            label3.Click += label3_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.Location = new Point(-1, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1345, 299);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TTL);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(IPdest);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(IPsource);
            panel1.Location = new Point(708, 448);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 243);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 166);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 10;
            label7.Text = "IP Source :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 116);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 9;
            label6.Text = "IP Destinataire :";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 65);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 8;
            label5.Text = "TTL (Time To Live) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 21);
            label4.Name = "label4";
            label4.Size = new Size(271, 25);
            label4.TabIndex = 0;
            label4.Text = "Informations Complémentaires\r\n";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(Saisie);
            Controls.Add(Resultat);
            Controls.Add(Calcul);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitre);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
